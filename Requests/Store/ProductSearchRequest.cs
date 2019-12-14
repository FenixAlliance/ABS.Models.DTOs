namespace FenixAlliance.Models.DTOs.Requests
{
    public class ProductSearchRequest
    {
        public string[] ProductsToSearch { get; set; }
        public string[] AttributesToSearch { get; set; }
        public string[] BrandsToSearch { get; set; }
        public string[] TagsToSearch { get; set; }
        public string[] ProductTypesToSearch { get; set; }
        public string[] CategoriesToSearch { get; set; }
        public string[] ShippingCountriesToSearch { get; set; }

        public string Query { get; set; }

        public bool DisplayOutOfStock { get; set; }
        public bool DisplayByRequest { get; set; }

        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }
    }
}
