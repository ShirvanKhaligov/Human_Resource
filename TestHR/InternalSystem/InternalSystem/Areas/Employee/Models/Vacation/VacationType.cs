using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternalSystem.Areas.Employee.Models.Vacation
{
    public class VacationType
    {
        public int Id { get; set; }
        [Required]
        public string TypeName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Vacation> Vacations { get; set; }

    }
}
