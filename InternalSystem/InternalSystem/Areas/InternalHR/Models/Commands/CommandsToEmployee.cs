//using InternalSystem.Areas.InternalHR.Models.ComToHour;
using InternalSystem.Areas.InternalHR.Models.DateOfTabel;
using InternalSystem.Areas.InternalHR.Models.Month;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternalSystem.Areas.InternalHR.Models.Commands
{
    public class CommandsToEmployee
    {

        public int Id { get; set; }
        public int? EmplooyeeId { get; set; }
        public int CommandId { get; set; }
        public int? ItemId { get; set; }
        public int? CalendarId { get; set; }

        public virtual Emplooyee Emplooyee { get; set; }
        public virtual Commands Command { get; set; }
        public virtual Item Item { get; set; }
        public virtual Calendar Calendar { get; set; }

        public string Description { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa qəbul vaxtı seçin!")]
        public DateTime CreatedDate { get; set; }
        public DateTime TimeOfExecution { get; set; }
        public virtual ICollection<ScanPdfQuitWork> ScanPdfQuitWorks { get; set; }
        public virtual ICollection<HistoryPositionChange> HistoryPositionChanges { get; set; }
        public virtual ICollection<OldSalary> OldSalaries { get; set; }
        public virtual ICollection<AllCommandsHistory> AllCommandsHistories { get; set; }
        //public virtual Hour Hour { get; set; }
        // public virtual ICollection<CMDtoEMPTOHOUR> CMDtoEMPTOHOURs { get; set; }


    }
}
