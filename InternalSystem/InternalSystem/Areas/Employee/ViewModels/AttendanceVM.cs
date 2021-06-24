using InternalSystem.Areas.Employee.Models.FreeVacation;
using InternalSystem.Areas.Employee.Models.Vacation;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.BusinessTrip;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.DateOfTabel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class AttendanceVM
    {
        public AttendanceVM()
        {
            Vacations = new List<Vacation>();
            BusinessTripEmps = new List<BusinessTripEmp>();
            FreeVacations = new List<FreeVacation>();
        } 
        public IEnumerable<Emplooyee> Emplooyees { get; set; }
        public List<Vacation> Vacations { get; set; }
        public List<BusinessTripEmp> BusinessTripEmps { get; set; }
        public List<FreeVacation> FreeVacations { get; set; }
        public FreeVacation FreeVacation { get; set; }

        public BusinessTripEmp BusinessTripEmp { get; set; }
        public Vacation Vacation { get; set; }
        public VacationType VacationType { get; set; }
        public Emplooyee Emplooyee { get; set; }
        public WorkTimeOfType WorkTimeOfType { get; set; }
        public IEnumerable<WorkTimeOfType> WorkTimeOfTypes { get; set; }
        public IEnumerable<CommandsToEmployee> CommandsToEmployees { get; set; }
        public IEnumerable<Calendar> Calendars { get; set; }
        public Calendar Calendar { get; set; }
        public HolidayOfCalendar HolidayOfCalendar { get; set; }
        public IEnumerable<HolidayOfCalendar> HolidayOfCalendars { get; set; }
    }
}
