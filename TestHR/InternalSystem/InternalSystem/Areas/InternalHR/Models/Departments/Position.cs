using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Departments
{
    public class Position
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Xananı boş buraxmayın")]
        [MaxLength(100, ErrorMessage = "Vəzifə 100 hərfdən böyük ola bilməz!"), MinLength(2, ErrorMessage = "2 hərfdən az vəzifə ola bilməz!")]
        public string Name { get; set; }
        public int VacationDayCount { get; set; }
        public bool Status { get; set; }
        public int? SubDepartmentId { get; set; }
        public virtual SubDepartment SubDepartment { get; set; }
        public virtual ICollection<Emplooyee> Emplooyeess { get; set; }
    }
}
