using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Education;
using InternalSystem.Areas.InternalHR.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.InternalHR.Controllers
{
    [Area("InternalHR")]
    [Authorize(Roles = "HumanResource,HrDepartmentBoss")]
    public class PractitionerController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;

        public PractitionerController(UserManager<AppUser> userManager, InternalSysDBContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            AppUser findCurrenHR = await _userManager.FindByEmailAsync(User.Identity.Name);

            //
            var candidatesAndNumber = _context.PhoneNumberToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking == false && w.Emplooyee.CompanyId == findCurrenHR.CompaniesId && w.Emplooyee.IsCandidate == true).Take(50);
            return View(candidatesAndNumber);
        }
        public async Task<IActionResult> AllPractitioner()
        {
            AppUser findCurrenHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<PhoneNumberToEmployee> candidatesAndNumber = _context.PhoneNumberToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking == false && w.Emplooyee.CompanyId == findCurrenHR.CompaniesId && w.Emplooyee.IsCandidate == true).ToList();
            return View(candidatesAndNumber);
        }
        public IActionResult GetUniversities(int? id)
        {
            if (id == null) return NotFound();
            if (id==5)
            {
                PractitionerVM vM = new PractitionerVM();
                return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_GetSchoolCandidatePartial.cshtml",vM);
            }
            PractitionerVM vM1 = new PractitionerVM()
            {
                EducationTypeToUnivercities = _context.EducationTypeToUnivercities.Where(u => u.Universities.Status != false && u.EducationType.Status != false &&
                                                                                                        u.EducationTypeId == id).ToList(),
                EducationTypes = _context.EducationTypes.Where(w => w.Status != false).ToList(),
                Genders = _context.Genders.ToList(),
                MarialStatuses = _context.MarialStatuses.ToList(),
            };
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_GetUniversityPractitionerPartial.cshtml", vM1);
        }
        public IActionResult GetFaculties(int? id)
        {
            if (id == null) return NotFound();
            PractitionerVM vM1 = new PractitionerVM()
            {
                EducationTypes = _context.EducationTypes.Where(w => w.Status != false).ToList(),
                Genders = _context.Genders.ToList(),
                MarialStatuses = _context.MarialStatuses.ToList(),
                UniFaculties = _context.UniFaculties.Where(u => u.Status != false && u.EducationTypeToUniversity.Universities.Status != false &&
                                                                     u.EducationTypeToUniversity.UniversitiesId == id).ToList()
            };
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_GetFacultyPractitionerPartial.cshtml", vM1);
        }
        public IActionResult GetProfessions(int? id)
        {
            if (id == null) return NotFound();
            PractitionerVM vM1 = new PractitionerVM()
            {
                EducationTypes = _context.EducationTypes.Where(w => w.Status != false).ToList(),
                Genders = _context.Genders.ToList(),
                MarialStatuses = _context.MarialStatuses.ToList(),
                Professions = _context.Professions.Where(u => u.Status != false && u.UniFaculty.Status != false &&
                                                                           u.UniFacultyId == id).ToList()
            };
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_GetProfessionPractitionerPartial.cshtml", vM1);

        }
        public IActionResult Create()
        {
            //image hr
            //var mini_image_nav_hr = User.Identity.Name;
            //AppUser appUser = await _userManager.FindByEmailAsync(mini_image_nav_hr);
            //ViewData["image_hr"] = appUser.Image;
            //ViewData["name_hr"] = appUser.Name + " " + appUser.Surname;
            //ViewData["company_image_hr"] = appUser.Companies.Image;

            PractitionerVM practVm = new PractitionerVM()
            {
                EducationTypes = _context.EducationTypes.Where(w => w.Status != false).ToList(),
                Genders = _context.Genders.ToList(),
                MarialStatuses = _context.MarialStatuses.ToList(),
            };
            return View(practVm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PractitionerVM viewModel)
        {
            AppUser findCurrentHr = await _userManager.FindByEmailAsync(User.Identity.Name);
            PractitionerVM models = new PractitionerVM()
            {
                EducationTypes = _context.EducationTypes.Where(w => w.Status != false).ToList(),
                Genders = _context.Genders.ToList(),
                MarialStatuses = _context.MarialStatuses.ToList(),
                Emplooyee = viewModel.Emplooyee
            };

            if (ModelState["Emplooyee.FirstName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Emplooyee.Lastname"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Emplooyee.FatherName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Emplooyee.Birthday"].ValidationState == ModelValidationState.Invalid ||
                ModelState["PhoneNumbers.PhoneNumber"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Emplooyee.Email"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Emplooyee.BirthPlace"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Emplooyee.LivingAdress"].ValidationState == ModelValidationState.Invalid ||
                ModelState["EduTypeId"].ValidationState == ModelValidationState.Invalid)
            {
                return View(models);
            }

            Emplooyee newEmplooyee = new Emplooyee()
            {
                FirstName = viewModel.Emplooyee.FirstName.Trim(),
                Lastname = viewModel.Emplooyee.Lastname.Trim(),
                FatherName = viewModel.Emplooyee.FatherName.Trim(),
                Email = viewModel.Emplooyee.Email.ToLower(),
                Status = true,
                LivingAdress=viewModel.Emplooyee.LivingAdress.Trim(),
                BirthPlace = viewModel.Emplooyee.BirthPlace.Trim(),
                GenderId=viewModel.GenderId,
                MarialstatusId=viewModel.MarialStatusId,
                Birthday=viewModel.Emplooyee.Birthday,
                CompanyId = findCurrentHr.CompaniesId,
                IsCandidate = true,
            };
            await _context.Emplooyeees.AddAsync(newEmplooyee);
            await _context.SaveChangesAsync();
            //University add
            if (viewModel.ProfId!=null)
            {
                var findProfession =  _context.Professions.Where(w => w.Status != false && w.Id == viewModel.ProfId && w.UniFacultyId == viewModel.FacId && w.UniFaculty.EducationTypeToUniversity.EducationTypeId == viewModel.EduTypeId &&
                                                                      w.UniFaculty.EducationTypeToUniversity.UniversitiesId == viewModel.UniId).FirstOrDefault();

                Education Education = new Education();
                Education.ProfessionId = viewModel.ProfId;
                Education.EnteringTime = viewModel.Education.EnteringTime;
                Education.FinishTime = viewModel.Education.FinishTime.Date;
                Education.AcceptHoney = viewModel.Education.AcceptHoney;
                Education.Status = true;
                await _context.Educations.AddAsync(Education);
                await _context.SaveChangesAsync();

                EducationsToEmployee CreateeducationsToEmployee = new EducationsToEmployee();
                CreateeducationsToEmployee.Education = Education;
                CreateeducationsToEmployee.Emplooyee = viewModel.Emplooyee;
                CreateeducationsToEmployee.EducationId = Education.Id;
                CreateeducationsToEmployee.EmplooyeeId = newEmplooyee.Id;
                await _context.EducationsToEmployees.AddAsync(CreateeducationsToEmployee);
                await _context.SaveChangesAsync();
            }
            //School add
            if (viewModel.School != null)
            {
                School newSchool = new School
                {
                    Name = viewModel.School.Name.Trim(),
                    EmplooyeeId = newEmplooyee.Id,
                    EducationTypeId = 5
                };
                await _context.Schools.AddAsync(newSchool);
                await _context.SaveChangesAsync();
            }

            PhoneNumbers newPhone = new PhoneNumbers();
            newPhone.PhoneNumber = viewModel.PhoneNumbers.PhoneNumber;
            newPhone.HomeNumber = viewModel.PhoneNumbers.HomeNumber;
            await _context.PhoneNumbers.AddAsync(newPhone);
            await _context.SaveChangesAsync();
            PhoneNumberToEmployee phoneNumberToEmployee = new PhoneNumberToEmployee();
            phoneNumberToEmployee.EmplooyeeID = newEmplooyee.Id;
            phoneNumberToEmployee.PhoneNumberId = newPhone.Id;
            await _context.PhoneNumberToEmployees.AddAsync(phoneNumberToEmployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Editt(int? id)
        {
            if (id == null) return NotFound();
            var educationsToEmployee = await _context.EducationsToEmployees.Where(w => w.Education.Status != false && w.Emplooyee.Status != false
                                                                                  && w.EmplooyeeId == id).FirstOrDefaultAsync();
            if (educationsToEmployee!=null)
            {
                ViewData["EducationTypeIdd"] = educationsToEmployee.Education.Profession.UniFaculty.EducationTypeToUniversity.EducationTypeId;
                GetInfo(educationsToEmployee, id);
            }
            PractitionerVM vM = new PractitionerVM()
                {
                    School=await _context.Schools.Where(s=>s.Emplooyee.Status!=false&&s.EmplooyeeId==id).FirstOrDefaultAsync(),
                    EducationsToEmployee= educationsToEmployee,
                    Genders = _context.Genders.ToList(),
                    MarialStatuses = _context.MarialStatuses.ToList(),
                    EducationTypes = _context.EducationTypes.Where(w => w.Status != false).ToList(),
                    Universities=_context.Universities.Where(u=>u.Status!=false).ToList(),
                    UniFaculties=_context.UniFaculties.Where(u => u.Status != false).ToList(),
                    Professions=_context.Professions.Where(p=>p.Status!=false).ToList(),
                    PhoneNumberToEmployee =await _context.PhoneNumberToEmployees.Where(p => p.Emplooyee.Status != false && p.EmplooyeeID == id).FirstOrDefaultAsync()
                };
            if (vM == null) return NotFound();
            return View(vM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editt(PractitionerVM viewModel,int? id)
        {
            var phoneEmpDb = await _context.PhoneNumberToEmployees.Where(e => e.Emplooyee.Status != false && e.EmplooyeeID == id).FirstOrDefaultAsync();
            PractitionerVM models = new PractitionerVM()
            {
                PhoneNumberToEmployee=await _context.PhoneNumberToEmployees.Where(p=>p.Emplooyee.Status!=false&&p.EmplooyeeID==id).FirstOrDefaultAsync(),
                EducationTypes = _context.EducationTypes.Where(w => w.Status != false).ToList(),
                Genders = _context.Genders.ToList(),
                MarialStatuses = _context.MarialStatuses.ToList(),
                Emplooyee = viewModel.Emplooyee
            };
            if (ModelState["Emplooyee.FirstName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Emplooyee.Lastname"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Emplooyee.FatherName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Emplooyee.Birthday"].ValidationState == ModelValidationState.Invalid ||
                ModelState["PhoneNumbers.PhoneNumber"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Emplooyee.Email"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Emplooyee.BirthPlace"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Emplooyee.LivingAdress"].ValidationState == ModelValidationState.Invalid)
            {
                return View(models);
            }
            if (viewModel.School!=null)
            {
                var empSchool =await _context.Schools.Where(s => s.Emplooyee.Status != false && s.EmplooyeeId == id).FirstOrDefaultAsync();
                empSchool.Name = viewModel.School.Name.Trim();
                await _context.SaveChangesAsync();
            }
            if (viewModel.ProfId!=null)
            {
                var empEduc =await _context.EducationsToEmployees.Where(e => e.Emplooyee.Status != false && e.EmplooyeeId == id).FirstOrDefaultAsync();
                empEduc.Education.ProfessionId = viewModel.ProfId;
                empEduc.Education.AcceptHoney = viewModel.Education.AcceptHoney;
                empEduc.Education.EnteringTime = viewModel.Education.EnteringTime; 
                empEduc.Education.FinishTime = viewModel.Education.FinishTime;
                await _context.SaveChangesAsync();
            }
            phoneEmpDb.Emplooyee.FirstName = viewModel.Emplooyee.FirstName.Trim();
            phoneEmpDb.Emplooyee.Lastname = viewModel.Emplooyee.Lastname.Trim();
            phoneEmpDb.Emplooyee.FatherName = viewModel.Emplooyee.FatherName.Trim();
            phoneEmpDb.Emplooyee.MarialstatusId = viewModel.MarialStatusId;
            phoneEmpDb.Emplooyee.GenderId = viewModel.GenderId;
            phoneEmpDb.Emplooyee.Birthday = viewModel.Emplooyee.Birthday;
            phoneEmpDb.PhoneNumber.HomeNumber = viewModel.PhoneNumbers.HomeNumber;
            phoneEmpDb.PhoneNumber.PhoneNumber = viewModel.PhoneNumbers.PhoneNumber;
            phoneEmpDb.Emplooyee.Email = viewModel.Emplooyee.Email.Trim();
            phoneEmpDb.Emplooyee.BirthPlace = viewModel.Emplooyee.BirthPlace.Trim();
            phoneEmpDb.Emplooyee.LivingAdress = viewModel.Emplooyee.LivingAdress.Trim();
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AllPractitioner));
        }
        public async Task<IActionResult> Delete(int CandidateId)
        {
            AppUser findCurrenHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            Emplooyee emplooyee = await _context.Emplooyeees.FindAsync(CandidateId);
            if (emplooyee == null)
                return NotFound();
            emplooyee.Status = false;
            _context.Entry(emplooyee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            var phoneAndEmplooyees = _context.PhoneNumberToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != true && w.Emplooyee.CompanyId == findCurrenHR.CompaniesId && w.Emplooyee.IsCandidate==true).ToList();
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_CandidatePartial.cshtml", phoneAndEmplooyees);
        }
        public IActionResult AllLastWorks(int id)
        {
            //image hr
            //var mini_image_nav_hr = User.Identity.Name;
            //AppUser appUser = await _userManager.FindByEmailAsync(mini_image_nav_hr);
            //ViewData["image_hr"] = appUser.Image;
            //ViewData["name_hr"] = appUser.Name + " " + appUser.Surname;
            //ViewData["company_image_hr"] = appUser.Companies.Image;

            if (id == 0) return NotFound();
            ViewData["employeeId"] = id;
            AllLastWorksLeftButtonVM allLast = new AllLastWorksLeftButtonVM()
            {
                LastWorkPlaces = _context.LastWorks.Where(w => w.Status != false && w.EmplooyeeId == id).ToList(),
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.Id == id).FirstOrDefault(),

            };
            if (allLast == null)
                NotFound();
            return View(allLast);
        }

        [HttpGet]
        public IActionResult CreateLastWork(int id)
        {
            //image hr
            //var mini_image_nav_hr = User.Identity.Name;
            //AppUser appUser = await _userManager.FindByEmailAsync(mini_image_nav_hr);
            //ViewData["image_hr"] = appUser.Image;
            //ViewData["name_hr"] = appUser.Name + " " + appUser.Surname;
            //ViewData["company_image_hr"] = appUser.Companies.Image;

            ViewData["employeeId"] = id;           
            var lastWork = new LastWorkPlace { EmplooyeeId = id };
            var empIdd = new Emplooyee { Id = id };
            ViewData["employeeIdBackButton"] = empIdd.IdCard;
            return View(lastWork);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLastWork(LastWorkPlace newLastWork, int EmployeeId)//
        {
            if (ModelState["WorkType"].ValidationState == ModelValidationState.Invalid ||
                ModelState["CompanyName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["PositionName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["WhenStarted"].ValidationState == ModelValidationState.Invalid ||
                ModelState["WhenLeft"].ValidationState == ModelValidationState.Invalid ||
                ModelState["ReasonType"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Reason"].ValidationState == ModelValidationState.Invalid)
            {
                return View(newLastWork);
            }
            LastWorkPlace newWork = new LastWorkPlace();
            newWork.WorkType = newLastWork.WorkType;
            newWork.CompanyName = newLastWork.CompanyName;
            newWork.PositionName = newLastWork.PositionName;
            newWork.Salary = newLastWork.Salary;
            newWork.WhenStarted = newLastWork.WhenStarted;
            newWork.WhenLeft = newLastWork.WhenLeft;
            newWork.ReasonType = newLastWork.ReasonType;
            newWork.Reason = newLastWork.Reason;
            newWork.EmplooyeeId = newLastWork.EmplooyeeId;
            newWork.Status = true;
            await _context.AddAsync(newWork);
            await _context.SaveChangesAsync();
            EmployeeId = newLastWork.EmplooyeeId;//
            //return RedirectToAction(nameof(AllLastWorks));
            return RedirectToAction("AllLastWorks", "Practitioner", new { id = EmployeeId });
        }
        public IActionResult DeleteLastWord(int? id, int? Employeeid)
        {
            if (id == null) return NotFound();
            if (Employeeid == null) return NotFound();
            LastWorkPlace findLastWork = _context.LastWorks.Find(id);
            if (findLastWork == null)
                NotFound();
            _context.LastWorks.Remove(findLastWork);
            _context.SaveChanges();
            List<LastWorkPlace> lastWorkPlaces = _context.LastWorks.Where(w => w.Status != false && w.EmplooyeeId == Employeeid).ToList();
            if (lastWorkPlaces == null)
                NotFound();
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_LastWorkPartial.cshtml", lastWorkPlaces);
        }
        [HttpGet]
        public IActionResult SingleWorkInfo(int LastWorkid, int empId)
        {
            LastWorkPlace findLastWork = _context.LastWorks.Where(w => w.Status != false && w.Id == LastWorkid && w.EmplooyeeId == empId).FirstOrDefault();
            ViewData["worktype_edit"] = findLastWork.WorkType;
            ViewData["reasontype_edit"] = findLastWork.ReasonType;
            if (findLastWork == null)
                NotFound();
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_SingleLastWorkForModal.cshtml", findLastWork);
        }

        [HttpPost]
        public IActionResult SaveEditedWork(int id, int empId, string CompanyName, string Position, string Salary, DateTime WhenStarted, DateTime WhenLeft,string ReasonType, string Reason, string WorkType)
        {
            LastWorkPlace find = _context.LastWorks.Where(w => w.Status != false && w.Id == id && w.EmplooyeeId == empId).FirstOrDefault();
            if (find == null)
                NotFound();
            if (string.IsNullOrWhiteSpace(CompanyName) ||
                string.IsNullOrWhiteSpace(Position) ||
                WhenStarted.Year < 1900 ||
                WhenLeft.Year < 1900 ||
                string.IsNullOrWhiteSpace(ReasonType) ||
                string.IsNullOrWhiteSpace(Reason) ||
                string.IsNullOrWhiteSpace(WorkType))
            {
                return RedirectToAction("AllLastWorks", "Practitioner", new { id = empId });
            }
            find.WorkType = WorkType;
            find.CompanyName = CompanyName.Trim();
            find.PositionName = Position.Trim();
            find.Salary = Salary;
            find.WhenStarted = WhenStarted;
            find.WhenLeft = WhenLeft;
            find.ReasonType = ReasonType;
            find.Reason = Reason.Trim();
            _context.Entry(find).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("AllLastWorks", "Practitioner", new { id = empId });
        }

        public void GetInfo(EducationsToEmployee educationsToEmployee, int? id)
        {
            ViewData["EducationTypeId"] = educationsToEmployee.Education.Profession.UniFaculty.EducationTypeToUniversity.EducationTypeId;
            ViewData["UniversityAboutEducationType"] = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false &&
            w.Universities.Status != false && w.EducationTypeId == (int)ViewData["EducationTypeId"]).ToList();
            ViewData["UniversityId"] = educationsToEmployee.Education.Profession.UniFaculty.EducationTypeToUniversity.UniversitiesId;
            ViewData["FacultyId"] = educationsToEmployee.Education.Profession.UniFacultyId;
            ViewData["AllFacultyAboutUniId"] = _context.UniFaculties.Where(w => w.Status != false && w.EducationTypeToUniversity.Universities.Status != false
            && w.EducationTypeToUniversity.EducationType.Status != false && w.EducationTypeToUniversity.UniversitiesId == (int)ViewData["UniversityId"]).ToList();
            ViewData["ProfessionId"] = educationsToEmployee.Education.ProfessionId;
            ViewData["AllProfessionAboutFacultyId"] = _context.Professions.Where(w => w.Status != false && w.UniFaculty.Status != false
            && w.UniFaculty.EducationTypeToUniversity.Universities.Status != false
            && w.UniFaculty.EducationTypeToUniversity.EducationType.Status != false && w.UniFacultyId == (int)ViewData["FacultyId"]).ToList();
        }  
    }
}
