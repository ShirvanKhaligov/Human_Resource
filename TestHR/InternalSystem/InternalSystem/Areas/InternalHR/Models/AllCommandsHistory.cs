using InternalSystem.Areas.InternalHR.Models.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class AllCommandsHistory
    {

        public int Id { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public int? CommandsToEmployeeId { get; set; }
        public virtual CommandsToEmployee CommandsToEmployee { get; set; }
        public string Pdf { get; set; }
        public int? PositionId { get; set; }
        //public virtual Position Position { get; set; }
        public int? WorkPlaceAdditionId { get; set; }
        //public virtual WorkPlaceAddition WorkPlaceAddition { get; set; }
        public int? WorkTimeOfTypeId { get; set; }
        //public virtual WorkTimeOfType WorkTimeOfType { get; set; }
        public decimal? Salary { get; set; }
        public string OldSurname { get; set; }
    }
}
