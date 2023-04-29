using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SKYNET.Helpers
{



    public partial class RecentlyPlayedGames
    {
        [JsonProperty("response")]
        public RecentlyPlayedGames Response { get; set; }
    }

    public partial class RecentlyPlayedGames
    {
        [JsonProperty("total_count")]
        public long TotalCount { get; set; }

        [JsonProperty("games")]
        public Game[] Games { get; set; }
    }

    public partial class Game
    {
        [JsonProperty("appid")]
        public long Appid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("playtime_2weeks")]
        public long Playtime2Weeks { get; set; }

        [JsonProperty("playtime_forever")]
        public long PlaytimeForever { get; set; }

        [JsonProperty("img_icon_url")]
        public string ImgIconUrl { get; set; }

        [JsonProperty("playtime_windows_forever")]
        public long PlaytimeWindowsForever { get; set; }

        [JsonProperty("playtime_mac_forever")]
        public long PlaytimeMacForever { get; set; }

        [JsonProperty("playtime_linux_forever")]
        public long PlaytimeLinuxForever { get; set; }
    }

    public partial class RecentlyPlayedGames
    {
        public static RecentlyPlayedGames FromJson(string json) => JsonConvert.DeserializeObject<RecentlyPlayedGames>(json);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
