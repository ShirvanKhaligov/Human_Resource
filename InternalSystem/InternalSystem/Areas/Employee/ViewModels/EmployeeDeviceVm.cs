using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class EmployeeDeviceVm
    {

        public IEnumerable<Emplooyee> Emplooyees { get; set; }
        public IEnumerable<DevicesType> DevicesTypes { get; set; }
        public IEnumerable<AdditionalEquipment> AdditionalEquipments { get; set; }
        public AdditionalEquipment AdditionalEquipment { get; set; }
        public IEnumerable <DeviceToEmployee> DeviceToEmployees { get; set; }
        public IQueryable<DeviceToEmployee> DeviceToEmployeesDic { get; set; }
        public IList<DeviceToEmployee> DeviceToEmployeesList { get; set; }

        public IEnumerable<DeviceToEmployee> DeviceToEmployeesStatusFalse { get; set; }
        public DeviceToEmployee DeviceToEmployee { get; set; }
        public Device Device { get; set; }
        public Emplooyee Emplooyee { get; set; }
        [StringLength(200, ErrorMessage = "Simvol sayı 200-dən çox ola bilməz!")]
        public string Parametr { get; set; }

        [StringLength(200, ErrorMessage = "Simvol sayı 200-dən çox ola bilməz!")]
        public string SeriaNumber { get; set; }
        public int MouseCount { get; set; }
        public int HeadPhoneCount { get; set; }
        public int IpPhoneNumber { get; set; }
        
        public int InternalNumber { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa işçi seçin")]
        public int? EmplooyeeId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa qurğu seçin")]
        public int? DeviceTypeId
        {
            get; set;


        }
    }
}
