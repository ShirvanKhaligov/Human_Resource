using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Education
{
    public class School
    {
        public int Id { get; set; }
        //[StringLength(100,ErrorMessage = "Hərf sayı 100dən çox olmalıdır")]
        //[MinLength(1, ErrorMessage = "Hərf sayı ən az 1 və ən çox  100  olmalıdır"), MaxLength(100, ErrorMessage = "Hərf sayı ən az 1 və ən çox  100  olmalıdır")]
        public string Name { get; set; }
        public int? EducationTypeId { get; set; }
        public virtual EducationType EducationType { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
    }
}
