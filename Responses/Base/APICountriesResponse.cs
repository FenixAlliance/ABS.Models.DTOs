using System.Collections.Generic;

namespace FenixAlliance.Models.DTOs.Responses.Base
{
    public class APICountriesResponse : APIResponse
    {
        public List<ApiCountry> Countries { get; set; }
    }

    public class ApiCountry
    {
        public string ISO2 { get; set; }
        public string ISO3 { get; set; }
        public string FlagURL { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }

    }
}
