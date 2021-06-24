using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.DemoEducation
{
    public class DemoProfession
    {
        public int Id { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "Hərf sayı ən az 1 və ən çox  50   olmalıdır"), MaxLength(50, ErrorMessage = "Hərf sayı ən az 1 və ən çox  100  olmalıdır")]
        public string Name { get; set; }
        public int DemoFacultyid { get; set; }
        public virtual DemoFaculty DemoFaculty { get; set; }
    }
}
