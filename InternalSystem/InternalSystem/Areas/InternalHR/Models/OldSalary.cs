using InternalSystem.Areas.InternalHR.Models.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class OldSalary
    {

        public int Id { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public int? CommandsToEmployeeId { get; set; }
        public virtual CommandsToEmployee CommandsToEmployee { get; set; }
        public decimal? Salary { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public DateTime ExeTime { get; set; }


    }
}
