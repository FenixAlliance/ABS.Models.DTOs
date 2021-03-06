﻿using System;

namespace FenixAlliance.ABM.Models.DTOs.Components.Social
{
    public partial class PrivateMessage
    {
        public string ID { get; set; }
        public bool Readed { get; set; }
        public string Message { get; set; }
        public string SenderSocialProfileID { get; set; }
        public string ReceptorSocialProfileID { get; set; }
        public DateTime SendedTimestamp { get; set; }
        public DateTime ReadedTimestamp { get; set; }
        public DateTime ReceivedTimestamp { get; set; }
    }


}
