using System.Collections.Generic;
using FenixAlliance.Models.DTOs.Components.Social;

namespace FenixAlliance.Models.DTOs.Responses.Base
{
    public class APIFollowActivityResponse : APIResponse
    {
        public List<FollowRecord> FollowActivities { get; set; }
    }

}
