using System.Collections.Generic;
using System.Globalization;
using FenixAlliance.Models.DTOs.Components.Store;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FenixAlliance.Models.DTOs.Responses.Store
{
    public partial class APIProductsResponse : APIResponse
    {
        public List<APIProduct> Data { get; set; }
        public List<MinimalAPIProduct> MinimalData { get; set; }

        public string OrderBy { get; set; }
        public int PageSize { get; set; } = 0;
        public int PageIndex { get; set; } = 0;

        // Items in response
        public bool CanLoadMore { get; set; }
        public int ItemsLeft { get; set; } = 0;
        public int ItemsSetCount { get; set; } = 0;
        public int ItemsOffSetCount { get; set; } = 0;
        public int ItemsTotalCount { get; set; } = 0;

        public string NextURL { get; set; }
        public string PrevURL { get; set; }

    }

    public partial class APIProductsResponse
    {
        public static APIProductsResponse FromJson(string json) => JsonConvert.DeserializeObject<APIProductsResponse>(json, Converter.Settings);
    }

    public static class SerializeAPIProductsResponse
    {
        public static string ToJson(this APIProductsResponse self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            DateParseHandling = DateParseHandling.None,
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
