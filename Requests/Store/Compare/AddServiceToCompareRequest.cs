using System;
using System.Collections.Generic;
using System.Text;

namespace FenixAlliance.Models.DTOs.Requests
{
    public class AddServiceToCompareRequest
    {
        public string CartID { get; set; }
        public string ServiceID { get; set; }

    }
}
