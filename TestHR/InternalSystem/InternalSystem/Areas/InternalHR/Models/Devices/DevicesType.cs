using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Devices
{
    public class DevicesType
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Xananı boş buraxmayın")]
        [StringLength(50, ErrorMessage = "Simvol sayı 50-dən çox ola bilməz!")]
        public string Name { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}
