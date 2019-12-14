using System.Collections.Generic;

namespace FenixAlliance.Models.DTOs.Responses.Base
{
    public class APICurrenciesResponse : APIResponse
    {
        public List<APICurrency> Currencies { get; set; }
    }

    public class APICurrency
    {
        public string ID { get; set; }
        public string QualifiedName { get; set; }
        public string Name { get; set; }
        public string ISO { get; set; }
        public string Symbol { get; set; }
        public string CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryFlagURL { get; set; }
        public double ForexExchange { get; set; }
    }
}
