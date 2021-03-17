using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FenixAlliance.ABM.Models.DTOs.Components.Global.Currencies
{
    public class ForexRates
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("rates")]
        public Dictionary<string, double> Rates { get; set; } = new Dictionary<string, double>();
    }
}
