using System.Collections.Generic;
using FenixAlliance.ABM.Models.DTOs.Components.Global.Countries;

namespace FenixAlliance.ABM.Models.DTOs.Responses.Global
{
    public class CountriesResponse : APIResponse
    {
        public List<Country> Countries { get; set; }
    }
}
