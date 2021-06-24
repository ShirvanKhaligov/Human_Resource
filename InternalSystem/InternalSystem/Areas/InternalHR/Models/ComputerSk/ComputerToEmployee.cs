using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.ComputerSk
{
    public class ComputerToEmployee
    {
        public int Id { get; set; }
        public int EmplooyeeId { get; set; }
        public int ComputerSkillToLevelsId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public virtual ComputerSkillToLevels ComputerSkillToLevels { get; set; }
    }
}
