using InternalSystem.Areas.InternalHR.Models.Commands;
using System;
using System.Collections.Generic;

namespace InternalSystem.Areas.InternalHR.Models.DateOfTabel
{
    public class Calendar
    {
        public int Id { get; set; }
        public string CalendarName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? GeneralWorkHour { get; set; }
        public int? NormativeDay { get; set; }
        public virtual ICollection<CommandsToEmployee> CommandsToEmployees { get; set; }

    }
}
