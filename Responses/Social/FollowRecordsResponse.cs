using System.Collections.Generic;
using FenixAlliance.Models.DTOs.Components.Social;

namespace FenixAlliance.Models.DTOs.Responses.Base
{
    public class FollowRecordsResponse : APIResponse
    {
        public List<FollowRecord> FollowRecords { get; set; }
    }

}
