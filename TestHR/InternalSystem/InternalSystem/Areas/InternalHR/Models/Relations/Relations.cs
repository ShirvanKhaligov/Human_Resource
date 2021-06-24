using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Models.Relations
{
    public class Relations
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "Ad 50 hərfdən böyük ola bilməz!"), MinLength(2, ErrorMessage = "2 hərfdən az Ad ola bilməz!")]
        public string Name { get; set; }
        [MaxLength(50, ErrorMessage = "Soyad 50 hərfdən böyük ola bilməz!"), MinLength(2, ErrorMessage = "2 hərfdən az Soyad ola bilməz!")]
        public string Surname { get; set; }
        [MaxLength(50, ErrorMessage = "Ad 50 hərfdən böyük ola bilməz!"), MinLength(2, ErrorMessage = "2 hərfdən az Ad ola bilməz!")]
        public string FatherName { get; set; }
        [MaxLength(25, ErrorMessage = "Nömrə 12 simvoldan böyük ola bilməz!"), MinLength(2, ErrorMessage = "Nömrə 9 simvoldan kiçik ola bilməz!")]
        public string Number { get; set; }
        [MaxLength(255, ErrorMessage = "Simvol 255 simvoldan böyük ola bilməz!")]
        public string Adress { get; set; }
        [MaxLength(255, ErrorMessage = "Simvol 255 simvoldan böyük ola bilməz!")]
        public string WorkPlaceName { get; set; }
        [MaxLength(255, ErrorMessage = "Simvol 255 simvoldan böyük ola bilməz!")]
        public string WorkPlacePositionName { get; set; }
        public bool Status { get; set; }
        public int? RelationTypeId { get; set; }
        public virtual RelationType RelationType { get; set; }
        public virtual ICollection<RelationToEmployee> RelationToEmployees { get; set; }
    }
}
