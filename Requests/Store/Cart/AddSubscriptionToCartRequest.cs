using System;
using System.Collections.Generic;
using System.Text;

namespace FenixAlliance.Models.DTOs.Requests
{
    public class AddSubscriptionToCartRequest
    {
        public string CartID { get; set; }
        public string SubscriptionID { get; set; }

    }
}
