using System;
using System.Collections.Generic;
using System.Text;

namespace FenixAlliance.Models.DTOs.Requests.Store.Wishlists
{
    public class SubscriptionToWishlistRequest
    {
        public string WishlistID { get; set; }
        public string SubscriptionID { get; set; }
    }
}
