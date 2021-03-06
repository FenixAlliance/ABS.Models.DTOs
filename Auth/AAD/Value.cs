using Newtonsoft.Json;
using System;

namespace FenixAlliance.ABM.Models.DTOs.Auth.AAD
{
    public class Value
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}