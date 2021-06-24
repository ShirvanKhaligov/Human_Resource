using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.Departments;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.InternalHR.Models;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class CommanEmployeeVM
    {
        public IEnumerable<Emplooyee> Employees { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa işçi seçin!!")]
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
        [Required(ErrorMessage = "Zəhmət olmasa işçi seçin!!")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa əmr seçin!!")]
        public int CommandId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa vəzifəni seçin!!")]
        public int? PositionId { get; set; }
        public int? DepartmentId { get; set; }
        public int? SubDepartmentId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa seçin")]
        public decimal? Salary { get; set; }
        //[Required(ErrorMessage = "Zəhmət olmasa mövzunu silməyin seçin!!"), MinLength(20)]
        //public string Description { get; set; }
        public string CommandName { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa şifrə daxil edin!!")]
        public string Password { get; set; }
        public int CommandInEmpId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa iş növünü seçin!!")]
        public int? WorkTimeOfTypeId { get; set; }
        public int? TaxBreakId { get; set; }
        public SubDepartment SubDepartment { get; set; }
        public IEnumerable<WorkTimeOfType> WorkTimeOfTypes { get; set; }
        //[Required(ErrorMessage = "Zəhmət olmasa seçin")]
        //public WorkTimeOfType WorkTimeOfType { get; set; }
        //public TaxBreak TaxBreak { get; set; }
        public IEnumerable<TaxBreak> TaxBreaks  { get; set; }
        public WorkPlaceAddition WorkPlaceAddition { get; set; }
        public WorkBookAddition WorkBookAddition { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa seçin")]
        public string WorkPlace { get; set; }
    }
}
