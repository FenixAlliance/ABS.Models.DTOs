using FenixAlliance.Models.DTOs.Requests.SAR;

namespace FenixAlliance.Models.DTOs.Requests
{
    public class ServiceSARUsageRequest : SARUsageRecord
    {
        public string ServiceID { get; set; }
    }
}
