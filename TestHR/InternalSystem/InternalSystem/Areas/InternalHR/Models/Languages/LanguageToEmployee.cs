using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Languages
{
    public class LanguageToEmployee
    {
        public int Id { get; set; }
        public int EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public int LanguageToLanguageLevelId { get; set; }
        public virtual LanguageToLanguageLevel LanguageToLanguageLevel { get; set; }


    }
}
