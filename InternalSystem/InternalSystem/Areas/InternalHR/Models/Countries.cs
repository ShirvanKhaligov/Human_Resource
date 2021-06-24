using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class Countries
    {
        public int Id { get; set; }
        [Required, StringLength(50, ErrorMessage = "Simvol sayı 50-dən çox ola bilməz!")]
        public string Name { get; set; }
        public virtual ICollection<Cities> Cities { get; set; }
        //public virtual ICollection<Companies> Companies { get; set; }
        public bool Status { get; set; }
    }
}
