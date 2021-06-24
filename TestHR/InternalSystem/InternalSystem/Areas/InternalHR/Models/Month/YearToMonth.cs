using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Month
{
    public class YearToMonth
    {
        public int Id { get; set; }
        public int MonthId { get; set; }
        public int YearId { get; set; }
        public virtual Month Month { get; set; }
        public virtual Year Year { get; set; }

    }
}
