using FenixAlliance.Models.DTOs.Requests.SAR;

namespace FenixAlliance.Models.DTOs.Requests
{
    public class SubscriptionSARUsageRequest : SARUsageRecord
    {
        public string SubscriptionID { get; set; }
    }
}
