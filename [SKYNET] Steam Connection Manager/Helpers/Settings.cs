
namespace SKYNET.Helpers
{
    public class Settings
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static bool RememberMe { get; set; }


        private static RegistrySettings Registry;

        static Settings()
        {
            Registry = new RegistrySettings(@"SOFTWARE\SKYNET\[SKYNET] Steam Connection Client\");
        }

        public static void Load()
        {
            Username = Registry.Get<string>("Username", "");
            Password = Registry.Get<string>("Password", "");
            RememberMe = Registry.Get<bool>("RememberMe", false);
        }

        public static void Save()
        {
            Registry.Set("Username", Username);
            Registry.Set("Password", Password);
            Registry.Set("RememberMe", RememberMe);
        }
    }
}

