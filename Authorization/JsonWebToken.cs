using Newtonsoft.Json;

namespace FenixAlliance.Models.DTOs.Authorization
{
    public partial class JsonWebToken
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public long ExpiresIn { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }



}
