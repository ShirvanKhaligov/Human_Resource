using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternalSystem.Areas.InternalHR.Models.BusinessTrip
{
    public class Distric
    {
        public int Id { get; set; }
        [Required]
        public string DistricName { get; set; }
        public virtual ICollection<BusinessTripEmp> BusinessTrips { get; set; }


    }
}
