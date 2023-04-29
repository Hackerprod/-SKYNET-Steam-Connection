using Newtonsoft.Json;
using SKYNET.Models;
using SteamAuth;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SKYNET
{
    public class ProfileCustomization
    {
        public static List<string> countries = JsonConvert.DeserializeObject<List<string>>("[\"AF\",\"AX\",\"AL\",\"DZ\",\"AS\",\"AD\",\"AO\",\"AI\",\"AQ\",\"AG\",\"AR\",\"AM\",\"AW\",\"AU\",\"AT\",\"AZ\",\"BS\",\"BH\",\"BD\",\"BB\",\"BY\",\"BE\",\"BZ\",\"BJ\",\"BM\",\"BT\",\"BO\",\"BQ\",\"BA\",\"BW\",\"BV\",\"BR\",\"IO\",\"VG\",\"BN\",\"BG\",\"BF\",\"BI\",\"KH\",\"CM\",\"CV\",\"KY\",\"CF\",\"TD\",\"CL\",\"CN\",\"CX\",\"CC\",\"CO\",\"KM\",\"CG\",\"CD\",\"CK\",\"CR\",\"CI\",\"HR\",\"CU\",\"CW\",\"CY\",\"CZ\",\"DK\",\"DJ\",\"DM\",\"DO\",\"EC\",\"EG\",\"SV\",\"GQ\",\"ER\",\"EE\",\"ET\",\"FK\",\"FO\",\"FJ\",\"FI\",\"FR\",\"GF\",\"PF\",\"TF\",\"GA\",\"GM\",\"GE\",\"DE\",\"GH\",\"GI\",\"GR\",\"GL\",\"GD\",\"GP\",\"GU\",\"GT\",\"GG\",\"GN\",\"GW\",\"GY\",\"HT\",\"HM\",\"HN\",\"HK\",\"HU\",\"IS\",\"IN\",\"ID\",\"IQ\",\"IE\",\"IR\",\"IM\",\"IL\",\"IT\",\"JM\",\"JP\",\"JE\",\"JO\",\"KZ\",\"KE\",\"KI\",\"KP\",\"KR\",\"XK\",\"KW\",\"KG\",\"LA\",\"LV\",\"LB\",\"LS\",\"LR\",\"LY\",\"LI\",\"LT\",\"LU\",\"MO\",\"MK\",\"MG\",\"MW\",\"MY\",\"MV\",\"ML\",\"MT\",\"MH\",\"MQ\",\"MR\",\"MU\",\"YT\",\"MX\",\"FM\",\"MD\",\"MC\",\"MN\",\"MS\",\"ME\",\"MA\",\"MZ\",\"MM\",\"NA\",\"NR\",\"NP\",\"NL\",\"NC\",\"NZ\",\"NI\",\"NE\",\"NG\",\"NU\",\"NF\",\"MP\",\"NO\",\"OM\",\"PK\",\"PW\",\"PS\",\"PA\",\"PG\",\"PY\",\"PE\",\"PH\",\"PN\",\"PL\",\"PT\",\"PR\",\"QA\",\"RE\",\"RO\",\"RU\",\"RW\",\"BL\",\"LC\",\"MF\",\"WS\",\"SM\",\"ST\",\"SA\",\"SN\",\"RS\",\"SC\",\"SL\",\"SG\",\"SX\",\"SK\",\"SI\",\"SB\",\"SO\",\"ZA\",\"GS\",\"SS\",\"ES\",\"LK\",\"SH\",\"KN\",\"PM\",\"VC\",\"SD\",\"SR\",\"SJ\",\"SZ\",\"SE\",\"CH\",\"SY\",\"TW\",\"TJ\",\"TZ\",\"TH\",\"TL\",\"TG\",\"TK\",\"TO\",\"TT\",\"TN\",\"TR\",\"TM\",\"TC\",\"TV\",\"UG\",\"UA\",\"AE\",\"GB\",\"UM\",\"VI\",\"UY\",\"UZ\",\"VU\",\"VA\",\"VE\",\"VN\",\"WF\",\"EH\",\"YE\",\"ZM\",\"ZW\"]");
        public static Result FakePerson;
        public static UserLogin UserLogin;
        public static string Username;
        public static string AppID;

        public static void Customize(string username, string pass, uint appID)
        {
            CreateFakePerson();

            Username = username;
            AppID = appID.ToString();
            UserLogin = new UserLogin(username, pass);

            Console.WriteLine();

            LoginResult response = LoginResult.BadCredentials;
            while ((response = UserLogin.DoLogin()) != LoginResult.LoginOkay)
            {
                switch (response)
                {

                    case LoginResult.NeedCaptcha:
                        {
                            System.Diagnostics.Process.Start(APIEndpoints.COMMUNITY_BASE + "/public/captcha.php?gid=" + UserLogin.CaptchaGID); //Open a web browser to the captcha image
                            Console.Write("Please enter captcha text for steamweb: ");
                            string captchaText = Console.ReadLine();
                            UserLogin.CaptchaText = captchaText;
                        }
                        break;
                    case LoginResult.NeedEmail:
                        {
                            Console.Write("Please enter email text for steamweb: ");
                            string emailText = Console.ReadLine();
                            UserLogin.EmailCode = emailText;
                        }
                        break;
                    default:
                        //Console.WriteLine($"Login Response: {response} on Account: {username}");
                        Thread.Sleep(TimeSpan.FromHours(1));
                        break;
                }
            }

            Console.WriteLine("Modifying steam profile");

            EnableProfileDefault(UserLogin.Session, username);

            SetCustomAvatar(UserLogin.Session);

            SetGameAndInventoryPublic(UserLogin.Session);

            SubscribeAppID();

            Console.WriteLine("Done.");
        }

        private static void CreateFakePerson()
        {
            var request = new RequestBuilder("https://randomuser.me/api/").GET()
                       .Execute();

            if (request.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine($"Erro to Request Name...\r\n\r\nStatusCode:{request.StatusCode}", "api.namefake.com");
                return;
            }
            var person = JsonConvert.DeserializeObject<FakePerson>(request.Content);
            FakePerson = person.Results[0];
        }

        private static void SubscribeAppID()
        {
            var edit = new RequestBuilder("https://store.steampowered.com/explore/followgame").POST()
                .AddPOSTParam("sessionid", UserLogin.Session.SessionID)
                .AddPOSTParam("appid", AppID)
                .AddCookies(UserLogin.Session)
                .Execute();
        }

        public static void EnableProfileDefault(SteamAuth.SessionData SessionData, string username)
        {
            var Enable_Profile = new RequestBuilder("https://steamcommunity.com/profiles/" + SessionData.SteamID + "/edit?welcomed=1")
                    .GET()
                    .AddCookies(SessionData)
                    .Execute();

            string page_edit = "https://steamcommunity.com/profiles/" + SessionData.SteamID + "/edit";

            var edit = new RequestBuilder("https://steamcommunity.com/profiles/" + SessionData.SteamID + "/edit").POST()
                 .AddHeader(HttpRequestHeader.Referer, page_edit)
                .AddPOSTParam("sessionID", SessionData.SessionID)
                .AddPOSTParam("type", "profileSave")
                .AddPOSTParam("personaName", FakePerson.Name.First)
                .AddPOSTParam("real_name", $"{FakePerson.Name.First} {FakePerson.Name.Last}")
                .AddPOSTParam("country", "US") //countries[new Random().Next(0, countries.Count)])
                .AddPOSTParam("customURL", username)
                .AddPOSTParam_int("favorite_badge_badgeid", 1)
                .AddCookies(SessionData)
                .Execute();
        }

        public static void SetCustomAvatar(SteamAuth.SessionData SessionData)
        {
            try
            {
                string Random_IMG_URL = FakePerson.Picture.Large.ToString();

                Image img = DownloadImage(Random_IMG_URL);

                Image DownloadImage(string fromUrl)
                {
                    using (System.Net.WebClient webClient = new System.Net.WebClient())
                    {
                        using (Stream stream = webClient.OpenRead(fromUrl))
                        {
                            return Image.FromStream(stream);
                        }
                    }
                }

                Image imagem_pronta = ResizeImage(img, 184, 184);

                byte[] imagem_byte = converterDemo(imagem_pronta);

                string ContentType = "image/jpg";

                var baseURL = "https://steamcommunity.com/actions/FileUploader?type=player_avatar_image&sId=" + SessionData.SteamID + "&bgColor=262627&fgColor=ffffff";

                var response = new RequestBuilder(baseURL).POST()
                    .AddHeader(HttpRequestHeader.Referer, "https://steamcommunity.com/profiles/" + SessionData.SteamID + "/edit")
                    .AddPOSTParam_int("MAX_FILE_SIZE", 1048576)
                    .AddPOSTParam("type", "player_avatar_image")
                    .AddPOSTParam("sId", SessionData.SteamID.ToString())
                    .AddPOSTParam("sessionid", SessionData.SessionID)
                    .AddPOSTParam_int("doSub", 1)
                    .AddFile_Bytes("avatar", imagem_byte, ContentType)
                    .AddCookies(SessionData)
                    .Execute();

            }
            catch (IndexOutOfRangeException)
            {
                ChangeAvatar();
            }
        }

        private async static void ChangeAvatar()
        {
            var avatarID = await GetRandomAvatarID();
            var edit = new RequestBuilder($"https://steamcommunity.com/ogg/{avatarID}/selectAvatar").POST()
                .AddHeader(HttpRequestHeader.Referer, $"https://steamcommunity.com/id/{Username}/edit/avatar")
                            .AddPOSTParam("sessionid", UserLogin.Session.SessionID)
                            .AddPOSTParam("json", "1")
                            .AddPOSTParam("selectedAvatar", "0")
                            .AddCookies(UserLogin.Session)
                            .Execute();
        }

        private async static Task<string> GetRandomAvatarID()
        {
            try
            {
                var m_HttpClient = new HttpClient();
                var request = await m_HttpClient.GetAsync("https://steamcommunity.com/actions/GameAvatars/?json=1&l=english");
                var result = await request.Content.ReadAsStringAsync();

                var gameAvatars = GameAvatar.FromJson(result);
                var index = new Random().Next(0, gameAvatars.RgOtherGames.Count() - 1);
                return gameAvatars.RgOtherGames[index].Appid.ToString();
            }
            catch (Exception)
            {
                return "899190";
            }
        }

        public static void SetGameAndInventoryPublic(SteamAuth.SessionData SessionData)
        {
            string page_edit = "https://steamcommunity.com/profiles/" + SessionData.SteamID + "/edit";

            var edit = new RequestBuilder("https://steamcommunity.com/profiles/" + SessionData.SteamID + "/ajaxsetprivacy").POST()
                 .AddHeader(HttpRequestHeader.Referer, page_edit)
                .AddPOSTParam("sessionid", SessionData.SessionID)
                .AddPOSTParam("Privacy", "{\"PrivacyProfile\":3,\"PrivacyInventory\":3,\"PrivacyInventoryGifts\":3,\"PrivacyOwnedGames\":3,\"PrivacyPlaytime\":3,\"PrivacyFriendsList\":3}")
                .AddPOSTParam("eCommentPermission", "1")
                .AddCookies(SessionData)
                .Execute();
        }

        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

    }
}
