using System;
using System.Collections.Generic;
using System.Text;

namespace FenixAlliance.Models.DTOs.Components.Store.Carts
{
    public class ProductCartRecord
    {
        public string ProductID { get; set; }
        public string Quantity { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
