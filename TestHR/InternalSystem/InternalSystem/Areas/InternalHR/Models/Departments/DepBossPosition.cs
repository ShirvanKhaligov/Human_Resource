using InternalSystem.Areas.InternalHR.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Departments
{
    public class DepBossPosition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? DepartmentToCompanyId { get; set; }
        public virtual DepartmentToCompany DepartmentToCompany { get; set; }
        //public bool HeadHrBoss { get; set; }
        public int? EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }

    }
}
