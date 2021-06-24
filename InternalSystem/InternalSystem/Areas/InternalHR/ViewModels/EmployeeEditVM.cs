using InternalSystem.Areas.InternalHR.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class EmployeeEditVM
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50, ErrorMessage = "Ad 50 hərfdən böyük ola bilməz!"), MinLength(2, ErrorMessage = "2 hərfdən az Ad ola bilməz!")]
        public string FirstName { get; set; }
        [Required, MaxLength(50, ErrorMessage = "Soyad 50 hərfdən böyük ola bilməz!"), MinLength(2, ErrorMessage = "2 hərfdən az Soyad ola bilməz!")]
        public string Lastname { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Ata adı 50 hərfdən böyük ola bilməz!"), MinLength(2, ErrorMessage = "2 hərfdən az ad ola bilməz!")]
        public string FatherName { get; set; }
        [MaxLength(15, ErrorMessage = "Seriya nömrə 15 hərfdən böyük ola bilməz!"), MinLength(6, ErrorMessage = "6 hərfdən az seriya ola bilməz!")]
        public int IdCard { get; set; }
        [Required, MaxLength(8, ErrorMessage = "Fin nömrə 8 hərfdən böyük ola bilməz!"), MinLength(6, ErrorMessage = "6 hərfdən az Fin ola bilməz!")]
        public string FinCode { get; set; }
        [Required(ErrorMessage = "Bu sahəni doldurmalısınlız!"), StringLength(255, ErrorMessage = "Simvol sayı 255-dən çox ola bilməz!")]
        public string Image { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile PhotoUpdate { get; set; }
        [Required, StringLength(255, ErrorMessage = "Simvol sayı 255-dən çox ola bilməz!")]
        public string LivingAdress { get; set; }
        [Required, StringLength(255, ErrorMessage = "Simvol sayı 255-dən çox ola bilməz!")]
        public string BirthPlace { get; set; }
        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }
        public int MarialstatusId { get; set; }
        public virtual MarialStatus Marialstatus { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public string Birthday { get; set; }
        public IEnumerable<Emplooyee> Emplooyees { get; set; }

    }
}
