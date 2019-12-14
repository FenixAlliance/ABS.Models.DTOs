using System;
using System.Collections.Generic;
using System.Text;

namespace FenixAlliance.Models.DTOs.Components.Store.Carts
{
    public class Cart
    {
        public string ID { get; set; }
        public string IP { get; set; }
        public string Type { get; set; }
        public double Balance { get; set; }
        public string CountryID { get; set; }
        public string CurrencyID { get; set; }

        public List<string> Wishlists { get; set; }

        public List<ProductCartRecord> Products { get; set; }
        public List<ServiceCartRecord> Services { get; set; }
        public List<SubscriptionCartRecord> Subscriptions { get; set; }


        public List<string> ToCompareProducts { get; set; }
        public List<string> ToCompareServices { get; set; }
        public List<string> ToCompareSubscriptions { get; set; }


        public List<string> RecentlyViewedProducts { get; set; }
        public List<string> RecentlyViewedServices { get; set; }
        public List<string> RecentlyViewedSubscriptions { get; set; }
    }
}
