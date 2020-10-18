using System.Collections.Generic;
using FenixAlliance.Models.DTOs.Components.Businesses;

namespace FenixAlliance.Models.DTOs.Responses.Business
{
    public partial class BusinessEnrollmentsResponse : APIResponse
    {
        public List<Enrollment> Enrollments { get; set; }
    }
}
