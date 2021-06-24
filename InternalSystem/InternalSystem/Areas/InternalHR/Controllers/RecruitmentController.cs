using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.ComputerSk;
using InternalSystem.Areas.InternalHR.Models.Education;
using InternalSystem.Areas.InternalHR.Models.Languages;
using InternalSystem.Areas.InternalHR.Models.Relations;
using InternalSystem.Areas.InternalHR.ViewModels;
using InternalSystem.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Controllers
{
    [Area("InternalHR")]
    [Authorize(Roles = "HumanResource,HrDepartmentBoss")]
    public class RecruitmentController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<AppUser> _userManager;
        public RecruitmentController(InternalSysDBContext context, IHostingEnvironment env, UserManager<AppUser> userManager)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
        }

        public async Task<IActionResult> Create(int? id)
        {
            AppUser findCurrentHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            //image hr
            //ViewData["image_hr"] = findCurrentHR.Image;
            //ViewData["name_hr"] = findCurrentHR.Name + " " + findCurrentHR.Surname;
            //ViewData["company_image_hr"] = findCurrentHR.Companies.Image;
            //
            if (id == null) return NotFound();
                RecruitmentCandidateVM vM = new RecruitmentCandidateVM()
                {
                    Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.Id == id),
                    MillitaryRanks = _context.MillitaryRanks,
                    EducationsToEmployees = _context.EducationsToEmployees.Where(e => e.EmplooyeeId == id),
                    EducationTypes = _context.EducationTypes.ToList(),
                    Languages = _context.Languages.ToList(),
                    LanguageLevels = _context.LanguageLevels.ToList(),
                    Relationss = _context.Relations.ToList(),
                    MillitaryStatuses = _context.MillitaryStatuses,
                    Universities = _context.Universities.Where(u => u.Status != false),
                    UniFaculties=_context.UniFaculties.Where(f=>f.Status!=false),
                    Professions=_context.Professions.Where(p=>p.Status!=false),
                    ComputerLevels=_context.ComputerLevels.ToList(),
                    RelationTypes=_context.RelationTypes.ToList(),
                    School=_context.Schools.Where(s=>s.Emplooyee.Status!=false && s.EmplooyeeId==id).FirstOrDefault(),
                    AppUser=findCurrentHR
                };
                return View(vM);
        }
        public IActionResult GetUniversity(int? id,int keepId)
        {
            if (id == null) return NotFound();
            List<EducationTypeToUnivercity> universities = _context.EducationTypeToUnivercities.Where(u => u.Universities.Status != false && u.EducationType.Status != false &&
                                                                                                      u.EducationTypeId == id).ToList();
            ViewData["keepId"] = keepId;
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_GetUniversityRecruitmentPartial.cshtml", universities);
        }
        public IActionResult GetFaculty(int? id, int keepId)
        {
            if (id == null) return NotFound();
            List<UniFaculty> faculty = _context.UniFaculties.Where(u => u.Status != false && u.EducationTypeToUniversity.Universities.Status != false &&
                                                                   u.EducationTypeToUniversity.UniversitiesId == id).ToList();
            ViewData["keepId"] = keepId;
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_GetFacultyRecruitmentPartial.cshtml", faculty);
        }
        public IActionResult GetProfession(int? id,int keepId)
        {
            if (id == null) return NotFound();
            List<Profession> profession = _context.Professions.Where(u => u.Status != false && u.UniFaculty.Status != false &&
                                                                          u.UniFacultyId == id).ToList();
            ViewData["keepId"] = keepId;
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_GetProfessionRecruitmentPartial.cshtml", profession);
        }
        [HttpPost]
        public async Task<JsonResult> AddEducation(int? id,int? eduId,int? uniId,int? facId, int? proId,DateTime startEdu, DateTime endEdu,int? accepthoneyy)
        {
            //var checkDbEmplooyee = _context.Emplooyeees.Where(e => e.Id == idRec).FirstOrDefault();
            var checkDbEmplooyee = _context.Emplooyeees.Where(e => e.Id == id).FirstOrDefault();
            if (eduId == null || eduId == 0)
            {
                return Json("null edu");
            }
            if (uniId == null || uniId == 0)
            {
                return Json("null uni");
            }
            if (startEdu.Year<1900 || endEdu.Year<1900)
            {
                return Json("null Edu");
            }
            if (facId == null || facId == 0)
            {
                return Json("null fac");
            }
            if (proId == null || proId == 0)
            {
                return Json("null pro");
            }
            if (accepthoneyy == null || accepthoneyy == 0)
            {
                return Json("null accpt");
            }
            Education newEducation = new Education
            {
                EnteringTime = startEdu,
                FinishTime = endEdu,
                ProfessionId = proId,
                AcceptHoney = accepthoneyy,
                Status = false
            };
            await _context.Educations.AddAsync(newEducation);
            await _context.SaveChangesAsync();
            EducationsToEmployee newEducationsToEmployee = new EducationsToEmployee
            {
                EmplooyeeId = checkDbEmplooyee.Id,
                EducationId = newEducation.Id
            };
            await _context.EducationsToEmployees.AddAsync(newEducationsToEmployee);
            await _context.SaveChangesAsync();
            var educaToEmp = _context.EducationsToEmployees.Where(w => w.EmplooyeeId == checkDbEmplooyee.Id && w.Education.Status == false).Include(e => e.Education.Profession).ToList();
            string result = "";
            foreach (var edu in educaToEmp)
            {
                result += "\n<div>" +
                           "\n<div style='border:1px solid;color:black'>" +
                            "\n<div>" +
                             "\n<div class='form-group row ml-md-5 mt-3'>" +
                               "\n<div class='col-md-2'>" +
                                  "\n<label for='educationType'>Təhsilin dərəcəsi:</label>" +
                               "\n</div>" +
                               "\n<div class='col-sm-5'>" +
                                "\n<input type='text' value='" + edu.Education.Profession.UniFaculty.EducationTypeToUniversity.EducationType.Name + "' readonly class='form-control' />" +
                               "\n</div>" +
                               //
                               "\n<div class='col-sm-4' style='text-align:end;'><button type='button' onclick='modalEducationDelete("+id+"," + edu.Education.Id + ")' style='padding:6px 70px;' class='btn btn-danger'>Sil</button></div>" +
                              //
                              "\n</div>" +
                             "\n</div>" +
                            "\n<div class='line-item-property__field line-item-property__universityName'>" +
                             "\n<div class='form-group row ml-md-5'>" +
                              "\n<div class='col-md-2'>" +
                                "\n<label for='universityName'>Təhsil ocağının adı:</label>" +
                              "\n</div>" +
                              "\n<div class='col-sm-5'>" +
                                "\n<input type='text' value='" + edu.Education.Profession.UniFaculty.EducationTypeToUniversity.Universities.Name + "' readonly class='form-control' />" +
                              "\n</div>" +
                             "\n</div>" +
                            "\n</div>" +
                           "\n<div class='row'>" +
                            "\n<div class='col-md-4'>" +
                             "\n<div class='line-item-property__field line-item-property__enteringTime'>" +
                              "\n<div class='form-group row ml-md-5'>" +
                               "\n<div class='col-sm-7'>" +
                                "\n<label required for='enteringTime'>Başlama tarixi:</label>" +
                               "\n</div>" +
                               "\n<div class='col-sm-5'>" +
                               "\n<input type='text' value='" + edu.Education.EnteringTime.Date + "' readonly class='form-control' />" +
                               "\n</div>" +
                              "\n</div>" +
                             "\n</div>" +
                            "\n</div>" +
                            "\n<div class='col-md-4'>" +
                             "\n<div class='line-item-property__field line-item-property__endTimee'>" +
                              "\n<div class='form-group row ml-md-5'>" +
                               "\n<div class='col-sm-4'>" +
                                "\n<label required for='endTime'>Bitmə tarixi:</label>" +
                               "\n</div>" +
                               "\n<div class='col-sm-5'>" +
                                "\n<input type='text' value='" + edu.Education.FinishTime.Date + "' readonly class='form-control' />" +
                               "\n</div>" +
                              "\n</div>" +
                             "\n</div>" +
                            "\n</div>" +
                           "\n</div>" +
                           "\n<div class='line-item-property__field line-item-property__facultyName'>" +
                             "\n<div class='form-group row ml-md-5'>" +
                              "\n<div class='col-md-2'>" +
                                "\n<label for='facultyName'>Fakültə:</label>" +
                              "\n</div>" +
                              "\n<div class='col-sm-5'>" +
                                "\n<input type='text' value='" + edu.Education.Profession.UniFaculty.Name + "' readonly class='form-control' />" +
                              "\n</div>" +
                             "\n</div>" +
                            "\n</div>" +
                            "\n<div class='line-item-property__field line-item-property__specialtyName'>" +
                             "\n<div class='form-group row ml-md-5'>" +
                              "\n<div class='col-md-2'>" +
                                "\n<label for='specialtyName'>İxtisas:</label>" +
                              "\n</div>" +
                              "\n<div class='col-sm-5'>" +
                                "\n<input type='text' value='" + edu.Education.Profession.Name + "' readonly class='form-control' />" +
                              "\n</div>" +
                               //
                               //"\n<div class='col-sm-3 text-center'><button type='button' onclick='modalEducationDelete(" + edu.Education.Id+")' class='btn btn-danger'>Sil</button></div>" +
                                //
                             "\n</div>" +
                            "\n</div>" +
                            //
                            "\n<div class='line-item-property__field line-item-property__AcceptHon'>"+
                               "\n<div class='form-group row ml-md-5'>"+
                                  "\n<div class='col-md-2'>"+
                                     "\n<label for='accepthoneyy'>Qəbul balı:</label>"+
                                  "\n</div>"+
                                  "\n<div class='col-sm-5'>"+
                                     "\n<input required type='number' value='" + edu.Education.AcceptHoney + "' readonly class='form-control input-height' id='accepthoneyy'/>" +
                                  "\n</div>"+
                               "\n</div>"+
                            "\n</div>"+
                            //
                           "\n<br>" +
                          "\n</div><br><br>" +
                         "\n</div>";
            }
            return Json(result);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteEduc(int? EmpId, int? EducId)
        {
            if (EmpId == null) return NotFound();
            if (EducId == null) return NotFound();
            Education ed = _context.Educations.Find(EducId);
            if (ed == null) return NotFound();
            _context.Educations.Remove(ed);
            await _context.SaveChangesAsync();
            var checkDbEmplooyee = _context.Emplooyeees.Where(e => e.Id == EmpId).FirstOrDefault();
            RecruitmentCandidateVM vm = new RecruitmentCandidateVM
            {
                EducationsToEmployees = _context.EducationsToEmployees.Where(w => w.EmplooyeeId == checkDbEmplooyee.Id&&w.Education.Status==false).Include(e => e.Education.Profession).ToList()
            };
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_GetEducDeleteRecruitmentPartial.cshtml", vm);
        }

        //Add Language
        [HttpPost]
        public async Task<JsonResult> AddLanguage(int? id,int? idLang,int? idLangLev)
        {
            var checkDbEmplooyee = _context.Emplooyeees.Where(e => e.Id == id).FirstOrDefault();
            if (idLang == null || idLang == 0)
            {
                return Json("null lang");
            }
            if (idLangLev == null || idLangLev == 0)
            {
                return Json("null langLevel");
            }
            LanguageToLanguageLevel newLanguageToLanguageLevel = new LanguageToLanguageLevel
            {
                LanguageLevelId = idLangLev,
                LanguageId = idLang,
                Status=false
            };
            await _context.LanguageToLanguageLevels.AddAsync(newLanguageToLanguageLevel);
            await _context.SaveChangesAsync();

            LanguageToEmployee newLanguageToEmployee = new LanguageToEmployee
            {
                EmplooyeeId = checkDbEmplooyee.Id,
                LanguageToLanguageLevelId = newLanguageToLanguageLevel.Id
            };
            await _context.LanguageToEmployees.AddAsync(newLanguageToEmployee);
            await _context.SaveChangesAsync();
            var langToEmp = _context.LanguageToEmployees.Where(w => w.EmplooyeeId == checkDbEmplooyee.Id && w.LanguageToLanguageLevel.Status == false).Include(l=>l.LanguageToLanguageLevel.Language).Include(l=>l.LanguageToLanguageLevel.LanguageLevel).ToList();
            string result = "";
            foreach (var lang in langToEmp)
            {
                result += "\n<div class='form-group row'>" +
                           "\n<div class='col-md-3 offset-3'>"+
                            "\n<div class='row'>"+
                             "\n<div class='col-md-3'>" +
                                "\n<label for='language'>Dilin adı:</label>"+
                             "\n</div>" +
                             "\n<div class='col-md-8'>" +
                                  "\n<input type='text' value='" + lang.LanguageToLanguageLevel.Language.Name + "' readonly class='form-control input-height' />" +                              
                             "\n</div>" +
                            "\n</div>" +
                           "\n</div>" +
                           "\n<div class='col-md-3'>" +
                           "\n<div class='row'>" +
                             "\n<div class='col-md-5'>" +
                                "\n<label for='languageLevel'>Bilik səviyyəsi:</label>" +
                             "\n</div>" +
                             "\n<div class='col-md-7'>" +
                                  "\n<input type='text' value='" + lang.LanguageToLanguageLevel.LanguageLevel.Name + "' readonly class='form-control input-height' />" +
                             "\n</div>" +
                            "\n</div>" +
                           "\n</div>" +
                           //
                           "\n<div class='col-md-2 offset-1'>" +
                            "\n<div class='row'>" +
                             "\n<button type='button' onclick='modalLanguageDelete("+id+"," + lang.LanguageToLanguageLevel.Id + ")' class='btn btn-danger' style='padding: 0px 12px;'>Sil</button>" +
                            "\n</div>" +
                           "\n</div>" +
                          //
                          "\n</div>";
            }
            return Json(result);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteLang(int? EmpId, int? LangId)
        {
            if (EmpId == null) return NotFound();
            if (LangId == null) return NotFound();
            LanguageToLanguageLevel lg = _context.LanguageToLanguageLevels.Find(LangId);
            if (lg == null) return NotFound();
            _context.LanguageToLanguageLevels.Remove(lg);
            await _context.SaveChangesAsync();
            var checkDbEmplooyee = _context.Emplooyeees.Where(e => e.Id == EmpId).FirstOrDefault();
            RecruitmentCandidateVM vm = new RecruitmentCandidateVM
            {
                LanguageToEmployees = _context.LanguageToEmployees.Where(w => w.EmplooyeeId == checkDbEmplooyee.Id && w.LanguageToLanguageLevel.Status == false).ToList()
            };
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_GetLangDeleteRecruitmentPartial.cshtml", vm);
        }

        //Add Computer Skill
        [HttpPost]
        public async Task<JsonResult> AddComputerSkill(int? id,string txtComp, int? idCompLev)
        {
            var checkDbEmplooyee = _context.Emplooyeees.Where(e => e.Id == id).FirstOrDefault();
            if (string.IsNullOrWhiteSpace(txtComp))
            {
                return Json("null comp");
            }
            if (idCompLev == null || idCompLev == 0)
            {
                return Json("null compLevel");
            }
            ComputerSkillsName newComputerSkillsName = new ComputerSkillsName
            {
                Name = txtComp.Trim()
            };
            await _context.ComputerSkillsNames.AddAsync(newComputerSkillsName);
            await _context.SaveChangesAsync();
            ComputerSkillToLevels newComputerSkillToLevels = new ComputerSkillToLevels
            {
                ComputerLevelsId = idCompLev,
                ComputerSkillsNameId = newComputerSkillsName.Id,
                Status=false
            };
            await _context.ComputerSkillToLevels.AddAsync(newComputerSkillToLevels);
            await _context.SaveChangesAsync();
            ComputerToEmployee newComputerToEmployee = new ComputerToEmployee
            {
                EmplooyeeId = checkDbEmplooyee.Id,
                ComputerSkillToLevelsId = newComputerSkillToLevels.Id
            };
            await _context.ComputerToEmployees.AddAsync(newComputerToEmployee);
            await _context.SaveChangesAsync();
            var compToEmp = _context.ComputerToEmployees.Where(w => w.EmplooyeeId == checkDbEmplooyee.Id && w.ComputerSkillToLevels.Status == false).Include(c=>c.ComputerSkillToLevels.ComputerLevels).ToList();
            string result = "";
            foreach (var comp in compToEmp)
            {
                result += "\n<div class='col-md-6'>" +
                           "\n<div class='line-item-property_____field line-item-property_____computerSkill'>" +
                            "\n<div class='form-group row ml-md-5'>" +
                             "\n<div class='col-md-4'>" +
                                "\n<label for='computerSkill'>Kompyuter bilikləri:</label>" +
                             "\n</div>" +
                             "\n<div class='col-md-8'>" +
                                  "\n<input type='text' value='" + comp.ComputerSkillToLevels.ComputerSkillsName.Name + "' readonly class='form-control input-height' />" +
                             "\n</div>" +
                            "\n</div>" +
                           "\n</div>" +
                          "\n</div>" +
                          //
                          "\n<div class='col-md-6'>" +
                           "\n<div class='line-item-property_____field line-item-property_____level'>" +
                            "\n<div class='form-group row ml-md-5'>" +
                             "\n<div class='col-md-3'>" +
                                "\n<label for='computerLevel'>Bilik bilikləri:</label>" +
                             "\n</div>" +
                             "\n<div class='col-md-4'>" +
                                  "\n<input type='text' value='" + comp.ComputerSkillToLevels.ComputerLevels.Name + "' readonly class='form-control input-height' />" +
                             "\n</div>" +
                             //
                             "\n<div class='col-md-2 offset-1'>" +
                               "\n<button type='button' onclick='modalComputerDelete("+id+"," + comp.ComputerSkillToLevels.ComputerSkillsName.Id + ")' class='btn btn-danger' style='padding: 0px 12px;'>Sil</button>" +
                             "\n</div>" +
                             //
                            "\n</div>" +
                           "\n</div>" +
                          "\n</div>";
            }
            return Json(result);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteComp(int? EmpId, int? CompId)
        {
            if (CompId == null) return NotFound();
            ComputerSkillsName cn = _context.ComputerSkillsNames.Find(CompId);
            if (cn == null) return NotFound();
            _context.ComputerSkillsNames.Remove(cn);
           await _context.SaveChangesAsync();
            var checkDbEmplooyee = _context.Emplooyeees.Where(e => e.Id == EmpId).FirstOrDefault();
            RecruitmentCandidateVM vm = new RecruitmentCandidateVM
            {
                ComputerToEmployees = _context.ComputerToEmployees.Where(w => w.EmplooyeeId == checkDbEmplooyee.Id && w.ComputerSkillToLevels.Status == false).ToList()
            };
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_GetCompDeleteRecruitmentPartial.cshtml", vm);
        }

        //Add Family
        [HttpPost]
        public async Task<JsonResult> AddFamily(int? id,int? idSlct, string txtName, string txtSurname, string txtFatherName, string txtNumber, string txtAddress,string txtWork,string txtWorkPosName)
        {
            var checkDbEmplooyee = _context.Emplooyeees.Where(e => e.Id == id).FirstOrDefault();
            if (idSlct == null || idSlct == 0)
            {
                return Json("null slct");
            }
            if (string.IsNullOrWhiteSpace(txtName))
            {
                return Json("null name");
            }
            if (string.IsNullOrWhiteSpace(txtSurname))
            {
                return Json("null surname");
            }
            if (string.IsNullOrWhiteSpace(txtFatherName))
            {
                return Json("null fathername");
            }
            if (string.IsNullOrWhiteSpace(txtNumber))
            {
                return Json("null num");
            }
            if (string.IsNullOrWhiteSpace(txtAddress))
            {
                return Json("null add");
            }
            if (string.IsNullOrWhiteSpace(txtWork))
            {
                return Json("null work");
            }
            if (string.IsNullOrWhiteSpace(txtWorkPosName))
            {
                return Json("null workPosName");
            }
            Relations newRelations = new Relations
            {
                Name = txtName.Trim(),
                Surname = txtSurname.Trim(),
                FatherName = txtFatherName.Trim(),
                Number = txtNumber,
                Adress = txtAddress.Trim(),
                WorkPlaceName=txtWork.Trim(),
                WorkPlacePositionName=txtWorkPosName.Trim(),
                RelationTypeId = idSlct,
                Status=false
                
            };
            await _context.Relations.AddAsync(newRelations);
            await _context.SaveChangesAsync();
            RelationToEmployee newRelationToEmployee = new RelationToEmployee
            {
                EmplooyeeId = checkDbEmplooyee.Id,
                RelationId = newRelations.Id
            };
            await _context.RelationToEmployees.AddAsync(newRelationToEmployee);
            await _context.SaveChangesAsync();

            var famToEmp = _context.RelationToEmployees.Where(w => w.EmplooyeeId == checkDbEmplooyee.Id && w.Relation.Status == false).Include(w=>w.Relation).Include(w=>w.Relation.RelationType).ToList();
            string result = "";
          
            foreach (var fam in famToEmp)
            {
                result += "\n<div class='row'>" +
                          "\n<div class='col-md-3'>" +
                           "\n<div class='line-item-property____field line-item-property____kinship'>" +
                            "\n<div class='form-group ml-md-5'>" +
                             "\n<div class='col-lg-12 ml-md-4'>" +
                                "\n<label style='font-size:15px' for='kinship'>Qohumluluq dərəcəsi</label>" +
                             "\n</div>" +
                             "\n<div class='col-md-12'>"+
                                "\n<input type='text' value='" + fam.Relation.RelationType.Name + "' readonly class='form-control input-height' />" +
                             "\n</div>" +
                            "\n</div>" +
                           "\n</div>" +
                          "\n</div>" +
                          //
                          "\n<div class='col-md-2'>" +
                           "\n<div class='line-item-property____field line-item-property____relativeName'>" +
                            "\n<div class='form-group'>" +
                             "\n<div class='col-md-2 ml-md-1'>" +
                                "\n<label style='font-size:15px' for='relationName'>Adı</label>" +
                             "\n</div>" +
                             "\n<div class='col-sm-12'>" +
                                  "\n<input type='text' value='" + fam.Relation.Name + "' class='form-control input-height' id='relCreateName_"+fam.Id+"' />" +
                             "\n</div>" +
                            "\n</div>" +
                           "\n</div>" +
                          "\n</div>" +
                           //
                           "\n<div class='col-md-2'>" +
                           "\n<div class='line-item-property____field line-item-property____relativeSurname'>" +
                            "\n<div class='form-group'>" +
                             "\n<div class='col-md-2 ml-md-2'>" +
                                "\n<label style='font-size:15px;text-align: center' for='relationSurname'>Soyadı</label>" +
                             "\n</div>" +
                             "\n<div class='col-sm-12 ml-md-2'>" +
                                  "\n<input type='text' value='" + fam.Relation.Surname + "' class='form-control input-height' id='relCreateSurname_" + fam.Id + "'/>" +
                             "\n</div>" +
                            "\n</div>" +
                           "\n</div>" +
                          "\n</div>" +
                           //
                           "\n<div class='col-md-2'>" +
                           "\n<div class='line-item-property____field line-item-property____relativeFName'>" +
                            "\n<div class='form-group'>" +
                             "\n<div class='col-md-5 ml-md-2'>" +
                                "\n<label style='font-size:15px;text-align: center' for='relationFatherName'>Ata adı</label>" +
                             "\n</div>" +
                             "\n<div class='col-sm-12 ml-md-2'>" +
                                  "\n<input type='text' value='" + fam.Relation.FatherName + "' class='form-control input-height' id='relCreateFName_" + fam.Id + "'/>" +
                             "\n</div>" +
                            "\n</div>" +
                           "\n</div>" +
                          "\n</div>" +
                           //
                           "\n<div class='col-md-2'>" +
                           "\n<div class='line-item-property____field line-item-property____relativeNumber'>" +
                            "\n<div class='form-group'>" +
                             "\n<div class='col-md-8 ml-md-4'>" +
                                "\n<label style='font-size:15px;text-align: center' for='relationNumber'>Mobil nömrə</label>" +
                             "\n</div>" +
                             "\n<div class='col-sm-12 ml-md-2'>" +
                                  "\n<input type='text' value='" + fam.Relation.Number + "' class='relationNumm form-control input-height' id='relCreateNumber_" + fam.Id + "' placeholder='XXX-XXX-XXXX'/>" +
                             "\n</div>" +
                            "\n</div>" +
                           "\n</div>" +
                          "\n</div>" +
                         "\n</div>" +
                            //
                         //2 row
                         "\n<div class='row mb-4'>" +
                          "\n<div class='col-md-5'>" +
                           "\n<div class='line-item-property____field line-item-property____address'>" +
                            "\n<div class='form-group ml-md-5'>" +
                             "\n<div class='col-md-4 ml-md-1'>" +
                                "\n<label style='font-size:15px;text-align: center' for='relationAddress'>Ünvan</label>" +
                             "\n</div>" +
                             "\n<div class='col-md-10'>" +
                                  "\n<input type='text' value='" + fam.Relation.Adress + "' class='form-control input-height' id='relCreateAddress_" + fam.Id + "'/>" +
                             "\n</div>" +
                            "\n</div>" +
                           "\n</div>" +
                          "\n</div>"+
                           "\n<div class='col-md-6'>" +
                            "\n<div class='line-item-property____field line-item-property____workplace'>" +
                             "\n<div class='row'>" +
                                            "\n <div class='col-5'>" +
                                                  "\n<div class='form-group'>" +
                                                    "\n<div class='col-md-6 ml-md-1'>" +
                                                       "\n<label style ='font-size: 15px;text-align: center' for='relationWorkplace'>İş yerinin adı</label>" +
                                                    "\n</div>" +
                                                    "\n<div class='col-md-12'>" +
                                                       "\n<input value='" + fam.Relation.WorkPlaceName + "' type='text' class='form-control input-height' id='relCreateWorkplace_" + fam.Id + "'>" +
                                                    "\n</div>" +
                                                   "\n</div>" +
                                           "\n</div>" +
                                           "\n<div class='col-5'>" +
                                              "\n<div class='form-group'>" +
                                                "\n<div class='col-md-5 ml-md-1'>" +
                                                  "\n<label style = 'font-size: 15px;text-align: center' for='relationWorkplacePositionName'>Vəzifə adı</label>" +
                                                "\n</div>" +
                                                "\n<div class='col-md-12'>" +
                                                  "\n<input value='" + fam.Relation.WorkPlacePositionName + "' type='text' class='form-control input-height' id='relCreateWorkPosName_" + fam.Id + "'>" +
                                                "\n</div>" +

                                               "\n</div>" +
                                           "\n</div>" +
                                           "\n<div class='col-2'>" +
                                              "\n<div class='form-group'>" +
                                                     "\n<div class=''>" +
                                                       "\n<button type='button' onclick='modalFamilyDelete("+id+"," + fam.Relation.Id + ")' class='btn btn-danger' style='padding: 0px 28px;height:26px;'>Sil</button>" +
                                                    "\n</div>" +
                                                      "\n<div class='mt-2'>" +
                                                          "\n<button type='button' onclick='editF(" + fam.RelationId + "," + fam.Id + ","+fam.Emplooyee.Id+")' class='btn btn-warning' style='padding: 0px 17px;height:30px;'>Yenilə</button>" +
                                                     "\n</div>" +
                                              "\n</div>" +
                                           "\n</div>" +
                                  //
                                  "\n</div>" +
                               "\n</div>" +
                              "\n</div>" +
                        //
                        "\n</div>";
            }
            return Json(result);
        }

        //Edit Family
        [HttpPost]
        public async Task<JsonResult> EditFamily(int? EmpId, int? clickid, string txtName, string txtSurname, string txtFatherName, string txtNumber, string txtAddress, string txtWork,string txtWorkPosName)
        {
            var checkDbEmplooyee = _context.Emplooyeees.Where(e => e.Id == EmpId).FirstOrDefault();
            var famEmp = _context.RelationToEmployees.Where(r => r.RelationId == clickid).FirstOrDefault();
            //if (idSlct == null || idSlct == 0)
            //{
            //    return Json("null slct");
            //}
            if (string.IsNullOrWhiteSpace(txtName))
            {
                return Json("null name");
            }
            if (string.IsNullOrWhiteSpace(txtSurname))
            {
                return Json("null surname");
            }
            if (string.IsNullOrWhiteSpace(txtFatherName))
            {
                return Json("null fathername");
            }
            if (string.IsNullOrWhiteSpace(txtNumber))
            {
                return Json("null num");
            }
            if (string.IsNullOrWhiteSpace(txtAddress))
            {
                return Json("null add");
            }
            if (string.IsNullOrWhiteSpace(txtWork))
            {
                return Json("null work");
            }
            if (string.IsNullOrWhiteSpace(txtWorkPosName))
            {
                return Json("null workPosName");
            }
            famEmp.Relation.Name = txtName.Trim();
            famEmp.Relation.Surname = txtSurname.Trim();
            famEmp.Relation.FatherName = txtFatherName.Trim();
            famEmp.Relation.Number = txtNumber.Trim();
            famEmp.Relation.Adress = txtAddress.Trim();
            famEmp.Relation.WorkPlaceName = txtWork.Trim();
            famEmp.Relation.WorkPlacePositionName = txtWorkPosName.Trim();
            //famEmp.Relation.RelationTypeId = idSlct;
            await _context.SaveChangesAsync();
            return Json("success");
        }

        [HttpPost]
        public IActionResult DeleteFamily(int? EmpId, int? FamId)
        {
            if (FamId == null) return NotFound();
            Relations rn = _context.Relations.Find(FamId);
            if (rn == null) return NotFound();
            _context.Relations.Remove(rn);
            _context.SaveChanges();
            var checkDbEmplooyee = _context.Emplooyeees.Where(e => e.Id == EmpId).FirstOrDefault();
            RecruitmentCandidateVM vm = new RecruitmentCandidateVM
            {
                RelationToEmployees = _context.RelationToEmployees.Where(w => w.EmplooyeeId == checkDbEmplooyee.Id && w.Relation.Status == false).ToList(),
                RelationTypes = _context.RelationTypes.ToList()
            };
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_GetFamilyDeleteRecruitmentPartial.cshtml", vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RecruitmentCandidateVM recruitmentCandidate,string MilitaryStatus,int? military,int id)
        {
            AppUser findCurrentHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            var checkDbEmplooyee = _context.Emplooyeees.Where(e => e.Id == id).FirstOrDefault();
            RecruitmentCandidateVM vM = new RecruitmentCandidateVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.Id == id),
                MillitaryRanks = _context.MillitaryRanks,
                EducationsToEmployees = _context.EducationsToEmployees.Where(e => e.EmplooyeeId == id && e.Education.Status != false),
                EducationTypes = _context.EducationTypes.Where(e => e.Status != false),
                Languages = _context.Languages,
                LanguageLevels = _context.LanguageLevels,
                Relationss = _context.Relations.Where(r => r.Status != false),
                Universities = _context.Universities.Where(u => u.Status != false),
                UniFaculties = _context.UniFaculties.Where(f => f.Status != false),
                Professions = _context.Professions.Where(p => p.Status != false),
                ComputerLevels = _context.ComputerLevels,
                RelationTypes = _context.RelationTypes,
                LanguageToLanguageLevels = _context.LanguageToLanguageLevels.Where(l => l.Status != false),
                ComputerSkillToLevels = _context.ComputerSkillToLevels.Where(c => c.Status != false),
                AppUser = findCurrentHR
            };
            //VM Education False
            RecruitmentCandidateVM vMStatusFalse = new RecruitmentCandidateVM()
            {
                EducationsToEmployees = _context.EducationsToEmployees.Where(e => e.EmplooyeeId == id),
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.Id == id),
                MillitaryRanks = _context.MillitaryRanks,
                EducationsToEmployeesForFalse = _context.EducationsToEmployees.Where(e => e.EmplooyeeId == id && e.Education.Status == false),
                EducationTypes = _context.EducationTypes.Where(e => e.Status != false),
                Languages = _context.Languages,
                LanguageLevels = _context.LanguageLevels,
                Universities = _context.Universities.Where(u => u.Status != false),
                UniFaculties = _context.UniFaculties.Where(f => f.Status != false),
                Professions = _context.Professions.Where(p => p.Status != false),
                ComputerLevels = _context.ComputerLevels,
                RelationTypes = _context.RelationTypes,
                ComputerToEmployeesForFalse=_context.ComputerToEmployees.Where(c=> c.EmplooyeeId == id && c.ComputerSkillToLevels.Status==false),
                LanguageToEmployeesForFalse=_context.LanguageToEmployees.Where(l=>l.EmplooyeeId==id && l.LanguageToLanguageLevel.Status==false),//Yeni 
                RelationsForFalsee = _context.RelationToEmployees.Where(l =>l.Emplooyee.Id==id && l.Relation.Status==false),
                School=_context.Schools.Where(s=>s.Emplooyee.Status!=false&&s.EmplooyeeId==id).FirstOrDefault(),
                AppUser = findCurrentHR
            };

            //Check personal information
            if (ModelState["IdCard"].ValidationState == ModelValidationState.Invalid||
                ModelState["FinCode"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View(vMStatusFalse);
            }
            //foreach (var item in vM.Emplooyees)
            //{
            //    if (item.Email== findCurrentHR.Email)
            //    {
            //        checkDbEmplooyee.Image = findCurrentHR.Image;
            //    }
            //    else
            //    {
            //        if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            //        {
            //            return View(vMStatusFalse);
            //        }
            //    }
            //}
           
            //check military null or not null
            if (MilitaryStatus==null)
            {
                ViewData["error_military"] = "Zəhmət olmasa seçin";
                return View(vMStatusFalse);
            }
            var searchMilitarystatusNo = _context.MillitaryStatuses.Where(m => m.Name == "No").FirstOrDefault().Id;
            if (MilitaryStatus=="noo")
            {
               checkDbEmplooyee.MillitaryStatusId = searchMilitarystatusNo;
               
            }else if(MilitaryStatus == "yess")
            {
                if(military == 0 || military == null)
                {
                    ViewData["error_militaryRank"] = "Zəhmət olmasa herbi rutbeni seçin";
                    return View(vMStatusFalse);
                }
                var getMilStatusId = _context.MillitaryStatuses.Where(m => m.MillitaryRankId == military).FirstOrDefault().Id;
                checkDbEmplooyee.MillitaryStatusId = getMilStatusId;
            }
            //Check image
            if (recruitmentCandidate.Photo!=null)
            {
                if (!recruitmentCandidate.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Şəkil faylı seçin");
                    return View(vMStatusFalse);
                }

                if (!recruitmentCandidate.Photo.ImageSize(2))
                {
                    ModelState.AddModelError("Photo", "Şəkilin ölçüsü 2Mb-dan artıq ola bilməz");
                    return View(vMStatusFalse);
                }
            }

            //Check Word
            if (recruitmentCandidate.Word!=null)
            {
                if (!recruitmentCandidate.Word.IsWord())
                {
                    ModelState.AddModelError("Word", "Zəhmət olmasa word faylını düzgün seçin");
                    return View(vMStatusFalse);
                }
                if (!recruitmentCandidate.Word.WordSize(4))
                {
                    ModelState.AddModelError("Word", "Word faylının ölçüsü 4Mb-dan artıq ola bilməz");
                    return View(vMStatusFalse);
                }
            }
            //Check Pdf
            
            if (recruitmentCandidate.Pdf != null)
            {
                if (!recruitmentCandidate.Pdf.IsPdf())
                {
                    ModelState.AddModelError("Pdf", "Zəhmət olmasa pdf faylını düzgün seçin");
                    return View(vMStatusFalse);
                }
                if (!recruitmentCandidate.Pdf.PdfSize(4))
                {
                    ModelState.AddModelError("Pdf", "Pdf faylının ölçüsü 4Mb-dan artıq ola bilməz");
                    return View(vMStatusFalse);
                }
            }
            //Check Cert Img
            if (recruitmentCandidate.PhotoCertificate != null)
            {
                if (!recruitmentCandidate.PhotoCertificate.IsImage())
                {
                    ModelState.AddModelError("PhotoCertificate", "Zəhmət olmasa sertifikat şəkili düzgün seçin");
                    return View(vMStatusFalse);
                }
                if (!recruitmentCandidate.PhotoCertificate.ImageSize(2))
                {
                    ModelState.AddModelError("PhotoCertificate", "Sertifikat şəkilin ölçüsü 2Mb-dan artıq ola bilməz");
                    return View(vMStatusFalse);
                }
            }
            //Check Scan Img
            if (recruitmentCandidate.ScanCommandPhoto != null)
            {
                if (!recruitmentCandidate.ScanCommandPhoto.IsPdf())
                {
                    ModelState.AddModelError("ScanCommandPhoto", "Zəhmət olmasa skan pdf faylını düzgün seçin");
                    return View(vMStatusFalse);
                }
                if (!recruitmentCandidate.ScanCommandPhoto.PdfSize(3))
                {
                    ModelState.AddModelError("ScanCommandPhoto", "Skan pdf faylının ölçüsü 3Mb-dan artıq ola bilməz");
                    return View(vMStatusFalse);
                }
            }

            var checkIdCard = _context.Emplooyeees.Any(e => e.IdCard == recruitmentCandidate.IdCard&&e.CompanyId==findCurrentHR.CompaniesId&&e.Status!=false&&e.IsWorking!=false);
            var checkFinCode = _context.Emplooyeees.Any(e => e.FinCode == recruitmentCandidate.FinCode && e.CompanyId == findCurrentHR.CompaniesId && e.Status != false && e.IsWorking != false);
            if (checkIdCard)
            {
                ModelState.AddModelError("IdCard", "Bu seriyalı şəxsiyyət vəsiqəsində artıq işçi var");
                return View(vMStatusFalse);
            }
            if (checkFinCode)
            {
                ModelState.AddModelError("FinCode", "Bu Fin kod nömrəsində artıq işçi var");
                return View(vMStatusFalse);
            }
            checkDbEmplooyee.IdCard = recruitmentCandidate.IdCard.ToUpper();
            checkDbEmplooyee.FinCode = recruitmentCandidate.FinCode.ToUpper();

            foreach (var item in vM.Emplooyees)
            {
                if (item.Email == findCurrentHR.Email)
                {
                    bool deleteHr= Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, findCurrentHR.Image);
                    string filenamePhoto = await recruitmentCandidate.Photo.CopyImage(_env.WebRootPath, "user");
                    checkDbEmplooyee.Image = filenamePhoto;
                    findCurrentHR.Image = filenamePhoto;
                    if (recruitmentCandidate.ScanCommandPhoto != null)
                    {
                        string filenameScanPhoto = await recruitmentCandidate.ScanCommandPhoto.CopyPdf(_env.WebRootPath, "userOtherDocs/pdf");
                        checkDbEmplooyee.ScanCommand = filenameScanPhoto;
                    }
                }
                else
                {
                    if (recruitmentCandidate.Photo != null)
                    {
                        string filenamePhoto = await recruitmentCandidate.Photo.CopyImage(_env.WebRootPath, "user");
                        checkDbEmplooyee.Image = filenamePhoto;
                    }
                    if (recruitmentCandidate.ScanCommandPhoto != null)
                    {
                        string filenameScanPhoto = await recruitmentCandidate.ScanCommandPhoto.CopyPdf(_env.WebRootPath, "userOtherDocs/pdf");
                        checkDbEmplooyee.ScanCommand = filenameScanPhoto;
                    }
                }

            }

            var findEduc = _context.EducationsToEmployees.Where(e => e.EmplooyeeId == id && e.Education.Status == false);
            foreach (var ed in findEduc)
            {
                ed.Education.Status = true;
            }
            var findLang = _context.LanguageToEmployees.Where(l => l.EmplooyeeId == id && l.LanguageToLanguageLevel.Status == false);
            foreach (var lg in findLang)
            {
                lg.LanguageToLanguageLevel.Status = true;
            }
            var findComp = _context.ComputerToEmployees.Where(c => c.EmplooyeeId == id && c.ComputerSkillToLevels.Status == false);
            foreach (var cp in findComp)
            {
                cp.ComputerSkillToLevels.Status = true;
            }
            var findFamily = _context.RelationToEmployees.Where(r => r.EmplooyeeId == id && r.Relation.Status == false);
            foreach (var fm in findFamily)
            {
                fm.Relation.Status = true;
            }

               if(recruitmentCandidate.Word!=null||
                recruitmentCandidate.Pdf!=null||
                recruitmentCandidate.PhotoCertificate!=null)
               {
                var Addition = new AdditionalInfos
                {
                    EmplooyeeId = checkDbEmplooyee.Id
                };
                if (recruitmentCandidate.Word != null)
                {
                    string filenameWord = await recruitmentCandidate.Word.CopyWord(_env.WebRootPath, "userOtherDocs/word");
                    Addition.MicrosoftWord = filenameWord;
                }
                if (recruitmentCandidate.Pdf != null)
                {
                    string filenamePdf = await recruitmentCandidate.Pdf.CopyPdf(_env.WebRootPath, "userOtherDocs/pdf");
                    Addition.AdobePdf = filenamePdf;
                }
                if (recruitmentCandidate.PhotoCertificate != null)
                {
                    string filenameImg = await recruitmentCandidate.PhotoCertificate.CopyImage(_env.WebRootPath, "userOtherDocs/img");
                    Addition.AdditionCertImage = filenameImg;
                }
                await _context.AdditionalInfos.AddAsync(Addition);
               }

            checkDbEmplooyee.IsCandidate = false;
            await _context.SaveChangesAsync();
            //return RedirectToAction("Create", "Recruitment",new { id = idRec });
            return RedirectToAction("Index", "Practitioner");
        }

       
    }
}
