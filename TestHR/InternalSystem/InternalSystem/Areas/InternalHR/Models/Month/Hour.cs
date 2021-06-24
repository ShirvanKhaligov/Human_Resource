using InternalSystem.Areas.InternalHR.Models.Commands;
//using InternalSystem.Areas.InternalHR.Models.ComToHour;
using System.Collections.Generic;

namespace InternalSystem.Areas.InternalHR.Models.Month
{
    public class Hour
    {
        public int Id { get; set; }
        public int Hours { get; set; }
        public int YearToMonthId { get; set; }
        public virtual YearToMonth YearToMonth { get; set; }
       
         public virtual ICollection<CommandsToEmployee> CommandsToEmployees { get; set; }




    }
}
