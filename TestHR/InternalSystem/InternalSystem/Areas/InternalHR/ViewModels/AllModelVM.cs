using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.Departments;
using InternalSystem.Areas.InternalHR.Models.Education;
using InternalSystem.Areas.InternalHR.Models.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class AllModelVM
    {
        public IEnumerable<Emplooyee> Emplooyees { get; set; }
        public Emplooyee Emplooyee { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Universities> Universities { get; set; }
        public IEnumerable<EducationType> EducationTypes { get; set; }
        public IEnumerable<EducationTypeToUnivercity> EducationTypeToUnivercities { get; set; }
        public IEnumerable<Commands> Commands { get; set; }
        public IEnumerable<Gender> Genders  { get; set; }
        public IEnumerable<MarialStatus> MarialStatuses  { get; set; }
        public IEnumerable<LastWorkPlace> LastWorkPlaces  { get; set; }
        public IEnumerable<PhoneNumberToEmployee> phoneNumberToEmployees  { get; set; }
        public EducationsToEmployee educationsToEmployees  { get; set; }
        public Department Department { get; set; }
        public Position Position { get; set; }

        public SubDepartment SubDepartment { get; set; }
        public IEnumerable<DepartmentToCompany> DepartmentToCompanies { get; set; }
        public IEnumerable<DepartmentToCompany> DepartmentBoss { get; set; }
        //public PhoneNumberToEmployee PhoneNumberToEmployee { get; set; }

        public int EmpCount { get; set; }
        public int EmpCountfordep { get; set; }

        public int DepCount { get; set; }
        public int DepToComCount { get; set; }

        public int PositionCount { get; set; }
        public int WomenCount { get; set; }
        public int MenCount { get; set; }



    }
}
