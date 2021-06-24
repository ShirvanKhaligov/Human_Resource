using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Permissions
{
    public class Explanation
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Zəhmət olmasa səbəb yazın!!!"), StringLength(120, ErrorMessage = "Simvol sayı 120-dən çox ola bilməz!")]
        public string Reason { get; set; }
        public DateTime CreatingTime { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime FromDateForHour { get; set; }
        public DateTime ToDate { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa icazənin növün seçin yazın!!!")]
        public int PermissionTypeId { get; set; }


        public string Description { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public virtual ICollection<ExplanationToEmployee> ExplanationToEmployees { get; set; }

        public DateTime ExeTime { get; set; }



       // public bool IsArchive { get; set; }




    }
}
