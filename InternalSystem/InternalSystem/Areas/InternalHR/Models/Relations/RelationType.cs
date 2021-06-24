using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Relations
{
    public class RelationType
    {
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Simvol sayı 50-dən çox ola bilməz!")]
        public string Name { get; set; }
        public virtual ICollection<Relations> Relations { get; set; }
    }
}
