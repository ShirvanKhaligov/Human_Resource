using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.CompanyAdmin.ViewModels
{
    public class HrVM
    {
            [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın"), StringLength(40, ErrorMessage = "Soyad 50 hərfdən artıq ola bilməz")]
            public string Name { get; set; }
            [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın"), StringLength(40, ErrorMessage = "Soyad 50 hərfdən artıq ola bilməz")]
            public string Surname { get; set; }
            [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın"), StringLength(40, ErrorMessage = "Ad 40 hərfdən artıq ola bilməz")]
            public string FatherName { get; set; }
            [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın")]
            public string PhoneNumber { get; set; }
            [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın"), StringLength(40, ErrorMessage = "İstifadəçi adı 50 hərfdən artıq ola bilməz")]
            public string UserName { get; set; }
            [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın"), StringLength(40, ErrorMessage = "Ad 40 hərfdən artıq ola bilməz")]
            public string Email { get; set; }
            [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın"), DataType(DataType.Password)]
            public string Password { get; set; }
            [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın"), Compare(nameof(Password), ErrorMessage = "Şifrəni düzgün yazın"), DataType(DataType.Password)]
            public string ConfirmPassword { get; set; }
            [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın")]
            public IFormFile Photo { get; set; }
            public IFormFile PhotoUpd { get; set; }

        }
}
