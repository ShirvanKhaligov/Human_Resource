using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class MillitaryRank //Rütbə
    {
        public int Id { get; set; }
        [Required, StringLength(50, ErrorMessage = "Simvol sayı 50-dən çox ola bilməz!")]
        public string Name { get; set; }
        //public int StatusId { get; set; }
        //public virtual MillitaryStatus Status { get; set; }
        public virtual ICollection<MillitaryStatus> MillitaryStatuses { get; set; }
    }
}
