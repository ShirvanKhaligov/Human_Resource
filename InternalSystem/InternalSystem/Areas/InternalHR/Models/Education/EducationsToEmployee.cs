using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Education
{
    public class EducationsToEmployee
    {
        public int Id { get; set; }
        public int EmplooyeeId { get; set; }
        public int EducationId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public virtual Education Education { get; set; }
    }
}
