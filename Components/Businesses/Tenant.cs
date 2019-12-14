using System;
using System.Collections.Generic;
using System.Text;

namespace FenixAlliance.Models.DTOs.Components.Businesses
{
    public class Tenant
    {
        // Alliance ID for Business
        public string ID { get; set; }
        public string TaxID { get; set; }
        public string WalletID { get; set; }
        public string Industry { get; set; }
        public string Segment { get; set; }
        public string SocialProfileID { get; set; }

        // Business User Data
        public string Name { get; set; }
        public string DUNS { get; set; }
        public string LegalName { get; set; }
        public string CoverURL { get; set; }
        public string AvatarURL { get; set; }
        public string CountryID { get; set; }
        public string CountryName { get; set; }
        public string Country_Flg_URL { get; set; }
        // Business Cart ID
        public string CartID { get; set; }
        public string CurrencyID { get; set; }
        public string CurrencyISO { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyCountryID { get; set; }
        public string CurrencyCountryName { get; set; }
        public string CurrencyCountryFlagURL { get; set; }
        public double CurrencyExchangeRate { get; set; }
        public DateTime CurrencyExchangeRateTimestamp { get; set; }

        // Social Activity
        public int FollowsCount { get; set; }
        public int FollowersCount { get; set; }
        // Business to User Relation
        public string EnrollmentID { get; set; } = string.Empty;
        public string C2BFollowID { get; set; } = string.Empty;
        public string B2CFollowID { get; set; } = string.Empty;

        // Business Specifics
        public bool IsA4EduPartner { get; set; }
        public bool IsBuinessPartner { get; set; }
        public bool IsA4StartupsPartner { get; set; }

        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Slogan { get; set; } = string.Empty;
        public string About { get; set; } = string.Empty;
        public string WebURL { get; set; } = string.Empty;
        public string FacebookURL { get; set; } = string.Empty;
        public string TwitterURL { get; set; } = string.Empty;
        public string GitHubURL { get; set; } = string.Empty;
        public string LinkedInURL { get; set; } = string.Empty;
        public string InstagramURL { get; set; } = string.Empty;
        public string YouTubeURL { get; set; } = string.Empty;
        public string WhatsAppNumber { get; set; } = string.Empty;
    }

}
