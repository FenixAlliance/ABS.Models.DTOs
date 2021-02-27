using FenixAlliance.ABM.Models.DTOs.Responses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Globalization;

namespace FenixAlliance.ABM.Models.DTOs.Components.Social
{

    public class APISocialActivityResponse : APIResponse
    {
        public List<FollowRecord> FollowRecords { get; set; }
    }

    public partial class FollowRecord
    {
        // Follow Activity ID
        public string ID { get; set; }
        // Follow Record Type
        public string Type { get; set; }
        // FollowBack ID
        public string FollowerID { get; set; }
        // Followed Social Profile ID
        public string FollowedID { get; set; }
        // Are notifications enabled?
        public bool Alerts { get; set; }

    }

    public partial class FollowRecord
    {
        public static FollowRecord FromJson(string json) => JsonConvert.DeserializeObject<FollowRecord>(json, Converter.Settings);
    }

    public partial class FollowRecord
    {
        public static List<FollowRecord> FromJsonList(string json) => JsonConvert.DeserializeObject<List<FollowRecord>>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this FollowRecord self) => JsonConvert.SerializeObject((object)self, (JsonSerializerSettings)Converter.Settings);
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
