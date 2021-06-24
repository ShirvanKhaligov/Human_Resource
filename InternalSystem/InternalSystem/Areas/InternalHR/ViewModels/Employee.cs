using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class Employee
    {
        public IEnumerable<Emplooyee> Emplooyees { get; set; }
       // public IEnumerable<CommandType> CommandTypes { get; set; }
        public Emplooyee Emplooyee { get; set; }
        public EducationType EducationType { get; set; }
        public IEnumerable<EducationType> EducationTypes { get; set; }
        public  IEnumerable<EducationsToEmployee> EducationsToEmployees { get; set; }

    }
}
