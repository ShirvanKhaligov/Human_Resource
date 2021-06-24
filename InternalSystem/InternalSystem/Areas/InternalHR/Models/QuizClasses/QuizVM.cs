using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.QuizClasses
{
    public class QuizVM
    {
        public int QuizID { get; set; }
        public string QuizName { get; set; }
        public List<SelectListItem> ListOfQuizz { get; set; }
    }
}
