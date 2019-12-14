using System;

namespace FenixAlliance.Models.DTOs.Components.Commons
{
    public class ProductReview
    {
        public string ID { get; set; }
        public double Score { get; set; }
        public string Message { get; set; }
        public string SocialProfileID { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
