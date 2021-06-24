using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.ComputerSk
{
    public class ComputerSkillsName
    {
        public int Id { get; set; }
        [Required]
        [StringLength(300, ErrorMessage = "Hərf sayı ən az 1 və ən çox  300 den olamalıdır")]
        public string Name { get; set; }
        public virtual ICollection<ComputerSkillToLevels> ComputerSkillToLevels { get; set; }
    }
}
