using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class ForgetPasswordVM
    {
        [Required(ErrorMessage = "Emaili adresiniz yazın!!!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
