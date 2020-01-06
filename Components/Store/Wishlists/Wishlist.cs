using FenixAlliance.Models.DTOs.Components.Services;
using FenixAlliance.Models.DTOs.Components.Store;
using FenixAlliance.Models.DTOs.Components.Subscriptions;
using System.Collections.Generic;

namespace FenixAlliance.Models.DTOs.Components.Commons
{
    public class Wishlist
    {
        public string ID { get; set; }
        public string CartID { get; set; }
        public string Title { get; set; }
        public bool Public { get; set; }

        public List<Product> Products { get; set; }
        public List<Service> Services { get; set; }
        public List<Subscription> Subscriptions { get; set; }

    }
}
