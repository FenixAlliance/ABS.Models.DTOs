using FenixAlliance.ABM.Models.DTOs.Components.Services;
using FenixAlliance.ABM.Models.DTOs.Components.Store.Products;
using FenixAlliance.ABM.Models.DTOs.Components.Subscriptions;
using System.Collections.Generic;

namespace FenixAlliance.ABM.Models.DTOs.Components.Store.WishLists
{
    public class WishList
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
