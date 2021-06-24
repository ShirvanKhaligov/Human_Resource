using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.InternalHR.Enum;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class Continuity
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

        [EnumDataType(typeof(PermissionForAttendance))]
        public PermissionForAttendance PermissionType { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public int EmplooyeeId { get; set; }
        public string Reason { get; set; }
    }
}
