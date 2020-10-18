using System;
using System.Collections.Generic;
using FenixAlliance.Models.DTOs.Components.Shipping;

namespace FenixAlliance.Models.DTOs.Responses.Store
{
    public class ShippingEstimatesResponse
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public List<ShipmentEstimate> ShippingEstimates { get; set; }
    }


}
