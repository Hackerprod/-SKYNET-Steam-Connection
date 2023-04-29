using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamKit2;
using System.Timers;
using System.IO;
using System.Security.Cryptography;
using SteamKit2.Internal;
using System.Net;
using SKYNET.Helpers;

namespace SKYNET.GUI.Controls
{
    public partial class AccountControl : UserControl
    {
        public event EventHandler<AccountControl> OnRemoveAccount;
        public event EventHandler<AccountControl> OnSteamGuardRequest;

        public SteamClient steamClient;
        public CallbackManager callbackManager;
        public SteamUser steamUser;
        public SteamFriends steamFriends;
        public uint AppID;
        public string Username;
        public string Password;
        public bool Connected;
        public SteamID SteamID;

        private System.Timers.Timer _timerCallback;
        private System.Timers.Timer _timerHours;
        private bool isRunning;
        private string authCode;
        private string twoFactorAuth;

        public AccountControl(string username, string password, uint appID)
        {
            InitializeComponent();

            SetLabelsVisible(false);

            _timerCallback = new System.Timers.Timer();
            _timerCallback.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds;
            _timerCallback.Elapsed += _timerCallback_Elapsed;
            _timerCallback.AutoReset = true;

            _timerHours = new System.Timers.Timer();
            _timerHours.Interval = TimeSpan.FromHours(1).TotalMilliseconds;
            _timerHours.Elapsed += _timerHours_Elapsed;
            _timerHours.AutoReset = true;

            Username = username;
            Password = password;
            AppID = appID;

            InitializeSteam();
        }

        private async void _timerHours_Elapsed(object sender, ElapsedEventArgs e)
        {
            LB_Time.Text = (await GetHours()).ToString();
        }

        private void InitializeSteam()
        {
            steamClient = new SteamClient();

            callbackManager = new CallbackManager(steamClient);

            steamUser = steamClient.GetHandler<SteamUser>();
            steamFriends = steamClient.GetHandler<SteamFriends>();

            callbackManager.Subscribe<SteamClient.ConnectedCallback>(OnConnected);
            callbackManager.Subscribe<SteamClient.DisconnectedCallback>(OnDisconnected);
            callbackManager.Subscribe<SteamUser.LoggedOnCallback>(OnLoggedOn);
            callbackManager.Subscribe<SteamUser.LoggedOffCallback>(OnLoggedOff);
            callbackManager.Subscribe<SteamUser.UpdateMachineAuthCallback>(OnMachineAuth);
            callbackManager.Subscribe<SteamUser.AccountInfoCallback>(OnAccountInfo);

            isRunning = true;

            _timerCallback.Start();

            WriteLine("Connecting to Steam...");

            // initiate the connection
            steamClient.Connect();
        }


        private void _timerCallback_Elapsed(object sender, ElapsedEventArgs e)
        {
            callbackManager.RunWaitCallbacks(TimeSpan.FromSeconds(1));
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

        async void OnLoggedOn(SteamUser.LoggedOnCallback callback)
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

            Common.InvokeAction(this, new Action(() =>
            {
                LB_AccountName.Text = Username;
                LB_AccountName.ForeColor = Color.White;
                LB_AppID.Text = AppID.ToString();
                PN_Indicator.BackColor = Color.Green;

                SetLabelsVisible(true);
            }));

            SteamID = steamUser.SteamID;

            LB_SteamID.Text = $"{(ulong)SteamID}";

            OpenGame(AppID);

            Connected = true;

            LB_Time.Text = (await GetHours()).ToString();

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

        private async Task<long> GetHours()
        {
            try
            {
                var apiKey = "FA7319FBB058AE5883A7C3543FB01810";
                var URL = $"http://api.steampowered.com/IPlayerService/GetRecentlyPlayedGames/v0001/?key={apiKey}&format=json&steamid={(ulong)SteamID}";
                File.WriteAllText("c:/URL.txt", URL);

                var webrequest = WebRequest.Create(URL);
                var ResponseTask = await webrequest.GetResponseAsync();
                var response = (HttpWebResponse)ResponseTask;
                var reader = new StreamReader(response.GetResponseStream());
                var content = reader.ReadToEnd();

                var recentlyPlayedGames = RecentlyPlayedGames.FromJson(content);

                if (recentlyPlayedGames != null && recentlyPlayedGames.Response != null && recentlyPlayedGames.Response.Games.Any())
                {
                    var game = recentlyPlayedGames.Response.Games.Where(g => g.Appid == AppID).FirstOrDefault();

                    if (game != null)
                    {
                        return game.PlaytimeForever / 60;
                    }
                }
            }
            catch 
            {
            }

            return 0;
        }

        private void WriteLine(object msg, bool onMessage = true)
        {
            Console.WriteLine(msg);
            if (onMessage)
            {
                LB_AccountName.Text = msg.ToString();
            }
        }

























































































        private void BP_Remove_Click(object sender, EventArgs e)
        {
            steamClient.Disconnect();
            OnRemoveAccount?.Invoke(this, this);
        }



        private void SetLabelsVisible(bool visible)
        {
            LB_SteamID.Visible = visible;
            LB_AppID.Visible = visible;
            LB_Time.Visible = visible;
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(43, 45, 50);
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(33, 35, 40);
        }
    }
}
