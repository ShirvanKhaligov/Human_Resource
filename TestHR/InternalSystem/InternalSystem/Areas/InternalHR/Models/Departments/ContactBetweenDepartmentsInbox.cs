using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Departments
{
    public class ContactBetweenDepartmentsInbox
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Answer { get; set; }
        public bool isRead { get; set; }
        public bool Status { get; set; }
        public DateTime DeletedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
