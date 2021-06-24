using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.Departments;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class CommandDepBossVM
    {
        //public IEnumerable<DepBossPosition> DepBossPositions { get; set; }
        public IEnumerable<Commands> Commands { get; set; }
        public IEnumerable<Emplooyee> Emplooyees { get; set; }
        public IEnumerable<WorkTimeOfType> WorkTimeOfTypes { get; set; }
        public IEnumerable<TaxBreak> TaxBreaks { get; set; }
        public IEnumerable<DepartmentToCompany> DepartmentToCompanies { get; set; }
        public IEnumerable<CommandsToEmployee> CommandsToEmployees { get; set; }
        public IEnumerable<CommandsToEmployee> CommandsToEmployeess { get; set; }
        public Emplooyee Emplooyee { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa maaşı seçin")]
        public decimal? Salary { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa işçi seçin")]
        public int EmployeeId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Zəhmət olmasa qəbul vaxtını seçin!")]
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa iş növünü seçin!")]
        public int? WorkTimeOfTypeId { get; set; }
        public int? TaxBreakId { get; set; }
        public WorkBookAddition WorkBookAddition { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa şöbəni seçin!")]
        public int? DepartmentId { get; set; }
        public CommandsToEmployee CommandsToEmployee { get; set; }
        public TaxBreakToEmplooyee TaxBreakToEmplooyee { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa iş növünü seçin!")]
        public int WorkPlace { get; set; }
        public DepartmentToCompany DepartmentToCompany { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa pdf faylı seçin")]
        public IFormFile PdfScanQuitWork { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa səbəbi qeyd edin")]
        public string Reason { get; set; }
    }
}
