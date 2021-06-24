using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using System.Collections.Generic;

namespace InternalSystem.Areas.Employee.ViewModels
{
    public class ReminderVacationVM
    {
        public IEnumerable<Emplooyee> Emplooyees { get; set; }
        public Emplooyee Emplooyee { get; set; }

        public IEnumerable<CommandsToEmployee> CommandsToEmployees { get; set; }
        public CommandsToEmployee  CommandsToEmployee { get; set; }

    }
}
