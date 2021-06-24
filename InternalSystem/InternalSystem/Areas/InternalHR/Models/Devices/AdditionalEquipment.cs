using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Devices
{
    public class AdditionalEquipment
    {
        public int Id { get; set; }
        public string EquipmentName { get; set; }
        public int EquipmentCount { get; set; }
        public virtual ICollection<Device> Devices { get; set; }

    }
}
