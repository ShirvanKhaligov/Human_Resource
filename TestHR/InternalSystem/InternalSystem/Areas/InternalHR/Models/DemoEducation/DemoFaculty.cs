using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.DemoEducation
{
    public class DemoFaculty
    {
        public int Id { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "Hərf sayı ən az 1 və ən çox  100  olmalıdır"), MaxLength(100, ErrorMessage = "Hərf sayı ən az 1 və ən çox 100  olmalıdır")]
        public string Name { get; set; }
        public int DemoEducationTypeToUniversityId { get; set; }
        public virtual DemoEducationTypeToUniversity DemoEducationTypeToUniversity { get; set; }

    }
}
