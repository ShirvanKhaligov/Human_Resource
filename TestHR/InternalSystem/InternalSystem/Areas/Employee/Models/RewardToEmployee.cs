using System;
using System.Collections.Generic;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class RewardToEmployee
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime TimeOfExecution { get; set; }
        public int? EmplooyeeId { get; set; }
        public int RewardId { get; set; }
        public decimal Money{ get; set; }
        public virtual Reward Reward { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
        public string Reason { get; set; }
        public virtual ICollection <ScanForReward> ScanForRewards { get; set; }
        public bool Status { get; set; }
        public int customid { get; set; }

    }
}