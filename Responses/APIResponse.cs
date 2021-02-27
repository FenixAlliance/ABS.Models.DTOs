using FenixAlliance.ABM.Models.DTOs.Components.Holders;
using FenixAlliance.ABM.Models.DTOs.Components.Tenants;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace FenixAlliance.ABM.Models.DTOs.Responses
{

    public class ClientApplication
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string TenantID { get; set; }
        public string TenantName { get; set; }
        public string TenantAvatar { get; set; }
        public string PrivacyPolicy { get; set; }
        public string TermsAndConditions { get; set; }
        public List<string> GrantedPermissions { get; set; }
    }

    public class Error
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public string Help { get; set; }
    }

    public class Actor
    {
        public string ID { get; set; }
        public string Type { get; set; }
        public string CartID { get; set; }
        public string ActingAs { get; set; }
        public string SocialProfileID { get; set; }
    }


    public class ResponseStatus
    {
        public bool Success { get; set; } = true;
        public Error Error { get; set; }
        public string CorrelationID { get; set; }
        public DateTime UTCTimestamp { get; set; } = DateTime.UtcNow;
    }


    public class ResponsePagination
    {
        public string SelfPageToken { get; set; }
        public string NextPageToken { get; set; }
        public string PrevPageToken { get; set; }
        public string OrderedBy { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
    }

    /// Present in all responses
    public partial class APIResponse
    {

        public Holder Holder { get; set; } = new Holder();
        public Tenant Tenant { get; set; }
        public Actor Actor { get; set; }
        public ResponseStatus Status { get; set; }
        public ClientApplication Application { get; set; }
        public ResponsePagination Pagination { get; set; }

    }

    public partial class APIResponse
    {
        public static APIResponse FromJson(string json) => JsonConvert.DeserializeObject<APIResponse>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this APIResponse self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
