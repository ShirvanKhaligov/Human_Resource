using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Commands
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
       public virtual ICollection<CommandsToEmployee> CommandsToEmployees { get; set; }
    }
}
