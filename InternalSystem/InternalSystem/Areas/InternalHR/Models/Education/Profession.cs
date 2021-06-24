using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Education
{
    public class Profession
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa xanaları doldurun!!")]
        [MinLength(1, ErrorMessage = "Hərf sayı ən az 1 və ən çox  50   olmalıdır"), MaxLength(100, ErrorMessage = "Hərf sayı ən az 1 və ən çox  100  olmalıdır")]
        public string Name { get; set; }
        public bool Status { get; set; }
        public int? UniFacultyId { get; set; }
        public virtual UniFaculty UniFaculty { get; set; }
        
    }
}
