using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Departments;
using InternalSystem.Areas.InternalHR.Models.Devices;
using InternalSystem.Areas.InternalHR.Models.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class EmployeeDeviceVm
    {
        public IEnumerable<DevicesType> DevicesTypes { get; set; }
        public IEnumerable<Emplooyee> Emplooyees { get; set; }
        public IEnumerable<DeviceToEmployee> DeviceToEmployees { get; set; }
        public DeviceToEmployee DeviceToEmployee { get; set; }
        public IEnumerable<Position> Positions { get; set; }
        public Device Device { get; set; }
        public Emplooyee Emplooyee { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{DD/MM/YYYY}", ApplyFormatInEditMode = true)]
        public DateTime GivingTime { get; set; }

    }
}
