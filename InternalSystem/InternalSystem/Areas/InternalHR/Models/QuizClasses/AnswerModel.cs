using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.QuizClasses
{
    public class AnswerModel
    {
        public string QuestionID { get; set; }
        public string ChoiceID { get; set; }
        public string QuizID { get; set; }
        public string qno { get; set; }
        public int UserID { get; set; }
    }
}
