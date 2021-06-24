using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Departments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class DeptAndSubDeptVM
    {
        public Department Department { get; set; }
        public SubDepartment SubDepartment { get; set; }
        public Companies Companies { get; set; }
        public DepartmentToCompany DepartmentToCompany { get; set; }
        public IEnumerable<SubDepartment> SubDepartments { get; set; }
        public IEnumerable<DepartmentToCompany> DepartmentToCompanies { get; set; }
        public IEnumerable<Companies> Companiess { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Position> Positions { get; set; }
        public Position Position { get; set; }
        public int? DepartmentId { get; set; }
        public int? SubDepartmentId { get; set; }
        public int? CompaniesId { get; set; }
    }
}
