using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace FenixAlliance.ABM.Models.DTOs.Components.Holders
{
    /// <summary>

    public partial class Holder
    {
        /// <summary>
        /// Holder's Alliance ID
        /// </summary>
        public string ID { get; set; }
        public string PublicName { get; set; }
        public string IdProvider { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public string JobTitle { get; set; }
        public string CoverURL { get; set; }
        public string AvatarURL { get; set; }
        public string GitHubURL { get; set; }
        public string WebsiteURL { get; set; }
        public string TwitterURL { get; set; }
        public string FacebookURL { get; set; }
        public string YouTubeURL { get; set; }
        public string LinkedInURL { get; set; }
        public string InstagramURL { get; set; }

        public int FollowsCount { get; set; }
        public int FollowersCount { get; set; }
        public int EnrollmentsCount { get; set; }
        public string SocialProfileID { get; set; }
        public string CurrentEnrollmentID { get; set; }
        public string CurrentTenantID { get; set; }

        public string CartID { get; set; }
        public string WalletID { get; set; }
        public string CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryFlag { get; set; }
        public string TimezoneID { get; set; }
        public string CurrencyID { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyISO { get; set; }
        public string CurrencyFlag { get; set; }
        public double CurrencyExchange { get; set; }
    }


    public partial class Holder
    {
        public static Holder FromJson(string json) => JsonConvert.DeserializeObject<Holder>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Holder self) => JsonConvert.SerializeObject(self, Converter.Settings);
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