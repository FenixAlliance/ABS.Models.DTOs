using System.Collections.Generic;
using FenixAlliance.Models.DTOs.Components.Social;

namespace FenixAlliance.Models.DTOs.Responses.Base
{
    public class APINotificationsResponse : APIResponse
    {
        public List<Notification> Notifications { get; set; }
    }
}
