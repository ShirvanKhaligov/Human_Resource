using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalSystem.Areas.InternalHR.Models.Quiz
{
    [Table("Quiz")]
    public class Quiz
    {
       // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quiz()
        {
            Questions = new HashSet<Question>();
        }
        public int QuizID { get; set; }

        [StringLength(80)]
        public string QuizName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}
