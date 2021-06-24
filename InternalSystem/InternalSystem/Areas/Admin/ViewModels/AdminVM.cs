using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;



namespace InternalSystem.Areas.Admin.ViewModels
{
    public class AdminVM
    {
        public UserManager<AppUser> _userManager;
        public IEnumerable<Companies> Companies { get; set; }
        public Companies Companiess { get; set; }
        //public virtual AdminTable AdminTable { get; set; }
        //public IEnumerable<AdminTable> AdminTables { get; set; }
        public IEnumerable<AppUser> AppUsers { get; set; }
        public AppUser AppUser { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın"), StringLength(40, ErrorMessage = "Ad 40 hərfdən artıq ola bilməz")]
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
