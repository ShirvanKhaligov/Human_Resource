using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Permissions
{
    public class Permission
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa səbəb yazın!!!"),StringLength(500, ErrorMessage = "Simvol sayı 500-dən çox ola bilməz!")]
        public string Reason { get; set; }
        public DateTime CreatingTime { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime FromDateForHour { get; set; }
        public DateTime ToDate { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa icazənin növün seçin yazın!!!")]
        public int PermissionTypeId { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public virtual ICollection<PermissionToEmployeee> PermissionToEmployeees { get; set; }
        public bool Confirm { get; set; }
        public bool Cancel { get; set; }
       // public bool  IsArchive { get; set; }
    }
}
