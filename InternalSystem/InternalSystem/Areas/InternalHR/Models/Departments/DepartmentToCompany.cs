using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Departments
{
    public class DepartmentToCompany
    {
        public int Id { get; set; } 
        public int? DepartmentId { get; set; }
        public int? CompanyId { get; set; }
        public virtual Department Department { get; set; }
        public virtual Companies Company { get; set; }
        public int? MenegerId { get; set; }
        public virtual Emplooyee Meneger { get; set; }

        //public int? DirectorId { get; set; }
        //public virtual Emplooyee Director { get; set; }




        public virtual ICollection<SubDepartment> SubDepartments { get; set; }
        //public virtual ICollection<DepBossPosition> DepBossPositions { get; set; }
    }
}
