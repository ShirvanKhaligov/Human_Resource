using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.BusinessTrip;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class BusinessTripVM
    {
        public ICollection<Emplooyee> Emplooyees { get; set; }
        public ICollection<BusinessTripEmp> BusinessTripEmps { get; set; }
        public IEnumerable<Distric> Districs { get; set; }
        //public class Districs
        //{
        //    GenericUriParser UriParser
        //}

        [Required]
        public DateTime FromDate { get; set; }
        [Required]

        public DateTime? ToDate { get; set; }
        public int DistricId { get; set; }
        public virtual Distric Distric { get; set; }
        public int EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        [Required]
        public string Commet { get; set; }
        [Required]
        public string PartnorName { get; set; }

    }
}
