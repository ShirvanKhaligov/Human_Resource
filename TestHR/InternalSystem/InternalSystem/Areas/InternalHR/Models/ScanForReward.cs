using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class ScanForReward
    {

        public int Id { get; set; }
        public string Pdf { get; set; }
        public int? RewardToEmployeeId { get; set; }
        public virtual RewardToEmployee RewardToEmployee { get; set; }


    }
}
