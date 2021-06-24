using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class MillitaryStatus
    {
        public int Id { get; set; }
        [Required, StringLength(50, ErrorMessage = "Simvol sayı 50-dən çox ola bilməz!")]
        public string Name { get; set; }
        //public int EmplooyeeId { get; set; }
        //public virtual Emplooyee Emplooyee { get; set; }
        public int? MillitaryRankId { get; set; }
        public virtual MillitaryRank MillitaryRank { get; set; }
        public virtual ICollection<Emplooyee> Emplooyees { get; set; }
    }
}
