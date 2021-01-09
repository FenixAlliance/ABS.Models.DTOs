using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FenixAlliance.ABM.Models.DTOs.Components.Global.Currencies
{
    public class CurrencyExchangeRates
    {
        [JsonProperty("disclaimer")]
        public string Disclaimer { get; set; }

        [JsonProperty("license")]
        public Uri License { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("rates")]
        public Dictionary<string, double> Rates { get; set; }
    }
}
