using Newtonsoft.Json;
using System.Collections.Generic;

namespace FenixAlliance.ABM.Models.DTOs.Auth.OAuth2
{
    public class KeysLookupResponse
    {
        [JsonProperty("keys")]
        public List<Key> Keys { get; set; }
    }
}