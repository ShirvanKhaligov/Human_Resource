using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Departments;
using InternalSystem.Areas.InternalHR.Models.Devices;
using InternalSystem.Areas.InternalHR.Models.Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class InformationVM
    {
        public IEnumerable<EducationsToEmployee> EducationsToEmployee { get; set; }
        public IEnumerable<DepartmentToCompany> DepartmentToCompany { get; set; }
        public IEnumerable<DeviceToEmployee> DeviceToEmployees { get; set; }
        public IEnumerable<DevicesType> DevicesTypes { get; set; }


        public AppUser AppUser { get; set; }
        public Position Position { get; set; }
        public DepartmentToCompany DepartmentToCompanyy { get; set; }
        public DeviceToEmployee DeviceToEmployee { get; set; }
        public DevicesType DevicesType { get; set; }

    }
}
