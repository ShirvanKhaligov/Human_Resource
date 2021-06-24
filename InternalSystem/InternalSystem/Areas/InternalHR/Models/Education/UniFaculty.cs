using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Education
{
    public class UniFaculty
    {
        public UniFaculty()
        {
            
        }
        public int Id { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa xananı doldurun!!")]
        [MinLength(1, ErrorMessage = "Hərf sayı ən az 1 və ən çox  100  olmalıdır"), MaxLength(100, ErrorMessage = "Hərf sayı ən az 1 və ən çox 100  olmalıdır")]
        public string Name { get; set; }
        public bool Status { get; set; }
        public int EducationTypeToUniversityId { get; set; }
        public virtual EducationTypeToUnivercity EducationTypeToUniversity { get; set; }
    }
}
