using FenixAlliance.ABM.Models.DTOs.Components.Global.Countries;
using System;

namespace FenixAlliance.ABM.Models.DTOs.Components.Global.Currencies
{
    public class Currency
    {
        public string ID { get; set; }
        public string ISO { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public Country Country { get; set; }
        public double ExchangeRate { get; set; }
        public DateTime ExchangeRateTimestamp { get; set; }
    }
}
