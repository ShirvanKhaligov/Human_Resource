using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Month
{
    public class Month
    {
        public int Id { get; set; }
        [Required]
        public string MonthName { get; set; }
        
        [Required]
        public int MonthNumber { get; set; }
        public DateTime? Date { get; set; }

        public virtual ICollection<YearToMonth> YearToMonths { get; set; }


    }
}
