using System;
using System.Collections.Generic;
using System.Text;

namespace FenixAlliance.Models.DTOs.Requests.Store.Wishlists
{
    public class ProductToWishlistRequest
    {
        public string WishlistID { get; set; }
        public string ProductID { get; set; }
    }
}
