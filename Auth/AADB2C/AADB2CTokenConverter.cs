using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace FenixAlliance.ABM.Models.DTOs.Auth.AADB2C
{
    internal static class AADB2CTokenConverter
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