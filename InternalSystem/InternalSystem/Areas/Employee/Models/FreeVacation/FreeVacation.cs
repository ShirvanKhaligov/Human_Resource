using InternalSystem.Areas.InternalHR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.Models.FreeVacation
{
    public class FreeVacation
    {
        public int Id { get; set; }
        public int FreeVacationTypeId { get; set; }
        public virtual FreeVacationType FreeVacationType { get; set; }
        public string Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public DateTime? ExecTime { get; set; }
        public string CreaterUser { get; set; }
    }
    public class FreeVacationType
    {
        public int Id { get; set; }
        [Required]
        public string TypeName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<FreeVacation> FreeVacations { get; set; }

    }
}
