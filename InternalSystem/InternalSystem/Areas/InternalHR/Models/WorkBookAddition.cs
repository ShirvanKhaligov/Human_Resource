using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class WorkBookAddition
    {
        public int Id { get; set; }
        [StringLength(25, ErrorMessage = "Əmək k. nömrəsi 25 hərfdən artıq ola bilməz")]
        public string WorkbookNumber { get; set; }
        [StringLength(25, ErrorMessage = "Müqavilə nömrəsi 25 hərfdən artıq ola bilməz")]
        public string ContractNumber { get; set; }
        [StringLength(35, ErrorMessage = "SSN 35 hərfdən artıq ola bilməz")]
        public string SSNNumber { get; set; }
        public virtual ICollection<Emplooyee> Emplooyees { get; set; }
    }
}
