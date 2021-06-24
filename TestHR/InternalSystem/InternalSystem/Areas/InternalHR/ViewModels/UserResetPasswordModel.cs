using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class UserResetPasswordModel
    {
        [Required(ErrorMessage = "Xananı boş buraxmayın"), DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Xananı boş buraxmayın"), DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        public string Token { get; set; }
        public string UserId { get; set; }
    }
}
