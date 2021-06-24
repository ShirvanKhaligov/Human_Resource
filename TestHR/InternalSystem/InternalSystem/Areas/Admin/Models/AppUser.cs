using InternalSystem.Areas.InternalHR.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Admin.Models
{
    public class AppUser: IdentityUser
    {
        [Required, StringLength(50, ErrorMessage = "Simvol sayı 55 dən artiq ola bilməz")]
        public string Name { get; set; }
        [Required, StringLength(70, ErrorMessage = "Simvol sayı 70 dən artiq ola bilməz")]
        public string Surname { get; set; }
        [Required, StringLength(70, ErrorMessage = "Simvol sayı 70 dən artiq ola bilməz")]
        public string FatherName { get; set; }
        public bool Status { get; set; }
        public string Image { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public int? CompaniesId { get; set; }
        public virtual Companies Companies { get; set; }
        public string AdminId { get; set; }
    }
}
