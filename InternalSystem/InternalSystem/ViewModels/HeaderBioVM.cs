using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.Models;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.ViewModels
{
    public class HeaderBioVM
    {
        public AppUser AppUser { get; set; }
        public CommandsToEmployee CommandsToEmployee { get; set; }
        public IEnumerable<DepartmentToCompany> DepartmentToCompanies { get; set; }
        public IEnumerable<Emplooyee> Emplooyees { get; set; }
        public IEnumerable<Emplooyee> Emplooyeess { get; set; }
        
    }
}
