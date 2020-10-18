using System;

namespace FenixAlliance.Models.DTOs.Components.Store.Carts
{
    public class ProductCartRecord
    {
        public string ID { get; set; }
        public string CartID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
