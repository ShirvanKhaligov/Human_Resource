using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Languages
{
    public class LanguageToLanguageLevel
    {
        public int Id { get; set; }
        public int? LanguageLevelId { get; set; }
        public int? LanguageId { get; set; }
        public bool Status { get; set; }
        public virtual LanguageLevel LanguageLevel { get; set; }
        public virtual Language Language { get; set; }
        public virtual ICollection<LanguageToEmployee> LanguageToEmployees { get; set; }
    }
}
