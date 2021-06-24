using InternalSystem.Areas.InternalHR.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class MessageForEmployeeVM
    {
        [Required(ErrorMessage = "Zəhmət olmasa boş buraxmayın")]
        [MinLength(17, ErrorMessage = "Simvolların sayı 17 dən az ola bilməz")]
        public string Description { get; set; }
        public IFormFile Photo { get; set; }
        public IFormFile PhotoUpd { get; set; }
        public MessageForEmployee MessageForEmployee { get; set; }
        public Emplooyee Emplooyee { get; set; }
    }
}
