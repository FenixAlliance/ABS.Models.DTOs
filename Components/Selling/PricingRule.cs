using System.Collections.Generic;

namespace FenixAlliance.ABM.Models.DTOs.Components.Selling
{
    public class PricingRule
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CurrencyID { get; set; }

        public bool IsFree { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDefault { get; set; }
        public double MinQuantity { get; set; }
        public double MaxQuantity { get; set; }
        public double AddedValue { get; set; }
        public double AddedPercentage { get; set; }
        public List<string> Countries { get; set; }
    }
}
