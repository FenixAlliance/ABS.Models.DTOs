using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Globalization;

namespace FenixAlliance.ABM.Models.DTOs.Components.Contacts
{
    public partial class Contact
    {
        public string ID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public string City { get; set; }
        public string Avatar { get; set; }
        public string Cover { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string CartID { get; set; }
        public string OwnerID { get; set; }
        public string TenantID { get; set; }
        public string WalletID { get; set; }
        public string CountryID { get; set; }
        public string LanguageID { get; set; }
        public string CurrencyID { get; set; }
        public string TimezoneID { get; set; }
        public string TerritoryID { get; set; }
        public string EnrollmentID { get; set; }
        public double WalletBalance { get; set; }
        public string OwnerContactID { get; set; }
        public string ActivityFeedID { get; set; }
        public string ParentContactID { get; set; }
        public string SocialProfileID { get; set; }
        public string IdP_AccessToken { get; set; }
        public string IdentityProvider { get; set; }
        public string ActiveDirectoryID { get; set; }
        public Dictionary<string, string> CustomProperties { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> ContactProfiles { get; set; } = new Dictionary<string, string>();
    }

    public partial class Contact
    {
        public static Contact FromJson(string json) => JsonConvert.DeserializeObject<Contact>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Contact self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
