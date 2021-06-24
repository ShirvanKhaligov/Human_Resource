using InternalSystem.Areas.InternalHR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class MessagesForAllVM
    {
        [Required(ErrorMessage = "Zəhmət olmasa şirkəti  seçin!!")]
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa mesaj daxil edin!!")]
        public string Message { get; set; }
        public int Id { get; set; }
        public IEnumerable<Emplooyee> Emplooyees { get; set; }
        public IEnumerable<Companies> Companiess { get; set; }
        public string Image { get; set; }
        public bool IsDelete { get; set; }
        public bool Status { get; set; }
        public int EmployeeId { get; set; }
        public virtual Emplooyee Employee { get; set; }
        public IEnumerable<TelMe> TelMes { get; set; }
        public TelMe TelMe { get; set; }

    }
}
