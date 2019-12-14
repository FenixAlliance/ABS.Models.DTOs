﻿namespace FenixAlliance.Models.DTOs.Requests
{
    public class ShippingEstimateRequest
    {
        public string ID { get; set; }
        public string ProductID { get; set; }
        public string DestinationCountryID { get; set; }
        public string DestinationPostalCode { get; set; }
    }
}
