using System;
using System.Collections.Generic;
using System.Text;

namespace FenixAlliance.Models.DTOs.Requests
{
    public class ProductSARUsageRequest
    {
        public string CartID { get; set; }
        public string EventType { get; set; }
        public string CustomWeight { get; set; }
        public string ProductID { get; set; }
    }
}
