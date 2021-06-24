using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.ComputerSk
{
    public class ComputerSkillToLevels
    {
        public int Id { get; set; }
        public int? ComputerLevelsId { get; set; }
        public int ComputerSkillsNameId { get; set; }
        public bool Status { get; set; }
        public virtual ComputerLevels ComputerLevels { get; set; }
        public virtual ComputerSkillsName ComputerSkillsName { get; set; }
        public virtual ICollection<ComputerToEmployee> ComputerToEmployees { get; set; }
    }
}
