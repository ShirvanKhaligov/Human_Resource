
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Education
{
    public class EducationTypeToUnivercity
    {
        public int Id { get; set; }
        public int? EducationTypeId { get; set; }
        public virtual EducationType EducationType { get; set; }
        public int? UniversitiesId { get; set; }
        public virtual Universities Universities { get; set; }

    }
}
