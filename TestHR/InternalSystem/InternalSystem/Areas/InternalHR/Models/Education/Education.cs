using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Education
{
    public class Education
    {
        public int Id { get; set; }
        public DateTime EnteringTime { get; set; }
        public DateTime FinishTime { get; set; }
        public virtual ICollection<EducationsToEmployee> EducationsToEmployee { get; set; }
        public int? ProfessionId { get; set; }
        public virtual Profession Profession { get; set; }
        public bool Status { get; set; }
        public int? AcceptHoney { get; set; }
    }
}
