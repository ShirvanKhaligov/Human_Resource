using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.ComputerSk;
using InternalSystem.Areas.InternalHR.Models.Education;
using InternalSystem.Areas.InternalHR.Models.Languages;
using InternalSystem.Areas.InternalHR.Models.Relations;
using Microsoft.AspNetCore.Http;

namespace InternalSystem.Areas.InternalHR.ViewModels
{
    public class RecruitmentCandidateVM
    {
        [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın")]
        public string IdCard { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın")]
        public string FinCode { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa xananı boş buraxmayın")]
        public string FatherName { get; set; }
        public IEnumerable<MillitaryRank> MillitaryRanks { get; set; }
        public IEnumerable<EducationsToEmployee> EducationsToEmployees { get; set; }
        public IEnumerable<EducationType> EducationTypes{ get; set; }
        public IEnumerable<EducationTypeToUnivercity> EducationTypeToUnivercities{ get; set; }
        public IEnumerable<EducationsToEmployee> EducationsToEmployeesForFalse { get; set; }
        public IEnumerable<Education> Educations{ get; set; }
        public IEnumerable<Universities> Universities{ get; set; }
        public IEnumerable<UniFaculty> UniFaculties{ get; set; }
        public IEnumerable<Profession> Professions{ get; set; }
        public IEnumerable<LanguageLevel> LanguageLevels{ get; set; }
        public IEnumerable<Language> Languages{ get; set; }
        public IEnumerable<Relations> Relationss{ get; set; }
        public IEnumerable<RelationToEmployee> RelationsForFalsee { get; set; }
        public IEnumerable<RelationType> RelationTypes{ get; set; }
        public IEnumerable<Emplooyee> Emplooyees{ get; set; }
        public IEnumerable<MillitaryStatus> MillitaryStatuses{ get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa şəkil seçin")]
        public IFormFile Photo  { get; set; }
        public IFormFile PhotoUpd  { get; set; }
        public IFormFile Word { get; set; }
        public IFormFile WordUpd { get; set; }
        public IFormFile Pdf { get; set; }
        public IFormFile PdfUpd { get; set; }
        public IFormFile PhotoCertificate { get; set; }
        public IFormFile PhotoCertificateUpd { get; set; }
        //[Required(ErrorMessage = "Zəhmət olmasa skan pdf faylını seçin")]
        public IFormFile ScanCommandPhoto { get; set; }
        public IFormFile ScanCommandPhotoUpdate { get; set; }
        public int? EducationTypeId { get; set; }
        public int? UniversityId { get; set; }
        public string EnterTime { get; set; }
        public string EndTime { get; set; }
        public int? FacultyId { get; set; }
        public int? ProfessionId { get; set; }
        public int? LanguageId { get; set; }
        public int? LanguageLevelId { get; set; }
        public AdditionalInfos AdditionalInfos { get; set; }
        public Relations Relations { get; set; }
        public EducationsToEmployee EducationsToEmployee { get; set; }
        public IEnumerable<ComputerLevels> ComputerLevels { get; set; }
        public IEnumerable<LanguageToLanguageLevel> LanguageToLanguageLevels { get; set; }
        //public IEnumerable<LanguageToLanguageLevel> LanguageToLanguageLevelsForFalse { get; set; }
        public IEnumerable<LanguageToEmployee> LanguageToEmployeesForFalse { get; set; }
        public IEnumerable<ComputerSkillToLevels> ComputerSkillToLevels { get; set; }
        //public IEnumerable<ComputerSkillToLevels> ComputerSkillToLevelsForFalse { get; set; }
        public IEnumerable<ComputerToEmployee> ComputerToEmployeesForFalse { get; set; }
        public AppUser AppUser { get; set; }
        public Emplooyee Emplooyee { get; set; }
        public IEnumerable<LanguageToEmployee> LanguageToEmployees { get; set; }
        public IEnumerable<ComputerToEmployee> ComputerToEmployees { get; set; }
        public IEnumerable<RelationToEmployee> RelationToEmployees { get; set; }
        public School School { get; set; }
        public int DepartmentId { get; set; }


    }
}
