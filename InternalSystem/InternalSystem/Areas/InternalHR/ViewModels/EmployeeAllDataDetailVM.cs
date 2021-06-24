using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.ComputerSk;
using InternalSystem.Areas.InternalHR.Models.Departments;
using InternalSystem.Areas.InternalHR.Models.Education;
using InternalSystem.Areas.InternalHR.Models.Languages;
using InternalSystem.Areas.InternalHR.Models.Relations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class EmployeeAllDataDetailVM
    {
        public Emplooyee Emplooyee { get; set; }
        public IEnumerable<EducationsToEmployee> EducationsToEmployees { get; set; }
        public IEnumerable<LanguageToEmployee> LanguageToEmployees { get; set; }
        public IEnumerable<ComputerToEmployee> ComputerToEmployees { get; set; }
        public IEnumerable<RelationToEmployee> RelationToEmployees { get; set; }
        public School School { get; set; }
        public PhoneNumberToEmployee PhoneNumberToEmployee { get; set; }
        public CommandsToEmployee CommandsToEmployee { get; set; }
        public int DepartmentId { get; set; }
        public DepartmentToCompany DepartmentToCompany { get; set; }
    }
}
