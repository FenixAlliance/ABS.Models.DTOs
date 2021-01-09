namespace FenixAlliance.ABM.Models.DTOs.Components.Logistics.Shipping
{
    public class ShipmentEstimate
    {

        public string ID { get; set; }
        public string ProductCartRecordID { get; set; }
        public string ShippingPolicyID { get; set; }

        public string DestinationCountryISO3 { get; set; }
        public string DestinationCountryISO2 { get; set; }

        public double ShippingEstimateInUSD { get; set; }

        public string DestinationPostalCode { get; set; }
        public string DestinationRecordedAddressID { get; set; }
    }
}
