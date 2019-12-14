using System;

namespace FenixAlliance.Models.DTOs.Components.Commons
{
    public class Currency
    {
        public string ID { get; set; }
        public string ISO { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string CountryID { get; set; }
        public double ExchangeRate { get; set; }
        public DateTime ExchangeRateTimestamp { get; set; }

    }
}
