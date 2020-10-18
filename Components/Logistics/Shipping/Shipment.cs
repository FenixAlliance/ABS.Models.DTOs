using System;

namespace FenixAlliance.Models.DTOs.Components.Logistics.Shipping
{
    public class Shipment
    {
        public string ID { get; set; }
        public string TrackingCode { get; set; }
        public bool IsInternational { get; set; }

        public DateTime ShippngTimestamp { get; set; }
        public DateTime DeliveryTimestamp { get; set; }
        public DateTime ExpectedShippingDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }


    }
}
