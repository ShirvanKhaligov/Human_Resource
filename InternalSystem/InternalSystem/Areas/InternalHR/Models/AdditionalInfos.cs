using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.InternalHR.Models;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class AdditionalInfos
    {
        public int Id { get; set; }
        //public string BankAccount { get; set; }
        //public string SSK { get; set; }
        //public string CorporateNumber { get; set; }
        public string MicrosoftWord { get; set; }
        public string AdobePdf { get; set; }
        public string AdditionCertImage { get; set; }
        public int EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee { get; set; }
    }
}
