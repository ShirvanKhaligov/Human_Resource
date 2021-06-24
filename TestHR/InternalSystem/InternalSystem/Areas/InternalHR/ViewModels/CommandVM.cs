using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.Departments;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class CommandVM
    {
        public IEnumerable<Emplooyee> Employees { get; set; }
        public Emplooyee Employee { get; set; }
        public IEnumerable<SubDepartment> SubDepartments { get; set; }
        public IEnumerable<Commands> Commands { get; set; }
        public IEnumerable<CommandsToEmployee> CommandsToEmployees { get; set; }
        public IEnumerable<Position> Positions { get; set; }
        public IEnumerable<Companies> Companies { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<DepartmentToCompany> DepartmentToCompanies { get; set; }
        public Commands Command { get; set; }
        public Position Position { get; set; }
        [Required(ErrorMessage= "Zəhmət olmasa işçi seçin!!")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa əmr seçin!!")]
        public int CommandId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa vəzifə seçin!!")]
        public int? PositionId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SubDepartmentId { get; set; }
        public decimal? Salary { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa mövzunu silməyin seçin!!"),MinLength(20)]
        public string Description { get; set; }
        public string CommandName { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa şifrə daxil edin!!")]
        public string Password { get; set; }
        public int CommandInEmpId { get; set; }
    }
}
