using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class RegisterVM
    {

        [Required(ErrorMessage = "Email adresinizi yazın")]
        [MinLength(5)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Adınızı daxil edin")]
        [MinLength(2)]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Soydınızı daxil edin")]
        [MinLength(2)]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Parolunuz daxil edin")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Boş buraxmaq olmaz"), Compare(nameof(Password), ErrorMessage = "Parollar eyni deyil")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
