using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class TelMe
    {
        public int Id { get; set; }
        [Required]
        public string Message { get; set; }
        public string Image { get; set; }
        public bool IsDelete { get; set; }
        public bool  Status { get; set; }
        public int EmployeeId { get; set; }
        public virtual Emplooyee Employee { get; set; }
    }
}
