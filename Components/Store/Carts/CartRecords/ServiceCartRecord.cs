using System;

namespace FenixAlliance.Models.DTOs.Components.Store.Carts
{
    public class ServiceCartRecord
    {
        public string ID { get; set; }
        public string CartID { get; set; }
        public string ServiceID { get; set; }
        public int Quantity { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
