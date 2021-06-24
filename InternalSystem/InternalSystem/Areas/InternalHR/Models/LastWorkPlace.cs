using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class LastWorkPlace
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa xananı doldurun")]
        [StringLength(250, ErrorMessage = "Simvol sayı 250 hərfdən böyük ola bilməz")]
        [MinLength(2, ErrorMessage = "Şirkət adı  2 Simvoldan çox ola bilməz!")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa başlama tarixin seçin")]
        public DateTime WhenStarted { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa çıxma tarixin seçin")]
        public DateTime WhenLeft { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa xananı doldurun")]
        [StringLength(250,ErrorMessage = "Simvol sayı 250 hərfdən böyük ola bilməz")]
        [MinLength(2, ErrorMessage = "Simvol sayı 2 hərfdən az  ola bilməz!")]
        public string PositionName { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa xananı doldurun")]
        [StringLength(300, ErrorMessage = "Simvol sayı 300 hərfdən böyük ola bilməz")]
        [MinLength(2, ErrorMessage = "Səbəb 2 hərfdən az  ola bilməz!")]
        public string Reason { get; set; }
        public bool Status { get; set; }
        //[Required(ErrorMessage = "Zəhmət olmasa xananı doldurun!!")]
        [RegularExpression("[0-9]+([.][0-9]+)?",ErrorMessage = "Zəhmət olmasa düzgün daxil edin")]
        public string Salary { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa xananı doldurun")]
        public string WorkType { get; set; }
        public string ReasonType { get; set; }
        public int EmplooyeeId { get; set; }
        public virtual Emplooyee Emplooyee  { get; set; }
    }
}
