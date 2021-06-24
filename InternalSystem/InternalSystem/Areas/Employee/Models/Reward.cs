using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class Reward
    {
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Simvol sayı 50-dən çox ola bilməz!")]
        public string Name { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<RewardToEmployee> RewardToEmployees { get; set; }
     



    }


}
