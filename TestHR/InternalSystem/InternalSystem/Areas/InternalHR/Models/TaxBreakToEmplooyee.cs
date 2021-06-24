using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class TaxBreakToEmplooyee
    {
        public int Id { get; set; }
        public int? TaxBreakId { get; set; }
        public virtual TaxBreak TaxBreak { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
    }
}
