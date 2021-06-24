using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.DemoEducation
{
    public class DemoEducationTypeToUniversity
    {
        public int Id { get; set; }
        public int DemoUniversityId { get; set; }
        public virtual Demouniversity DemoUniversity { get; set; }
        public int DemoEducatiopnTypeId { get; set; }
        public virtual DemoEducatiopnType DemoEducatiopnType { get; set; }

    }
}
