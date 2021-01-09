using System.Collections.Generic;
using FenixAlliance.ABM.Models.DTOs.Components.Tenants;

namespace FenixAlliance.ABM.Models.DTOs.Responses.Business
{
    public partial class BusinessEnrollmentsResponse : APIResponse
    {
        public List<Enrollment> Enrollments { get; set; }
    }
}
