using InternalSystem.Areas.InternalHR.Models.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class ScanPdfQuitWork
    {
        public int Id { get; set; }
        public string Pdf { get; set; }
        public int? CommandsToEmployeeId { get; set; }
        public virtual CommandsToEmployee CommandsToEmployee { get; set; }
    }
}
