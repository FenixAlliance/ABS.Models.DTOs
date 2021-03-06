using FenixAlliance.ABM.Models.DTOs.Auth.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FenixAlliance.ABM.Models.DTOs.Auth.AADB2C
{
    public partial class B2CDecodedToken
    {
        [JsonProperty("iss")]
        public string Iss { get; set; }

        [JsonProperty("exp")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Exp { get; set; }

        [JsonProperty("nbf")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Nbf { get; set; }

        [JsonProperty("aud")]
        public string Aud { get; set; }

        [JsonProperty("idp_access_token")]
        public string IdpAccessToken { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("idp")]
        public string Idp { get; set; }

        [JsonProperty("oid")]
        public string Oid { get; set; }

        [JsonProperty("sub")]
        public string Sub { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("emails")]
        public List<string> Emails { get; set; }

        [JsonProperty("tfp")]
        public string Tfp { get; set; }

        [JsonProperty("scp")]
        public string Scp { get; set; }

        [JsonProperty("azp")]
        public string Azp { get; set; }

        [JsonProperty("ver")]
        public string Ver { get; set; }

        [JsonProperty("iat")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Iat { get; set; }
    }

    public partial class B2CDecodedToken
    {
        public static B2CDecodedToken FromJson(string json) => JsonConvert.DeserializeObject<B2CDecodedToken>(json, AADB2CTokenConverter.Settings);
    }
}