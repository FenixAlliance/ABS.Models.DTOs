using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FenixAlliance.Models.DTOs
{

    public partial class University
    {
        [JsonProperty("web_pages")]
        public List<string> WebPages { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alpha_two_code")]
        public string AlphaTwoCode { get; set; }

        [JsonProperty("state-province")]
        public string StateProvince { get; set; }

        [JsonProperty("domains")]
        public List<string> Domains { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public partial class University
    {
        public static List<University> FromJson(string json) => JsonConvert.DeserializeObject<List<University>>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<University> self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
