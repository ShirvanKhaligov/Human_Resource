using InternalSystem.Areas.InternalHR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Admin.ViewModels
{
    public class CompanyVM
    {
        public IEnumerable<Cities> Cities { get; set; }
        public IEnumerable<Countries> Countries { get; set; }
        public Companies Company { get; set; }
        public IEnumerable<Companies> Companies { get; set; }

        [Required(ErrorMessage = "Zəhmət olmasa şirkətin adın daxil edin!!"), MaxLength(100, ErrorMessage = "Sirkət adı 100 hərfdən böyük ola bilməz!"), MinLength(2, ErrorMessage = "2 hərfdən az şirkət ad ola bilməz!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa VÖEN nömrəsin daxil edin!!!"), MaxLength(110, ErrorMessage = "110 Simvoldan böyük ola bilməz!"), MinLength(2, ErrorMessage = "2 simvoldan az ola bilməz!")]
        public string TaxId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa ünvanı daxil edin!!"), MaxLength(50, ErrorMessage = "50 Simvoldan böyük ola bilməz!"), MinLength(10, ErrorMessage = "10 simvoldan az ola bilməz!")]
        public string Address { get; set; }
    }
}
