using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Departments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class DepContactVM
    {
        [Required(ErrorMessage ="Zəhmət olmasa şöbə müdiri seçin!!")]
        public int DepBossId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa mövzu daxil edin!!")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa mesaj daxil edin!!")]
        public string Message { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa cavab daxil edin!!")]
        public string Answer { get; set; }
        public string From { get; set; }
        public int Id { get; set; }
        public IEnumerable<Emplooyee> DepartmentBosses { get; set; }
        public IEnumerable<DepartmentToCompany> DepartmentBoss { get; set; }
    }

}
