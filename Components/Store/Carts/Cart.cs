﻿using System.Collections.Generic;
using FenixAlliance.Models.DTOs.Components.Commons;
using FenixAlliance.Models.DTOs.Components.Services;
using FenixAlliance.Models.DTOs.Components.Subscriptions;

namespace FenixAlliance.Models.DTOs.Components.Store.Carts
{
    public class Cart
    {
        public string ID { get; set; }
        public string IP { get; set; }
        public string Type { get; set; }
        public double Balance { get; set; }
        public Country Country { get; set; }
        public Currency Currency { get; set; }

        public List<string> Wishlists { get; set; } = new List<string>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Service> Services { get; set; } = new List<Service>();
        public List<Subscription> Subscriptions { get; set; } = new List<Subscription>();


        public List<Product> ToCompareProducts { get; set; } = new List<Product>();
        public List<Service> ToCompareServices { get; set; } = new List<Service>();
        public List<Subscription> ToCompareSubscriptions { get; set; } = new List<Subscription>();


        public List<Product> RecentlyViewedProducts { get; set; } = new List<Product>();
        public List<Service> RecentlyViewedServices { get; set; } = new List<Service>();
        public List<Subscription> RecentlyViewedSubscriptions { get; set; } = new List<Subscription>();
    }
}
