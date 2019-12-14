using System.Collections.Generic;
using FenixAlliance.Models.DTOs.Components.Businesses;

namespace FenixAlliance.Models.DTOs.Responses.Business
{
    public partial class APIBusinessEnrollmentsResponse : APIResponse
    {
        public List<Enrollment> BusinessEnrollments { get; set; }
    }
}
