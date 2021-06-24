using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Education;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class PractitionerVM
    {
        public IEnumerable<EducationTypeToUnivercity> EducationTypeToUnivercities { get; set; }
        public IEnumerable<Gender> Genders { get; set; }
        public IEnumerable<MarialStatus> MarialStatuses { get; set; }
        public IEnumerable<EducationType> EducationTypes { get; set; }
        public Emplooyee Emplooyee { get; set; }
        public PhoneNumbers PhoneNumbers { get; set; }
        public School School { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa təhsil növünü seçin")]
        public int? EduTypeId { get; set; }
        public int? UniId { get; set; }
        public int? FacId { get; set; }
        public int? ProfId { get; set; }
        public int MarialStatusId { get; set; }
        public int GenderId { get; set; }
        //[Required(ErrorMessage = "Zəhmət olmasa orta məktəbi qeyd edin")]
        //public string SchoolName { get; set; }
        public IEnumerable<UniFaculty> UniFaculties { get; set; }
        public IEnumerable<Universities> Universities { get; set; }
        public IEnumerable<Profession> Professions { get; set; }
        public Education Education { get; set; }
        public PhoneNumberToEmployee PhoneNumberToEmployee { get; set; }
        public EducationsToEmployee EducationsToEmployee { get; set; }

    }
}
