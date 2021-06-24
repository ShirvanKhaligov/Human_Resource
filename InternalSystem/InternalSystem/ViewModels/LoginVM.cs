using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Zəhmət olmasa mail daxil edin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa şifrəni daxil edin")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Is { get; set; }
    }
}
