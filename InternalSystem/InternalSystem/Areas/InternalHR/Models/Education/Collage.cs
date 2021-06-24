using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Education
{
    public class Collage
    {
        public int Id { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "Hərf sayı ən az 1 və ən çox 50 olmalıdır"), MaxLength(100, ErrorMessage = "Hərf sayı ən az 1 və ən çox  50  olmalıdır")]
        public string Name { get; set; }
        //public int EducationTypeId { get; set; }
        //public virtual EducationType EducationType { get; set; }

    }
}
