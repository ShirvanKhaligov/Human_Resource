using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.CompanyAdmin.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Zəhmət olmasa mail daxil edin!!!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa yeni şifrəni daxil edin!!!")]
        public string Password { get; set; }
    }
}
