using InternalSystem.Areas.InternalHR.Models.Departments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class DepartmantsVM
    {
        public int Id { get; set; }
        [Required, MaxLength(50, ErrorMessage = "Vəzifə 50 hərfdən böyük ola bilməz!"), MinLength(2, ErrorMessage = "2 hərfdən az vəzifə ola bilməz!")]
        public string Name { get; set; }
       
    }
}
