using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternalSystem.Areas.InternalHR.Models.Education
{
    public class EducationType
    {
        public EducationType()
        {
            //Educations = new HashSet<Education>();
            //Universities = new HashSet<Universities>();
            //Collages = new HashSet<Collage>();
            //HighSchools = new HashSet<HighSchool>();
            Schools = new HashSet<School>();
            EducationTypeToUnivercities = new HashSet<EducationTypeToUnivercity>();
        }
        public int Id { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "Hərf sayı ən az 1 və ən çox  50  olmalıdır"), MaxLength(50, ErrorMessage = "Hərf sayı ən az 1 və ən çox  50   olmalıdır")]
        public string Name { get; set; }            
        public bool Status { get; set; }            
        //public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<EducationTypeToUnivercity> EducationTypeToUnivercities { get; set; }
        public virtual ICollection<School> Schools { get; set; }
        //public virtual ICollection<Collage> Collages { get; set; }
        //public virtual ICollection<HighSchool> HighSchools { get; set; }

    }
}
