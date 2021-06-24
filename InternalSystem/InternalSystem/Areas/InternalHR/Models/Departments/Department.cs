using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Departments
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Bu xananı boş buraxmayın")]
        [MaxLength(100, ErrorMessage = "Şöbə 100 hərfdən çox ola bilməz!"), MinLength(2, ErrorMessage = "Şöbə 2 hərfdən az ola bilməz!")]
        public string Name { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<DepartmentToCompany> DepartmentToCompanies { get; set; }
        //public int? MenegerId { get; set; }
        //public virtual Emplooyee Meneger { get; set; }
        //public virtual ICollection<SubDepartment> SubDepartments{ get; set; }

    }
}
