using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class PhoneNumberToEmployee
    {
        public int Id { get; set; }
        public int EmplooyeeID { get; set; }
        public int PhoneNumberId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public virtual PhoneNumbers PhoneNumber { get; set; }
    }
}
