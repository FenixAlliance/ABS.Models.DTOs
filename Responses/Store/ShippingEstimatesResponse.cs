using System;
using System.Collections.Generic;
using FenixAlliance.ABM.Models.DTOs.Components.Logistics.Shipping;

namespace FenixAlliance.ABM.Models.DTOs.Responses.Store
{
    public class ShippingEstimatesResponse
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public List<ShipmentEstimate> ShippingEstimates { get; set; }
    }


}
