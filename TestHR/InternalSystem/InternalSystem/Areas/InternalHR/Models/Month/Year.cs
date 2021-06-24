using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Month
{
    public class Year
    {
        public int Id { get; set; }
        public int Years { get; set; }
        public DateTime? Date { get; set; }
        public virtual ICollection<YearToMonth> YearToMonths { get; set; }




    }
}
