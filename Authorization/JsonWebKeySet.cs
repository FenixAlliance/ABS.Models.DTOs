using System.Collections.Generic;
using Newtonsoft.Json;

namespace FenixAlliance.ABM.Models.DTOs.Authorization
{
    public partial class JsonWebKeySet
    {
        [JsonProperty("keys")]
        public List<JsonWebKey> Keys { get; set; }
    }

    public partial class JsonWebKey
    {
        /// <summary>
        /// Key ID
        /// </summary>
        [JsonProperty("kid")]
        public string Kid { get; set; }
        /// <summary>
        /// Not Before
        /// </summary>
        [JsonProperty("nbf")]
        public long Nbf { get; set; }
        /// <summary>
        /// The use for this key
        /// </summary>
        [JsonProperty("use")]
        public string Use { get; set; } = "sig";
        /// <summary>
        /// Key Type
        /// </summary>
        [JsonProperty("kty")]
        public string Kty { get; set; } = "RSA";
        /// <summary>
        /// Publc Key Exponent
        /// </summary>
        [JsonProperty("e")]
        public string E { get; set; }
        /// <summary>
        /// Public Key Modulus
        /// </summary>
        [JsonProperty("n")]
        public string N { get; set; }
    }


}
