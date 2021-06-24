using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.DateOfTabel
{
    public class HolidayOfCalendar
    {
        public int Id { get; set; }
        public string HolidayName { get; set; }
        public DateTime? HolidayDate { get; set; }
        public int? CalendarId { get; set; }
        public virtual Calendar Calendar { get; set; }
        public bool Status { get; set; }
        public string UserName { get; set; }


    }
}
