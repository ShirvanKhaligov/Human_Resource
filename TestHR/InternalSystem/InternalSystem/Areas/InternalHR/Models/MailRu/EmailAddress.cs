using InternalSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.MailRu
{
    public class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public AppUser appUser { get; set; }
    }
}
