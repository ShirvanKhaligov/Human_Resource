using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class WorkPlaceAddition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Emplooyee> Emplooyees { get; set; }
    }
}
