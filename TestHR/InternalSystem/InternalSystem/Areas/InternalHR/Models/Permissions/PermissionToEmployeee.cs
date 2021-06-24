using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Permissions
{
    public class PermissionToEmployeee
    {
        public int Id { get; set; }
        public int PermissionId { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }

    }
}
