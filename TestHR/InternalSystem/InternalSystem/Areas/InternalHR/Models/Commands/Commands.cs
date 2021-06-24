using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Commands
{
    public class Commands
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş buraxılmamalıdır")]
        [StringLength(50, ErrorMessage = "Simvol sayı 50-dən çox ola bilməz!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş buraxılmamalıdır")]
        [StringLength(250, ErrorMessage = "Simvol sayı 250-dən çox ola bilməz!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Boş buraxılmamalıdır")]
        [StringLength(1300, ErrorMessage = "Simvol sayı 1300-dən çox ola bilməz!")]
        public string Description { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<CommandsToEmployee> CommandsToEmployees { get; set; }


    }
}
