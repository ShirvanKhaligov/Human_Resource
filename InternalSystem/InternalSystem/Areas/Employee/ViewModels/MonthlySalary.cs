using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.DateOfTabel;
//using InternalSystem.Areas.InternalHR.Models.ComToHour;
using InternalSystem.Areas.InternalHR.Models.Month;
using System.Collections.Generic;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class MonthlySalary
    {
        public IEnumerable<Emplooyee> Employees { get; set; }
        public IEnumerable<HolidayOfCalendar> HolidayOfCalendars { get; set; }
        public IEnumerable<Calendar> Calendars { get; set; }
        public HolidayOfCalendar HolidayOfCalendar { get; set; }
        public Calendar Calendar { get; set; }
        public IEnumerable<CommandsToEmployee> CommandsToEmployees { get; set; }
        public IEnumerable<Commands> GetCommands { get; set; }
        public IEnumerable<YearToMonth> YearToMonths { get; set; }
        public CommandsToEmployee CommandsToEmployee { get; set; }
        public IEnumerable<Hour> Hours { get; set; }
       // public IEnumerable<CMDtoEMPTOHOUR> CMDtoEMPTOHOURs { get; set; }
       // public CMDtoEMPTOHOUR CMDtoEMPTOHOUR { get; set; }
        public Hour Hour { get; set; }
        public YearToMonth YearToMonth { get; set; }

    }
}
