using InternalSystem.Areas.InternalHR.Models.Permissions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class PermissionVM
    {
        public Permission Permission { get; set; }
        public IEnumerable<PermissionToEmployeee> Permissions { get; set; }
        public IEnumerable<PermissionType> permissionTypes { get; set; }
        public int Hour { get; set; }
        public string PermissionType { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa səbəb yazın!!!"), StringLength(120, ErrorMessage = "Simvol sayı 120-dən çox ola bilməz!")]
        public string ReasonOne { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa səbəb yazın!!!"), StringLength(120, ErrorMessage = "Simvol sayı 120-dən çox ola bilməz!")]
        public string ReasonTwo { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime FromDateForHour { get; set; }
        public DateTime ToDateForHour { get; set; }
        public DateTime FromDateForDay { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime ToDateForDay { get; set; }
    }
}
