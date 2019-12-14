using System;
using System.Collections.Generic;
using System.Text;

namespace FenixAlliance.Models.DTOs.Components.Commons
{
    public class Answer
    {
        public string ID { get; set; }
        public string ResponderID { get; set; }
        public string AnswerType{ get; set; }
        public string AnswerMessage { get; set; }
    }
}
