using Newtonsoft.Json;
using System.Collections.Generic;

namespace FenixAlliance.Models.DTOs.Components.Commons
{
    public class ProductGTaxonomy
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string ParentID { get; set; }
        [JsonIgnore] public List<ProductGTaxonomy> Childs { get; set; }
    }
}
