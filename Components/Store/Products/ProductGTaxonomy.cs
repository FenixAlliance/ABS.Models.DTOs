using System.Collections.Generic;

namespace FenixAlliance.ABM.Models.DTOs.Components.Store.Products
{
    public class ProductGTaxonomy
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string ParentID { get; set; }
        public List<ProductGTaxonomy> Childs { get; set; }
    }
}
