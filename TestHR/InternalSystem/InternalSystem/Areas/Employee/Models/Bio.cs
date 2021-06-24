using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.Models
{
    public class Bio
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public int CompaniesId { get; set; }
    }
}
