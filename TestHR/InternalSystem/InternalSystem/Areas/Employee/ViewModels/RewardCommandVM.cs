using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.Departments;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class RewardCommandVM
    {
        public IEnumerable<Emplooyee> Emplooyees { get; set; }
        public IEnumerable<DepartmentToCompany> DepartmentToCompanies { get; set; }
        public IEnumerable<CommandsToEmployee> CommandsToEmployees { get; set; }
        public IEnumerable<RewardToEmployee> RewardToEmployees { get; set; }
        public CommandsToEmployee CommandsToEmployee { get; set; }
        public RewardToEmployee RewardToEmployee { get; set; }
        public ScanForReward ScanForReward { get; set; }
        public Reward Reward { get; set; }
        public IEnumerable<SubDepartment> SubDepartments { get; set; }
        public IEnumerable<Position> Positions { get; set; }
        public Emplooyee Emplooyee { get; set; }
        public Emplooyee EmplooyeeDetailScan { get; set; }
        public Commands Commands { get; set; }
        public WorkBookAddition WorkBookAddition { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa işçi seçin!")]
        public int? EmplooyeeId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Zəhmət olmasa qəbul vaxtını seçin!")]
        public DateTime CreatedDate { get; set; }
        public string Reason { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa məbləği qeyd edin")]
        public decimal Money { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa pdf faylı seçin")]
        public IFormFile ScanRward { get; set; }
    }
}
