using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class UniversityVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa xananı doldurun!!")]
        [MinLength(2, ErrorMessage = "Hərf sayı ən az 1 və ən çox  50 den olamalıdır"), MaxLength(100, ErrorMessage = "Hərf sayı ən az 1 və ən çox  100  olamalıdır")]
        public string Name { get; set; }
    }
}
