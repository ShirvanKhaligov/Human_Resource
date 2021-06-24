using InternalSystem.Areas.InternalHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class AbsenceVM
    {
        public Emplooyee Employee { get; set; }
        public Continuity Continuity { get; set; }
        public IEnumerable<Continuity> Continuities { get; set; }
        public IEnumerable<Emplooyee> Employees { get; set; }
    }
}
