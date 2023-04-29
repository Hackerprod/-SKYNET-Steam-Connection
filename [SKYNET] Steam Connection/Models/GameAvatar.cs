using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace SKYNET.Models
{


    public partial class GameAvatar
    {
        [JsonProperty("baseAvaLink")]
        public Uri BaseAvaLink { get; set; }

        [JsonProperty("rgRecentGames")]
        public object[] RgRecentGames { get; set; }

        [JsonProperty("rgOwnedGames")]
        public object[] RgOwnedGames { get; set; }

        [JsonProperty("rgOtherGames")]
        public RgOtherGame[] RgOtherGames { get; set; }
    }

    public partial class RgOtherGame
    {
        [JsonProperty("appid")]
        public long Appid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar_count")]
        public long AvatarCount { get; set; }

        [JsonProperty("avatars")]
        public Avatar[] Avatars { get; set; }
    }

    public partial class Avatar
    {
        [JsonProperty("ordinal")]
        public long Ordinal { get; set; }

        [JsonProperty("avatar_hash")]
        public string AvatarHash { get; set; }
    }

    public partial class GameAvatar
    {
        public static GameAvatar FromJson(string json) => JsonConvert.DeserializeObject<GameAvatar>(json);
    }
}
