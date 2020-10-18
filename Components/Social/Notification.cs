using System;

namespace FenixAlliance.Models.DTOs.Components.Social
{
    public partial class Notification
    {
        public string ID { get; set; }
        public bool Readed { get; set; }
        public string Message { get; set; }
        public string SocialProfileID { get; set; }
        public DateTime IssuedTimestamp { get; set; }
        public DateTime ReadedTimestamp { get; set; }
    }




}
