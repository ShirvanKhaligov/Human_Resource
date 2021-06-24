using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Quiz
{
    public class Choice
    {
        public int ChoiceID { get; set; }

        public string ChoiceText { get; set; }

        public int? QuestionID { get; set; }
        public bool IsTrue { get; set; }

        public virtual Question Question { get; set; }
    }
}
