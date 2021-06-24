﻿using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.Departments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class CommandEmpPositionChVM
    {
        public IEnumerable<Emplooyee> Emplooyees { get; set; }
        public IEnumerable<Commands> Commandss { get; set; }
        public IEnumerable<WorkTimeOfType> WorkTimeOfTypes { get; set; }
        public IEnumerable<DepartmentToCompany> DepartmentToCompanies { get; set; }
        public IEnumerable<CommandsToEmployee> CommandsToEmployees { get; set; }
        public CommandsToEmployee CommandsToEmployee { get; set; }
        public Emplooyee Emplooyee { get; set; }
        public Emplooyee EmplooyeeDetailScan { get; set; }
        public Commands Commands { get; set; }
        public WorkBookAddition WorkBookAddition { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa işçi seçin!")]
        public int? EmplooyeeId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa iş növünü seçin!")]
        public int? WorkTimeOfTypeId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa vəzifəni seçin!")]
        public int? PositionId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa maaşı seçin!")]
        public decimal? Salary { get; set; }
        public WorkTimeOfType WorkTimeOfType { get; set; }
        public TaxBreakToEmplooyee TaxBreakToEmplooyee { get; set; }
        public IEnumerable<SubDepartment> SubDepartments { get; set; }
        public IEnumerable<Position> Positions { get; set; }
        public int CommandInEmpId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa iş növünü seçin!")]
        public int WorkPlace { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa səbəbi qeyd edin")]
        public string Reason { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Zəhmət olmasa qəbul vaxtını seçin!")]
        public DateTime CreatedDate { get; set; }
        public ScanPdfCommands ScanPdfCommands { get; set; }

    }
}
