using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Month
{
    public class WorkDates
    {
        public int Id { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public bool IsSpecialDay { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        public TimeSpan StartTime { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        public TimeSpan EndTime { get; set; }
        public virtual ICollection<WorkDateToEmployee> WorkDateToEmployees { get; set; }
    }
}
