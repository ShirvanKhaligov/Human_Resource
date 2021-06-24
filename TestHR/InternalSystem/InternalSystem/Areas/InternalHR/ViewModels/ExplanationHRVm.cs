using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.Departments;
using InternalSystem.Areas.InternalHR.Models.Permissions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class ExplanationHRVm
    {
        public IEnumerable<Emplooyee> Emplooyees { get; set; }
        public IEnumerable<Explanation> Explanations { get; set; }
        public IEnumerable<Permission> Permissions { get; set; }
        public IEnumerable<ExplanationToEmployee> ExplanationToEmployees { get; set; }
        public IEnumerable<PermissionToEmployeee> PermissionToEmployeees { get; set; }
        public Permission Permission { get; set; }
        public Explanation Explanation { get; set; }
        public PermissionToEmployeee PermissionToEmployeee { get; set; }
        public ExplanationToEmployee ExplanationToEmploy { get; set; }





        public Emplooyee Emplooyee { get; set; }
        public Emplooyee EmplooyeeDetailScan { get; set; }
        public Commands Commands { get; set; }

        [Required(ErrorMessage = "Zəhmət olmasa işçi seçin!")]
        public int? EmplooyeeId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa iş növünü seçin!")]
        public int? WorkTimeOfTypeId { get; set; }
        public int? TaxBreakId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa vəzifəni seçin!")]
        public int? PositionId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa maaşı seçin!")]
        public decimal? Salary { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Zəhmət olmasa qəbul vaxtını seçin!")]
        public DateTime CreatedDate { get; set; }
        public WorkTimeOfType WorkTimeOfType { get; set; }
        public TaxBreakToEmplooyee TaxBreakToEmplooyee { get; set; }
        public IEnumerable<SubDepartment> SubDepartments { get; set; }
        public IEnumerable<Position> Positions { get; set; }
        public int CommandInEmpId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa iş növünü seçin!")]
        public int WorkPlace { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa səbəbi qeyd edin")]
        public string Reason { get; set; }


    }
}
