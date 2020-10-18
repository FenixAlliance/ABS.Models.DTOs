using System.Collections.Generic;

namespace FenixAlliance.Models.DTOs.Components.Commons
{
    public class ProductCategory
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string ParentID { get; set; }
        public string ImageURL { get; set; }
        public List<ProductCategory> Child { get; set; }
        public bool IsPrimary { get; set; }
    }
}
