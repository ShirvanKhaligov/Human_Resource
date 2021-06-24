using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.BusinessTrip
{
    public class BusinessTripEmp
    {
        public int Id { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int DistricId { get; set; }
        public virtual Distric Distric { get; set; }
        public int EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public string Commet { get; set; }
        public string PartnorName { get; set; }
        public  DateTime Exectime { get; set; }
        public string CreaterUser { get; set; }
        public bool Isdeleted { get; set; }


    }
}
