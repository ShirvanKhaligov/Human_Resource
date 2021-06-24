using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class ScanPdfCommands
    {

        public int Id { get; set; }
        public string Pdf { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public string CommandsName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime Exetime { get; set; }
    }
}
