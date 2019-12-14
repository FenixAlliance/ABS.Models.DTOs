using System;
using System.Collections.Generic;
using System.Text;

namespace FenixAlliance.Models.DTOs.Components.Shipping
{
    public class ShippingEstimate
    {
        public string ProductCartRecordID { get; set; }
        public string ShippingPolicyID { get; set; }

        public string ID { get; set; }

        public string DestinationCountryISO3 { get; set; }
        public string DestinationCountryISO2 { get; set; }

        public double ShippingEstimateInUSD { get; set; }

        public string DestinationPostalCode { get; set; }
        public string DestinationRecordedAddressID { get; set; }
    }
}
