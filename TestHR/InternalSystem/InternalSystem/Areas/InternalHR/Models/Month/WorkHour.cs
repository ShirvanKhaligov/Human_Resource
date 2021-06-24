using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Month
{
    public class WorkHour
    {
        public uint Id { get; set; }
        [Required]
        public int  Year { get; set; }
        public DateTime? YearDate { get; set; }
        [Required]
        public int Month { get; set; }
        public DateTime? MonthDate { get; set; }
        [Required]
        public string MonthName { get; set; }
        public int Hour { get; set; }



    }
}
