using SKYNET.Helpers;
using SteamAuth;
using SteamKit2;
using SteamKit2.GC;
using SteamKit2.GC.Dota.Internal;
using SteamKit2.Internal;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace SKYNET
{
    class Program
    {
        private static SteamClient steamClient;
        private static SteamUser steamUser;
        private static SteamFriends steamFriends;
        private static SteamApps steamApps;
        private static SteamUnifiedMessages steamUnified;
        private static SteamUnifiedMessages.UnifiedService<IPlayer> UnifiedPlayerService;
        private static SteamID SteamID;

        private static bool isRunning;
        private static string username;
        private static string password;
        private static uint appID;
        private static string authCode;
        private static string twoFactorAuth;
        private static System.Timers.Timer _timerHours;
        private static string GameName;


        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.Clear();
            Console.Title = "";

            username = "";
            password = "";
            appID = 0;

            _timerHours = new System.Timers.Timer();
            _timerHours.Interval = TimeSpan.FromHours(1).TotalMilliseconds;
            _timerHours.Elapsed += _timerHours_Elapsed;
            _timerHours.AutoReset = true;

            //username = "sadye39";
            //username = "gd2_1";
            //password = "Loops8904*";
            //appID = 570;

            switch (args.Length)
            {
                case 3:
                    username = args[0];
                    password = args[1];
                    uint.TryParse(args[2], out appID);
                    break;
                case 2:
                    username = args[0];
                    password = args[1];
                    break;
            }

            // save our logon details

            // create our steamclient instance
            steamClient = new SteamClient();
            // create the callback manager which will route callbacks to function calls
            var manager = new CallbackManager(steamClient);

            // get the steamuser handler, which is used for logging on after successfully connecting
            steamUser = steamClient.GetHandler<SteamUser>();
            steamFriends = steamClient.GetHandler<SteamFriends>();
            steamApps = steamClient.GetHandler<SteamApps>();

            // register a few callbacks we're interested in
            // these are registered upon creation to a callback manager, which will then route the callbacks
            // to the functions specified
            manager.Subscribe<SteamClient.ConnectedCallback>(OnConnected);
            manager.Subscribe<SteamClient.DisconnectedCallback>(OnDisconnected);


            manager.Subscribe<SteamUser.LoggedOnCallback>(OnLoggedOn);
            manager.Subscribe<SteamUser.LoggedOffCallback>(OnLoggedOff);

            // this callback is triggered when the steam servers wish for the client to store the sentry file
            manager.Subscribe<SteamUser.UpdateMachineAuthCallback>(OnMachineAuth);
            // we use the following callbacks for friends related activities
            manager.Subscribe<SteamUser.AccountInfoCallback>(OnAccountInfo);

            manager.Subscribe<SteamApps.FreeLicenseCallback>(OnFreeLicense);

            steamUnified = steamClient.GetHandler<SteamUnifiedMessages>();
            UnifiedPlayerService = steamUnified.CreateService<IPlayer>();


            isRunning = true;

            Console.WriteLine("Connecting to Steam...");

            // initiate the connection
            steamClient.Connect();

            // create our callback handling loop
            while (isRunning)
            {
                // in order for the callbacks to get routed, they need to be handled by the manager
                manager.RunWaitCallbacks(TimeSpan.FromSeconds(1));
            }

            Console.ReadLine();
        }

        private static void OnFreeLicense(SteamApps.FreeLicenseCallback obj)
        {
            //Console.WriteLine(obj.Result);
        }

        private static async void _timerHours_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            var time = await GetGameTimePlayed(appID);
            Console.WriteLine($"AccountName: {username.ToUpper()}");
            Console.WriteLine($"SteamID:     {(ulong)SteamID}");
            Console.WriteLine($"AppID:       {appID} ({GameName})");
            Console.WriteLine($"Time:        {time} hours");
            Console.Title = $"{username.ToUpper()} {time} hours";
        }

        static void OnConnected(SteamClient.ConnectedCallback callback)
        {
            _UsernameCheck:

            if (string.IsNullOrEmpty(username))
            {
                Console.Write("Please enter your account name: ");
                username = Console.ReadLine();
                goto _UsernameCheck;
            }

            _PasswordCheck:
            if (string.IsNullOrEmpty(password))
            {
                Console.Write("Please enter your password: ");
                password = Console.ReadLine();
                goto _PasswordCheck;
            }

            Console.WriteLine($"Connected to Steam! Logging in '{username}'...");

            byte[] sentryHash = null;
            if (File.Exists("sentry.bin"))
            {
                // if we have a saved sentry file, read and sha-1 hash it
                byte[] sentryFile = File.ReadAllBytes("sentry.bin");
                sentryHash = CryptoHelper.SHAHash(sentryFile);
            }

            steamUser.LogOn(new SteamUser.LogOnDetails
            {
                Username = username,
                Password = password,

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

        static void OnDisconnected(SteamClient.DisconnectedCallback callback)
        {
            // after recieving an AccountLogonDenied, we'll be disconnected from steam
            // so after we read an authcode from the user, we need to reconnect to begin the logon flow again

            Console.WriteLine("Disconnected from Steam, reconnecting in 2 seconds...");

            Thread.Sleep(TimeSpan.FromSeconds(2));

            steamClient.Connect();
        }

        static async void OnLoggedOn(SteamUser.LoggedOnCallback callback)
        {
            bool isSteamGuard = callback.Result == EResult.AccountLogonDenied;
            bool is2FA = callback.Result == EResult.AccountLoginDeniedNeedTwoFactor;

            if (isSteamGuard || is2FA)
            {
                Console.WriteLine("This account is SteamGuard protected!");

                if (is2FA)
                {
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
                if (callback.Result == EResult.InvalidPassword)
                {
                    Console.WriteLine($"Invalid password for account {username}");
                    password = "";
                    steamClient.Disconnect();
                    return;
                }
                else
                {
                    Console.WriteLine("Unable to logon to Steam: {0} / {1}", callback.Result, callback.ExtendedResult);
                    isRunning = false;
                    return;
                }
            }

            Console.WriteLine($"Successfully logged on!!!");
            Console.WriteLine();

            steamFriends.SetPersonaState(EPersonaState.Online);

            SteamID = steamUser.SteamID;

            _AppIDCheck:
            var _appID = "";
            if (appID == 0)
            {
                Console.Write("Please enter AppID for game ");
                _appID = Console.ReadLine();
                if (uint.TryParse(_appID, out appID))
                {
                    OpenGame(appID);
                }
                goto _AppIDCheck;
            }
            else
            {
                OpenGame(appID);
            }

            await steamApps.RequestFreeLicense(appID);

            if (! await IsPublicProfile())
            {
                ProfileCustomization.Customize(username, password, appID);
            }
        }

        static void OnAccountInfo(SteamUser.AccountInfoCallback callback)
        {
            // before being able to interact with friends, you must wait for the account info callback
            // this callback is posted shortly after a successful logon

            // at this point, we can go online on friends, so lets do that
            steamFriends.SetPersonaState(EPersonaState.Online);
        }

        private static void OpenGame(uint appId)
        {
            Console.WriteLine($"Oppening game {appId}");

            // steamkit doesn't expose the "play game" message through any handler, so we'll just send the message manually
            var playGame = new ClientMsgProtobuf<CMsgClientGamesPlayed>(EMsg.ClientGamesPlayed);

            playGame.Body.games_played.Add(new CMsgClientGamesPlayed.GamePlayed
            {
                game_id = new GameID(appId), // or game_id = APPID,
            });

            CPlayer_GetGameBadgeLevels_Request req = new CPlayer_GetGameBadgeLevels_Request
            {
                // we want to know our 440 (TF2) badge level
                appid = 440,
            };

           // var playGame = new ClientMsgProtobuf<CMsgClientGamesPlayed>(EMsg.ClientGamesPlayed);

            // send it off
            // notice here we're sending this message directly using the SteamClient
            steamClient.Send(playGame);

            Console.WriteLine("Done.");

            _timerHours.Start();
            _timerHours_Elapsed(null, null);
        }

        private async static Task<int> GetGameTimePlayed(uint appId)
        {
            var request = new CPlayer_GetOwnedGames_Request
            {
                steamid = SteamID,
                include_appinfo = true,
                include_free_sub = false,
                include_played_free_games = true
            };

            var response = await UnifiedPlayerService.SendMessage(x => x.GetOwnedGames(request)).ToTask().ConfigureAwait(false);
            var result = response.GetDeserializedResponse<CPlayer_GetOwnedGames_Response>();

            foreach (var game in result.games)
            {
                if (game.appid == appId)
                {
                    GameName = game.name;
                    return game.playtime_forever / 60;
                }
            }
            return 0;
        }

        static void OnLoggedOff(SteamUser.LoggedOffCallback callback)
        {
            Console.WriteLine("Logged off of Steam: {0}", callback.Result);
        }

        static void OnMachineAuth(SteamUser.UpdateMachineAuthCallback callback)
        {
            Console.WriteLine("Updating sentryfile...");

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

            Console.WriteLine("Done!");
        }

        internal static async Task<bool> IsPublicProfile()
        {

            var request = new CPlayer_GetPrivacySettings_Request { };

            var response = await UnifiedPlayerService.SendMessage(x => x.GetPrivacySettings(request)).ToTask().ConfigureAwait(false);
            var privacy = response.GetDeserializedResponse<CPlayer_GetPrivacySettings_Response>().privacy_settings;
            return  privacy.privacy_state_friendslist == 3 &&
                    privacy.privacy_state_ownedgames == 3 &&
                    privacy.privacy_state_playtime == 3 &&
                    privacy.privacy_state_inventory == 3 &&
                    privacy.privacy_state_gifts == 3;
        }
    }
}
