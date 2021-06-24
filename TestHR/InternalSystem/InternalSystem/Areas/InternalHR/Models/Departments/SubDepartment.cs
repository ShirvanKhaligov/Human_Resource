using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Departments
{
    public class SubDepartment
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Xananı boş buraxmayın")]
        [MaxLength(100, ErrorMessage = "Alt şöbə 100 hərfdən çox ola bilməz!"), MinLength(2, ErrorMessage = "Alt şöbə 2 hərfdən az ola bilməz!")]
        public string Name { get; set; }
        public bool Status { get; set; }
        public int? DepartmentToCompanyId { get; set; }
        public virtual DepartmentToCompany DepartmentToCompany { get; set; }
        public virtual ICollection<Position> Positions { get; set; }

    }
}
