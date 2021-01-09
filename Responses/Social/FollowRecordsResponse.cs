using System.Collections.Generic;
using FenixAlliance.ABM.Models.DTOs.Components.Social;

namespace FenixAlliance.ABM.Models.DTOs.Responses.Social
{
    public class FollowRecordsResponse : APIResponse
    {
        public List<FollowRecord> FollowRecords { get; set; }
    }

}
