using FenixAlliance.ABM.Models.DTOs.Components.Global.Countries;
using System.Collections.Generic;

namespace FenixAlliance.ABM.Models.DTOs.Responses.Global
{
    public class CountriesResponse : APIResponse
    {
        public List<Country> Countries { get; set; }
    }
}
