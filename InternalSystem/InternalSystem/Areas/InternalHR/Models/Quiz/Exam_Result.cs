using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Quiz
{
    [NotMapped]
    public class Exam_Result
    {

        public int Id { get; set; }
        public string FullName { get; set; }
        public string QuizName { get; set; }
        public int Score { get; set; }

    }
}
