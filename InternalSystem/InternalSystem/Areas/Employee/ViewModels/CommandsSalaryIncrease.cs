using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class CommandsSalaryIncrease
    {
        public IEnumerable<Emplooyee> Emplooyees { get; set; }
        public IEnumerable<CommandsToEmployee> CommandsToEmployees { get; set; }
        public Commands Commands { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa vaxtı seçin")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa maaşı təyin edin")]
        public decimal? NewSalary { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa işçi seçin")]
        public int EmplooyeeId { get; set; }
        public string Description { get; set; }
        public Emplooyee Emplooyee { get; set; }
        public CommandsToEmployee CommandsToEmployee { get; set; }
        public OldSalary OldSalary { get; set; }

    }
}
