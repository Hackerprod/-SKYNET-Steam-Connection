using SteamKit2;
using SteamKit2.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace SKYNET
{
    public class SteamManager
    {
        public event EventHandler<SteamManager> OnLoginSuccess;
        public event EventHandler<SteamManager> OnLoginError;
        public event EventHandler<SteamManager> OnSteamGuardRequest;
        public event EventHandler<string> OnMessage;

        public SteamClient steamClient;
        public CallbackManager callbackManager;
        public SteamUser steamUser;
        public SteamFriends steamFriends;
        public uint AppID;
        public string Username;
        public string Password;

        private bool isRunning;
        private string authCode;
        private string twoFactorAuth;
        private System.Timers.Timer _timer;

        public void Initialize()
        {
            _timer = new System.Timers.Timer();
            _timer.Interval = 1000;
            _timer.Elapsed += _timer_Elapsed;
            _timer.AutoReset = true;

            // create our steamclient instance
            steamClient = new SteamClient();

            // create the callback manager which will route callbacks to function calls
            callbackManager = new CallbackManager(steamClient);

            // get the steamuser handler, which is used for logging on after successfully connecting
            steamUser = steamClient.GetHandler<SteamUser>();
            steamFriends = steamClient.GetHandler<SteamFriends>();

            // register a few callbacks we're interested in
            // these are registered upon creation to a callback manager, which will then route the callbacks
            // to the functions specified
            callbackManager.Subscribe<SteamClient.ConnectedCallback>(OnConnected);
            callbackManager.Subscribe<SteamClient.DisconnectedCallback>(OnDisconnected);

            callbackManager.Subscribe<SteamUser.LoggedOnCallback>(OnLoggedOn);
            callbackManager.Subscribe<SteamUser.LoggedOffCallback>(OnLoggedOff);

            // this callback is triggered when the steam servers wish for the client to store the sentry file
            callbackManager.Subscribe<SteamUser.UpdateMachineAuthCallback>(OnMachineAuth);
            // we use the following callbacks for friends related activities
            callbackManager.Subscribe<SteamUser.AccountInfoCallback>(OnAccountInfo);
            //manager.Subscribe<SteamFriends.FriendsListCallback>(OnFriendsList);
            //manager.Subscribe<SteamFriends.PersonaStateCallback>(OnPersonaState);
            //manager.Subscribe<SteamFriends.FriendAddedCallback>(OnFriendAdded);
        }

        private async void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // in order for the callbacks to get routed, they need to be handled by the manager
            callbackManager.RunWaitCallbacks(TimeSpan.FromSeconds(1));
        }

        public void Login(string username, string password)
        {
            Username = username;
            Password = password;

            isRunning = true;

            _timer.Start();

            WriteLine("Connecting to Steam...");

            // initiate the connection
            steamClient.Connect();
        }

        void OnConnected(SteamClient.ConnectedCallback callback)
        {
            WriteLine($"Connected to Steam! Logging in '{Username}'");

            byte[] sentryHash = null;
            if (File.Exists("sentry.bin"))
            {
                // if we have a saved sentry file, read and sha-1 hash it
                byte[] sentryFile = File.ReadAllBytes("sentry.bin");
                sentryHash = CryptoHelper.SHAHash(sentryFile);
            }

            steamUser.LogOn(new SteamUser.LogOnDetails
            {
                Username = Username,
                Password = Password,

                // in this sample, we pass in an additional authcode
                // this value will be null (which is the default) for our first logon attempt
                AuthCode = authCode,

                // if the account is using 2-factor auth, we'll provide the two factor code instead
                // this will also be null on our first logon attempt
                TwoFactorCode = twoFactorAuth,

                // our subsequent logons use the hash of the sentry file as proof of ownership of the file
                // this will also be null for our first (no authcode) and second (authcode only) logon attempts
                SentryFileHash = sentryHash,
            });
        }

        async void OnDisconnected(SteamClient.DisconnectedCallback callback)
        {
            // after recieving an AccountLogonDenied, we'll be disconnected from steam
            // so after we read an authcode from the user, we need to reconnect to begin the logon flow again

            WriteLine("Disconnected from Steam, reconnecting in 5 seconds");

            await Task.Delay(5000);

            steamClient.Connect();
        }

        async void  OnLoggedOn(SteamUser.LoggedOnCallback callback)
        {
            bool isSteamGuard = callback.Result == EResult.AccountLogonDenied;
            bool is2FA = callback.Result == EResult.AccountLoginDeniedNeedTwoFactor;

            if (isSteamGuard || is2FA)
            {
                WriteLine("This account is SteamGuard protected!");

                if (is2FA)
                {
                    OnSteamGuardRequest?.Invoke(this, this);
                    Console.Write("Please enter your 2 factor auth code from your authenticator app: ");
                    twoFactorAuth = Console.ReadLine();
                }
                else
                {
                    Console.Write("Please enter the auth code sent to the email at {0}: ", callback.EmailDomain);
                    authCode = Console.ReadLine();
                }

                return;
            }

            if (callback.Result != EResult.OK)
            {
                WriteLine($"Unable to logon to Steam: {callback.Result} / {callback.ExtendedResult}");
                await Task.Delay(5000);
                isRunning = false;
                return;
            }

            WriteLine("Successfully logged on!");

            steamFriends.SetPersonaState(EPersonaState.Online);

            OnLoginSuccess?.Invoke(this, this);

            OpenGame(AppID);

            // at this point, we'd be able to perform actions on Steam
        }

        void OnAccountInfo(SteamUser.AccountInfoCallback callback)
        {
            // before being able to interact with friends, you must wait for the account info callback
            // this callback is posted shortly after a successful logon

            // at this point, we can go online on friends, so lets do that
            steamFriends.SetPersonaState(EPersonaState.Online);
        }

        private void OpenGame(uint appId)
        {
            WriteLine($"Oppening game {appId}", false);

            // steamkit doesn't expose the "play game" message through any handler, so we'll just send the message manually
            var playGame = new ClientMsgProtobuf<CMsgClientGamesPlayed>(EMsg.ClientGamesPlayed);

            playGame.Body.games_played.Add(new CMsgClientGamesPlayed.GamePlayed
            {
                game_id = new GameID(appId), // or game_id = APPID,
            });

            // send it off
            // notice here we're sending this message directly using the SteamClient
            steamClient.Send(playGame);
        }

        void OnLoggedOff(SteamUser.LoggedOffCallback callback)
        {
            WriteLine($"Logged off of Steam: {callback.Result}");
        }

        void OnMachineAuth(SteamUser.UpdateMachineAuthCallback callback)
        {
            WriteLine("Updating sentryfile...");

            // write out our sentry file
            // ideally we'd want to write to the filename specified in the callback
            // but then this sample would require more code to find the correct sentry file to read during logon
            // for the sake of simplicity, we'll just use "sentry.bin"

            int fileSize;
            byte[] sentryHash;
            using (var fs = File.Open("sentry.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.Seek(callback.Offset, SeekOrigin.Begin);
                fs.Write(callback.Data, 0, callback.BytesToWrite);
                fileSize = (int)fs.Length;

                fs.Seek(0, SeekOrigin.Begin);
                var sha = SHA1.Create();
                sentryHash = sha.ComputeHash(fs);
            }

            // inform the steam servers that we're accepting this sentry file
            steamUser.SendMachineAuthResponse(new SteamUser.MachineAuthDetails
            {
                JobID = callback.JobID,

                FileName = callback.FileName,

                BytesWritten = callback.BytesToWrite,
                FileSize = fileSize,
                Offset = callback.Offset,

                Result = EResult.OK,
                LastError = 0,

                OneTimePassword = callback.OneTimePassword,

                SentryFileHash = sentryHash,
            });

            WriteLine("Done!");
        }

        public void Disconnect()
        {
            isRunning = false;
            steamClient.Disconnect();
        }

        private void WriteLine(object msg, bool onMessage = true)
        {
            Console.WriteLine(msg);
            if (onMessage)
            {
                OnMessage?.Invoke(this, msg.ToString());
            }
        }
    }

}
