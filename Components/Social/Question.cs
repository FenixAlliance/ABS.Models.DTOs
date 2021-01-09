using System.Collections.Generic;

namespace FenixAlliance.ABM.Models.DTOs.Components.Social
{
    public class Question
    {
        public string ID { get; set; }
        public string AskerID { get; set; }
        public string QuestionType { get; set; }
        public string QuestionMessage { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
