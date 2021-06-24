using InternalSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.CompanyAdmin.ViewModels
{
    public class AccountVM
    {
        [Required(ErrorMessage ="Zəhmət olmasa hazırki şifrəni daxil edin!!!")]
        public string CurrentPassword { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa yeni şifrəni daxil edin!!!")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa yeni şifrəni daxil edin!!!")]
        public string ReNewPassword { get; set; }
    }
}
