using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.Models.Departments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class Companies
    {
        public Companies()
        {
            DepartmentToCompanies = new HashSet<DepartmentToCompany>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa şirkətin adın daxil edin"), MaxLength(100, ErrorMessage = "Sirkət adı 100 hərfdən böyük ola bilməz"), MinLength(2, ErrorMessage = "2 hərfdən az şirkət ad ola bilməz")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa VÖEN nömrəsin daxil edin"), MaxLength(110, ErrorMessage = "110 Simvoldan böyük ola bilməz"), MinLength(2, ErrorMessage = "2 simvoldan az ola bilməz")]
        public string TaxId { get; set; }
        public string RegistrationNumber { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa ünvanı daxil edin"), MaxLength(50, ErrorMessage = "50 Simvoldan böyük ola bilməz"), MinLength(10, ErrorMessage = "10 simvoldan az ola bilməz")]
        public string Address { get; set; }
        public string Website { get; set; }
        public string ZipCode { get; set; }
        public int CityId { get; set; }
        public virtual ICollection<DepartmentToCompany> DepartmentToCompanies { get; set; }
        public virtual Cities City { get; set; }
        public virtual ICollection<AppUser> AppUsers { get; set; }
        public bool status { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Emplooyee> Emplooyees { get; set; }
        public DateTime ExeTime { get; set; }

    }
}
