using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Month
{
    public class WorkDateToEmployee
    {
        public int Id { get; set; }
        public int? WorkDatesId { get; set; }
        public virtual WorkDates WorkDates { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual  Emplooyee Emplooyee { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        public TimeSpan StartTime { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        public TimeSpan EndTime { get; set; }
    }
}
