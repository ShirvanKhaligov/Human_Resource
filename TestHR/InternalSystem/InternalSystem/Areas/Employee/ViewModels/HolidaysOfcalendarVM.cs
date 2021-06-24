using InternalSystem.Areas.InternalHR.Models.DateOfTabel;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class HolidaysOfcalendarVM
    {
        [Required(ErrorMessage ="Qeyri iş gününün məzmunu!")]
        public string HolidayName { get; set; }
        [Required(ErrorMessage = "Günü daxil edin!")]
        public DateTime? HolidayDate { get; set; }
        public int? CalendarId { get; set; }
        public virtual Calendar Calendar { get; set; }
        public bool Status { get; set; }
        public string UserName { get; set; }
        public IEnumerable<Calendar> Calendars { get; set; }
        public IEnumerable<HolidayOfCalendar> HolidayOfCalendars { get; set; }


    }
}
