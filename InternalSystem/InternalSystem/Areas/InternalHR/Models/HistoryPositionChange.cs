using InternalSystem.Areas.InternalHR.Models.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class HistoryPositionChange
    {

        public int Id { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public int CommandsToEmployeeId { get; set; }
        public virtual CommandsToEmployee CommandsToEmployee { get; set; }
        public int? PositionId { get; set; }
       
        public int? WorkPlaceAdditionId { get; set; }
        
        public int? WorkTimeOfTypeId { get; set; }
      
        public decimal? Salary { get; set; }

    }
}
