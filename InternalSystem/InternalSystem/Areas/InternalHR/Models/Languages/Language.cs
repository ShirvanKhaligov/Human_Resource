using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Languages
{
    public class Language
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Hərf sayı ən az 1 və ən çox  50 den olamalıdır")]
        public string Name { get; set; }
        public virtual ICollection<LanguageToLanguageLevel> LanguageToLanguageLevels { get; set; }
        //public virtual ICollection<LanguageToEmployee> LanguageToEmployees { get; set; }


    }
}
