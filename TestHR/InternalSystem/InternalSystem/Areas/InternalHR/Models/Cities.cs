using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models
{
    public class Cities
    {
        public int Id { get; set; }
        [Required, StringLength(50, ErrorMessage = "Simvol sayı 50-dən çox ola bilməz!")]
        public string Name { get; set; }
        public int CountriesId { get; set; }
        public virtual Countries Countries { get; set; }
        public bool status { get; set; }
    }
}
