using System;
using System.Collections.Generic;
using System.Text;
using FenixAlliance.Models.DTOs.Components.Commons;
using FenixAlliance.Models.DTOs.Responses;

namespace FenixAlliance.ABM.Models.DTOs.Responses.Global
{
    public class CurrenciesResponse : APIResponse
    {
        public List<Currency> Currencies { get; set; }
    }
}
