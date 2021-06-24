using InternalSystem.Areas.InternalHR.Models.Permissions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class ExplanationForHrVM
    {
        public Permission Permission { get; set; }
        public IEnumerable<PermissionToEmployeee> Permissions { get; set; }
        public IEnumerable<ExplanationToEmployee> Explanations { get; set; }

        public IEnumerable<PermissionType> PermissionTypes { get; set; }
        public int Hour { get; set; }
        public string PermissionType { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa seçin")]
        public int? PermissionTypeId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa seçin")]
        public string PermissionTypeName { get; set; }
        //Saatliq
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FromDate { get; set; } //1
        public DateTime FromDateForHour { get; set; } //2
        public DateTime ToDateForHour { get; set; } //3
        [Required(ErrorMessage = "Zəhmət olmasa səbəb yazın"), StringLength(120, ErrorMessage = "Simvol sayı 120-dən çox ola bilməz")]
        public string ReasonOne { get; set; } //4

        //Gunluk
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FromDateForDay { get; set; } //1
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ToDateForDay { get; set; } //2
        [Required(ErrorMessage = "Zəhmət olmasa səbəb yazın"), StringLength(120, ErrorMessage = "Simvol sayı 120-dən çox ola bilməz")]
        public string ReasonTwo { get; set; } //3
        public DateTime ToDate { get; set; }

        public string Description { get; set; }

    }
}
