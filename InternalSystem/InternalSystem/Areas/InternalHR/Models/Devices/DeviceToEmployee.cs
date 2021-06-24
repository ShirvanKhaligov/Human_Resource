using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Devices
{
    public class DeviceToEmployee
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual Device Device { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
    }
}
