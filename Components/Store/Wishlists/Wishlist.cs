using System.Collections.Generic;

namespace FenixAlliance.Models.DTOs.Components.Commons
{
    public class Wishlist
    {
        public string ID { get; set; }
        public string CartID { get; set; }
        public double Balance { get; set; }
        public string CountryID { get; set; }
        public string CurrencyID { get; set; }

        public List<string> AddedProducts { get; set; }
        public List<string> AddedServices { get; set; }
        public List<string> AddedSubscriptions { get; set; }

    }
}
