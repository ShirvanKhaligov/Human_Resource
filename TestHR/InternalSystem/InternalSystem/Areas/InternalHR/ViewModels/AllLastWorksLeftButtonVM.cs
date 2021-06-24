using InternalSystem.Areas.InternalHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class AllLastWorksLeftButtonVM
    {
        public List<LastWorkPlace> LastWorkPlaces { get; set; }
        public Emplooyee Emplooyees { get; set; }
    }
}
