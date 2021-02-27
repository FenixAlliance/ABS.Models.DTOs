using FenixAlliance.ABM.Models.DTOs.Components.Global.Currencies;
using System.Collections.Generic;

namespace FenixAlliance.ABM.Models.DTOs.Responses.Global
{
    public class CurrenciesResponse : APIResponse
    {
        public List<Currency> Currencies { get; set; }
    }
}
