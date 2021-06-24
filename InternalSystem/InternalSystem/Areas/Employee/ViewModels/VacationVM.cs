using InternalSystem.Areas.Employee.Models.Vacation;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using System;
//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class VacationVM
    {
        public System.Collections.Generic.IEnumerable<Emplooyee> Emplooyees { get; set; }
        public System.Collections.Generic.IEnumerable<Vacation> Vacations { get; set; }
        public Vacation Vacation { get; set; }
        public Emplooyee Emplooyee { get; set; }
        public System.Collections.Generic.IEnumerable<CommandsToEmployee> CommandsToEmployees { get; set; }
        public CommandsToEmployee CommandsToEmployee { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa işçi seçin!")]
        public int? EmplooyeeId { get; set; }
        //public 
        public int VacationTypeId { get; set; }
        public virtual VacationType VacationType { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa başlama tarixini seçin")]
        public DateTime FromDate { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa bitmə tarixini seçin")]
        public DateTime ToDate { get; set; }


    }
}
