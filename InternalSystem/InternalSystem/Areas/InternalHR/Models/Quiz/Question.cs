using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Quiz
{
    public class Question
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            Answers = new HashSet<Answer>();
            Choices = new HashSet<Choice>();
        }
        public int QuestionID { get; set; }
        public string QuestionNo { get; set; }
        public string QuestionText { get; set; }
        public string StartTime { get; set; }
        public int? QuizID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Choice> Choices { get; set; }

        public virtual Quiz Quiz { get; set; }
    }
}
