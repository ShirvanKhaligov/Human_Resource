using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class TaxBreak
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TaxBreakToEmplooyee> TaxBreakToEmplooyees { get; set; }

    }
}
