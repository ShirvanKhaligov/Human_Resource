using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class PhoneNumbers
    {
        public PhoneNumbers()
        {
            PhoneNumberToEmployees = new HashSet<PhoneNumberToEmployee>();
        }
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Simvol sayı 50-dən çox ola bilməz!")]
        public string HomeNumber { get; set; } 
        [Required(ErrorMessage ="Zəhmət olmasa mobil nömrəni daxil edin"),StringLength(50, ErrorMessage = "Simvol sayı 50-dən çox ola bilməz!")]
        public string PhoneNumber { get; set; } 
        public virtual ICollection<PhoneNumberToEmployee> PhoneNumberToEmployees{ get; set; }

    }
}
