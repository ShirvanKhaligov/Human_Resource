using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.DateOfTabel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class CalendarVm
    {
        [Required(ErrorMessage ="Ayın adını daxil edin")]
        public string CalendarName { get; set; }
        [Required(ErrorMessage ="Başlanğıc tarixi seçin!")]
        public DateTime FromDate { get; set; }
        [Required(ErrorMessage = "Son tarixi seçin!")]
        public DateTime ToDate { get; set; }
        [Required(ErrorMessage ="Ümumi saatı daxil edin")]
        public int? GeneralWorkHour { get; set; }
        [Required(ErrorMessage = "Normativ  gün sayını daxil edin")]
        public int? NormativeDay { get; set; }
        public ICollection<CommandsToEmployee> CommandsToEmployees { get; set; }
        public CommandsToEmployee CommandsToEmployee { get; set; }
        public IEnumerable<Calendar> Calendars { get; set; }
        public Calendar Calendar { get; set; }
    }
}
