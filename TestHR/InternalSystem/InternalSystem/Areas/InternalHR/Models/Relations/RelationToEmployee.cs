using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Relations
{
    public class RelationToEmployee
    {
        public int Id { get; set; }
        public int EmplooyeeId { get; set; }
        public int RelationId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public virtual Relations Relation { get; set; }

    }
}
