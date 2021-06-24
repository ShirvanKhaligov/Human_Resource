using InternalSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Quiz
{
    public class Answer
    {
        public int AnswerID { get; set; }

        public int? ChoiceID { get; set; }

        public int? QuestionID { get; set; }

        public int? UserId { get; set; }

        public virtual Question Question { get; set; }
        public virtual Choice Choice { get; set; }
        //public virtual AppUser User { get; set; }
    }
}
