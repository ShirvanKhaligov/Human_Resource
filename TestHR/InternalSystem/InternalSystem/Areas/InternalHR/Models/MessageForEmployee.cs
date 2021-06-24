using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class MessageForEmployee
    {
        public int Id { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa boş buraxmayın")]
        [MinLength(17, ErrorMessage = "Simvolların sayı 17 dən az ola bilməz")]
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime TimeExecution { get; set; }
        public bool Status { get; set; }
    }
}
