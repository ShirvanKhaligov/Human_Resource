using InternalSystem.Areas.InternalHR.Models;
using System;

namespace InternalSystem.Areas.Employee.Models.Vacation
{
    public class Vacation
    {
        public int Id { get; set; }
        public int VacationTypeId { get; set; }
        public virtual VacationType VacationType { get; set; }
        public string Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; } 


    }
}
