using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Departments;
using InternalSystem.Areas.InternalHR.ViewModels;
using InternalSystem.Extentions;
using InternalSystem.Security;
using InternalSystem.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InternalSystem.Areas.InternalHR.Controllers
{
    [Area("InternalHR")]
    [Authorize(Roles = "HumanResource,HrDepartmentBoss")]

    public class EmployeeController : Controller
    {
        private readonly IMemoryCache _memoryCache;
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        private readonly IDataProtector dataProtector;
        public EmployeeController(UserManager<AppUser> userManager, InternalSysDBContext context,
            IHostingEnvironment env,IMemoryCache memoryCache,IDataProtectionProvider dataProtectionProvider, DataProtectionPurposeSetting dataProtectionPurposeSetting)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
            _memoryCache = memoryCache;
            dataProtector = dataProtectionProvider.CreateProtector(dataProtectionPurposeSetting.EmpolyeeIDRouteValue);
        }
    



        public async Task<IActionResult> Index(int? Id)
        {
            if (Id == null) return NotFound();
            AppUser findCurrentHR = await _userManager.FindByEmailAsync(User.Identity.Name);

            ViewData["DepId"] = Id;
            DepartmentToCompany dd = _context.DepartmentToCompanies.Where(d => d.DepartmentId == Id).FirstOrDefault();
            var c = dd.MenegerId;
            List<Emplooyee> allEmployeeWithTrue = _context.Emplooyeees.Where(w => w.Status != false &&
            w.IsWorking != false && w.IsCandidate == false && w.CompanyId == findCurrentHR.CompaniesId && w.Company.status != false &&
            ((w.Positions.SubDepartment.DepartmentToCompany.DepartmentId == Id &&
            w.Positions.SubDepartment.DepartmentToCompany.Department.Status != false) || w.Id == c)).OrderBy(w => w.Id).ToList();
            return View(allEmployeeWithTrue);
        }
        public async Task<IActionResult> AllEmployee()
        {
            AppUser findCurrentHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<Emplooyee> allEmployeeWithTrue = _context.Emplooyeees.Where(w => w.Status != false
            && w.IsWorking == true && w.CompanyId == findCurrentHR.CompaniesId && w.Company.status != false && w.IsCandidate == false).OrderBy(w => w.Id).ToList();
            return View(allEmployeeWithTrue);
        }

        public async Task<IActionResult> AllEmployeeWomans()
        {
            AppUser findCurrentHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            
            List<Emplooyee> allEmployeeWithTrue = _context.Emplooyeees.Where(w => w.Status != false
            && w.IsWorking == true && w.CompanyId == findCurrentHR.CompaniesId && w.Company.status != false && w.IsCandidate == false && w.GenderId==2).OrderBy(w => w.Id).ToList();
            return View(allEmployeeWithTrue);
        }
        public async Task<IActionResult> AllEmployeeMen()
        {
            AppUser findCurrentHR = await _userManager.FindByEmailAsync(User.Identity.Name);
          


            List<Emplooyee> allEmployeeWithTrue = _context.Emplooyeees.Where(w => w.Status != false
            && w.IsWorking == true && w.CompanyId == findCurrentHR.CompaniesId && w.Company.status != false && w.IsCandidate == false && w.GenderId == 1).OrderBy(w => w.Id).ToList();
            return View(allEmployeeWithTrue);
        }

        public static class CacheKeys
        {
            public static string Entry { get { return "_Entry"; } }
            public static string CallbackEntry { get { return "_Callback"; } }
            public static string CallbackMessage { get { return "_CallbackMessage"; } }
            public static string Parent { get { return "_Parent"; } }
            public static string Child { get { return "_Child"; } }
            public static string DependentMessage { get { return "_DependentMessage"; } }
            public static string DependentCTS { get { return "_DependentCTS"; } }
            public static string Ticks { get { return "_Ticks"; } }
            public static string CancelMsg { get { return "_CancelMsg"; } }
            public static string CancelTokenSource { get { return "_CancelTokenSource"; } }
        }

        public IActionResult CacheTryGetValueSet()
        {
            DateTime cacheEntry;

            // Look for cache key.
            if (!_memoryCache.TryGetValue(CacheKeys.Entry, out cacheEntry))
            {
                // Key not in cache, so get data.
                cacheEntry = DateTime.Now;

                // Set cache options.
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    // Keep in cache for this time, reset time if accessed.
                    .SetSlidingExpiration(TimeSpan.FromSeconds(3));

                // Save data in cache.
                _memoryCache.Set(CacheKeys.Entry, cacheEntry, cacheEntryOptions);
            }

            return View("Cache", cacheEntry);
        }
        public IActionResult CacheGetOrCreate()
        {
            var cacheEntry = _memoryCache.GetOrCreate(CacheKeys.Entry, entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromSeconds(3);
                return DateTime.Now;
            });

            return View("Cache", cacheEntry);
        }

        public async Task<IActionResult> CacheGetOrCreateAsynchronous()
        {
            var cacheEntry = await
                _memoryCache.GetOrCreateAsync(CacheKeys.Entry, entry =>
                {
                    entry.SlidingExpiration = TimeSpan.FromSeconds(3);
                    return Task.FromResult(DateTime.Now);
                });

            return View("Cache", cacheEntry);
        }


        public IActionResult CacheGet()
        {
            var cacheEntry = _memoryCache.Get<DateTime?>(CacheKeys.Entry);
            return View("Cache", cacheEntry);
        }

        public IActionResult CacheGetOrCreateAbs()
        {
            var cacheEntry = _memoryCache.GetOrCreate(CacheKeys.Entry, entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(10);
                return DateTime.Now;
            });

            return View("Cache", cacheEntry);
        }

        public IActionResult CacheGetOrCreateAbsSliding()
        {
            var cacheEntry = _memoryCache.GetOrCreate(CacheKeys.Entry, entry =>
            {
                entry.SetSlidingExpiration(TimeSpan.FromSeconds(3));
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(20);
                return DateTime.Now;
            });

            return View("Cache", cacheEntry);
        }




        public IActionResult Edit(int? id, int DepId)
        {
             

            if (id == null) return NotFound();
            var findEmpDb = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.Id == id).FirstOrDefault();
            if (findEmpDb == null) return NotFound();
            //IQueryable sql = from s in _context.EducationsToEmployees
            //                 join f in _context.Emplooyeees on s.EmplooyeeId equals f.Id
            //                 select new 
            //                 {
            //                     s.Id,
            //                     f.FirstName
            //                 };
            //sql.ToString();


            
            var educ = _context.EducationsToEmployees.Where(w => w.Education.Status != false && w.EmplooyeeId == id).ToList();
            var lang = _context.LanguageToEmployees.Where(l => l.LanguageToLanguageLevel.Status != false && l.EmplooyeeId == id).ToList();
            var comp = _context.ComputerToEmployees.Where(l => l.ComputerSkillToLevels.Status != false && l.EmplooyeeId == id).ToList();
            var fam = _context.RelationToEmployees.Where(r => r.Relation.Status != false && r.EmplooyeeId == id).ToList();
            var addition = _context.AdditionalInfos.Where(a => a.Emplooyee.Status!=false&&a.Emplooyee.IsWorking!=false&&a.EmplooyeeId == id).FirstOrDefault();
            RecruitmentCandidateVM vM = new RecruitmentCandidateVM
            {
                EducationsToEmployees = educ,
                LanguageToEmployees = lang,
                ComputerToEmployees = comp,
                RelationToEmployees = fam,
                Emplooyee = findEmpDb,
                AdditionalInfos = addition,
                EducationTypes = _context.EducationTypes.Where(w => w.Status != false).ToList(),
                MillitaryRanks = _context.MillitaryRanks.ToList(),
                EducationTypeToUnivercities = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false).ToList(),
                UniFaculties = _context.UniFaculties.Where(w => w.Status != false && w.EducationTypeToUniversity.Universities.Status != false
                && w.EducationTypeToUniversity.EducationType.Status != false).ToList(),
                Universities = _context.Universities.Where(w => w.Status != false).ToList(),
                Professions = _context.Professions.Where(w => w.Status != false && w.UniFaculty.Status != false && w.UniFaculty.EducationTypeToUniversity.Universities.Status != false).ToList(),
                Languages = _context.Languages.ToList(),
                LanguageLevels = _context.LanguageLevels.ToList(),
                ComputerLevels = _context.ComputerLevels.ToList(),
                RelationTypes = _context.RelationTypes.ToList(),
                DepartmentId = DepId

            };
            return View(vM);
        }

        //Edit Education
        [HttpPost]
        public async Task<JsonResult> EditEducation(int? clickid, int? eduId, int? uniId, int? facId, int? proId, DateTime startEdu, DateTime endEdu,int? accpHoney)
        {
            var eduEmp = _context.EducationsToEmployees.Where(e => e.EducationId == clickid).FirstOrDefault();
            if (eduId == null || eduId == 0)
            {
                return Json("null edu");
            }
            if (uniId == null || uniId == 0)
            {
                return Json("null uni");
            }
            if (startEdu.Year<1900 || endEdu.Year<1900 )
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
            if (accpHoney == null || accpHoney == 0)
            {
                return Json("null Accpt");
            }
            eduEmp.Education.EnteringTime = startEdu;
            eduEmp.Education.FinishTime = endEdu;
            eduEmp.Education.ProfessionId = proId;
            eduEmp.Education.AcceptHoney = accpHoney;
            await _context.SaveChangesAsync();
            return Json("success");
        }

        //Edit Language
        [HttpPost]
        public async Task<JsonResult> EditLanguage(int? clickid, int? idLang, int? idLangLev)
        {
            var langEmp = _context.LanguageToEmployees.Where(l => l.LanguageToLanguageLevelId == clickid).FirstOrDefault();
            if (idLang == null || idLang == 0)
            {
                return Json("null lang");
            }
            if (idLangLev == null || idLangLev == 0)
            {
                return Json("null langLevel");
            }
            langEmp.LanguageToLanguageLevel.LanguageId = idLang;
            langEmp.LanguageToLanguageLevel.LanguageLevelId = idLangLev;
            await _context.SaveChangesAsync();
            return Json("success");
        }

        //Edit Computer Skill
        [HttpPost]
        public async Task<JsonResult> EditComputerSkill(int? clickid, string txtComp, int? idCompLev)
        {
            var compEmp = _context.ComputerToEmployees.Where(l => l.ComputerSkillToLevelsId == clickid).FirstOrDefault();
            if (string.IsNullOrWhiteSpace(txtComp))
            {
                return Json("null comp");
            }
            if (idCompLev == null || idCompLev == 0)
            {
                return Json("null compLevel");
            }
            compEmp.ComputerSkillToLevels.ComputerLevelsId = idCompLev;
            compEmp.ComputerSkillToLevels.ComputerSkillsName.Name = txtComp.Trim();
            await _context.SaveChangesAsync();
            return Json("success");
        }

        //Edit Family
        [HttpPost]
        public async Task<JsonResult> EditFamily(int? clickid, int? idSlct, string txtName, string txtSurname, string txtFatherName, string txtNumber, string txtAddress, string txtWork,string txtWordkPsNam)
        {
            var famEmp = _context.RelationToEmployees.Where(r => r.RelationId == clickid).FirstOrDefault();
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
            if (string.IsNullOrWhiteSpace(txtWork))
            {
                return Json("null workPsN");
            }
            famEmp.Relation.Name = txtName.Trim();
            famEmp.Relation.Surname = txtSurname.Trim();
            famEmp.Relation.FatherName = txtFatherName.Trim();
            famEmp.Relation.Number = txtNumber.Trim();
            famEmp.Relation.Adress = txtAddress.Trim();
            famEmp.Relation.WorkPlaceName = txtWork.Trim();
            famEmp.Relation.WorkPlacePositionName = txtWordkPsNam.Trim();
            famEmp.Relation.RelationTypeId = idSlct;
            await _context.SaveChangesAsync();
            return Json("success");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, RecruitmentCandidateVM recruitmentCandidate, string MilitaryStatus,int? mltRank)
        {
            if (id == null) return NotFound();
            var findEmpDb = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.Id == id).FirstOrDefault();
            if (findEmpDb == null) return NotFound();
            AppUser userEmp = await _userManager.FindByEmailAsync(findEmpDb.Email);
            var educ = _context.EducationsToEmployees.Where(w => w.Education.Status != false && w.EmplooyeeId == id).ToList();
            var lang = _context.LanguageToEmployees.Where(l => l.LanguageToLanguageLevel.Status != false && l.EmplooyeeId == id).ToList();
            var comp = _context.ComputerToEmployees.Where(l => l.ComputerSkillToLevels.Status != false && l.EmplooyeeId == id).ToList();
            var fam = _context.RelationToEmployees.Where(r => r.Relation.Status != false && r.EmplooyeeId == id).ToList();
            var addition = _context.AdditionalInfos.Where(e => e.EmplooyeeId == id && e.Emplooyee.Status != false && e.Emplooyee.IsWorking != false).FirstOrDefault();
            RecruitmentCandidateVM vM = new RecruitmentCandidateVM
            {

                EducationsToEmployees = educ,
                LanguageToEmployees = lang,
                ComputerToEmployees = comp,
                RelationToEmployees = fam,
                Emplooyee = findEmpDb,
                AdditionalInfos = addition,
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false).ToList(),
                EducationTypes = _context.EducationTypes.Where(w => w.Status != false).ToList(),
                MillitaryRanks = _context.MillitaryRanks.ToList(),
                EducationTypeToUnivercities = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false).ToList(),
                UniFaculties = _context.UniFaculties.Where(w => w.Status != false && w.EducationTypeToUniversity.Universities.Status != false
                && w.EducationTypeToUniversity.EducationType.Status != false).ToList(),
                Universities = _context.Universities.Where(w => w.Status != false).ToList(),
                Professions = _context.Professions.Where(w => w.Status != false && w.UniFaculty.Status != false && w.UniFaculty.EducationTypeToUniversity.Universities.Status != false).ToList(),
                Languages = _context.Languages.ToList(),
                LanguageLevels = _context.LanguageLevels.ToList(),
                ComputerLevels = _context.ComputerLevels.ToList(),
                RelationTypes = _context.RelationTypes.ToList(),
            };
            //Check personal information
            if (ModelState["FirstName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Lastname"].ValidationState == ModelValidationState.Invalid ||
                ModelState["FatherName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["IdCard"].ValidationState == ModelValidationState.Invalid ||
                ModelState["FinCode"].ValidationState == ModelValidationState.Invalid)
            {
                return View(vM);
            }
            //check military null or not null
            if (MilitaryStatus == null)
            {
                ViewData["error_military"] = "Zəhmət olmasa seçin";
                return View(vM);
            }
            var searchMilitarystatusNo = _context.MillitaryStatuses.Where(m => m.Name == "No").FirstOrDefault().Id;
            if (MilitaryStatus == "noo")
            {
                findEmpDb.MillitaryStatusId = searchMilitarystatusNo;

            }
            else if (MilitaryStatus == "yess")
            {
                if (mltRank == 0 || mltRank == null)
                {
                    ViewData["error_militaryRank"] = "Zəhmət olmasa hərbi rütbəni seçin";
                    return View(vM);
                }
                var getMilStatusId = _context.MillitaryStatuses.Where(m => m.MillitaryRankId == mltRank).FirstOrDefault().Id;
                findEmpDb.MillitaryStatusId = getMilStatusId;
            }
            //Check image
            if (recruitmentCandidate.PhotoUpd != null)
            {
                if (!recruitmentCandidate.PhotoUpd.IsImage())
                {
                    ModelState.AddModelError("PhotoUpd", "Şəkil faylı seçin");
                    return View(vM);
                }

                if (!recruitmentCandidate.PhotoUpd.ImageSize(2))
                {
                    ModelState.AddModelError("PhotoUpd", "Şəkilin ölçüsü 2Mb-dan artıq ola bilməz");
                    return View(vM);
                }
                string filename = await recruitmentCandidate.PhotoUpd.CopyImage(_env.WebRootPath, "user");
                Utility.DeleteImageFromFolder(_env.WebRootPath, findEmpDb.Image);
                
                findEmpDb.Image = filename;
                userEmp.Image = filename;

            }

            var checkIdCard = _context.Emplooyeees.Where(w => w.IdCard == recruitmentCandidate.IdCard && w.Id != findEmpDb.Id&&w.CompanyId==findEmpDb.CompanyId&&w.Status!=false&&w.IsWorking!=false).FirstOrDefault();
            if (checkIdCard != null)
            {
                ViewData["error_idcard_same"] = "Bu seriya nömrəsində artıq işçi var";
                return View(vM);
            }
            else
            {
                var checkFinCode = _context.Emplooyeees.Where(w => w.FinCode == recruitmentCandidate.FinCode && w.Id != findEmpDb.Id && w.CompanyId == findEmpDb.CompanyId && w.Status != false && w.IsWorking != false).FirstOrDefault();
                if (checkFinCode != null)
                {
                    ViewData["error_fincard_same"] = "Bu fin kodda artıq işçi var";
                    return View(vM);
                }
                else
                {
                    findEmpDb.FinCode = recruitmentCandidate.FinCode.Trim();
                    findEmpDb.IdCard = recruitmentCandidate.IdCard.Trim();
                }
            }

            if (recruitmentCandidate.FirstName!=null)
            {
                userEmp.Name = recruitmentCandidate.FirstName.Trim();
            }
            if (recruitmentCandidate.Lastname != null)
            {
                userEmp.Surname = recruitmentCandidate.Lastname.Trim();
            }
            if (recruitmentCandidate.FatherName != null)
            {
                userEmp.FatherName = recruitmentCandidate.FatherName.Trim();
            }

            findEmpDb.FirstName = recruitmentCandidate.FirstName.Trim();
            findEmpDb.Lastname = recruitmentCandidate.Lastname.Trim();
            findEmpDb.FatherName = recruitmentCandidate.FatherName.Trim();

            //Check Word
            if (recruitmentCandidate.WordUpd != null)
            {
                if (!recruitmentCandidate.WordUpd.IsWord())
                {
                    ModelState.AddModelError("WordUpd", "Zəhmət olmasa word faylını düzgün seçin");
                    return View(vM);
                }
                if (!recruitmentCandidate.WordUpd.WordSize(4))
                {
                    ModelState.AddModelError("WordUpd", "Word faylının ölçüsü 4Mb-dan artıq ola bilməz");
                    return View(vM);
                }
            }
            //Check Pdf
            if (recruitmentCandidate.PdfUpd != null)
            {
                if (!recruitmentCandidate.PdfUpd.IsPdf())
                {
                    ModelState.AddModelError("PdfUpd", "Zəhmət olmasa pdf faylını düzgün seçin");
                    return View(vM);
                }
                if (!recruitmentCandidate.PdfUpd.PdfSize(4))
                {
                    ModelState.AddModelError("PdfUpd", "Pdf faylının ölçüsü 4Mb-dan artıq ola bilməz");
                    return View(vM);
                }
            }
            //Check Cert Img
            if (recruitmentCandidate.PhotoCertificateUpd != null)
            {
                if (!recruitmentCandidate.PhotoCertificateUpd.IsImage())
                {
                    ModelState.AddModelError("PhotoCertificateUpd", "Zəhmət olmasa sonuncu şəkili düzgün seçin");
                    return View(vM);
                }
                if (!recruitmentCandidate.PhotoCertificateUpd.ImageSize(3))
                {
                    ModelState.AddModelError("PhotoCertificateUpd", "Sonuncu şəkilin ölçüsü 3Mb-dan artıq ola bilməz");
                    return View(vM);
                }
            }
            if (recruitmentCandidate.WordUpd != null ||
               recruitmentCandidate.PdfUpd != null ||
               recruitmentCandidate.PhotoCertificateUpd != null)
            {
                if (addition==null)
                {
                    var Addition = new AdditionalInfos
                    {
                        EmplooyeeId = findEmpDb.Id
                    };
                    if (recruitmentCandidate.WordUpd != null)
                    {
                        string filenameWord = await recruitmentCandidate.WordUpd.CopyWord(_env.WebRootPath, "userOtherDocs/word");
                        Addition.MicrosoftWord = filenameWord;
                    }
                    if (recruitmentCandidate.PdfUpd != null)
                    {
                        string filenamePdf = await recruitmentCandidate.PdfUpd.CopyPdf(_env.WebRootPath, "userOtherDocs/pdf");
                        Addition.AdobePdf = filenamePdf;
                    }
                    if (recruitmentCandidate.PhotoCertificateUpd != null)
                    {
                        string filenameImg = await recruitmentCandidate.PhotoCertificateUpd.CopyImage(_env.WebRootPath, "userOtherDocs/img");
                        Addition.AdditionCertImage = filenameImg;
                    }
                    await _context.AdditionalInfos.AddAsync(Addition);
                }
                else
                {
                    if (recruitmentCandidate.WordUpd != null)
                    {
                        string filenameWord = await recruitmentCandidate.WordUpd.CopyWord(_env.WebRootPath, "userOtherDocs/word");
                        if (addition.MicrosoftWord != null)
                        {
                            Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, addition.MicrosoftWord);
                        }
                        addition.MicrosoftWord = filenameWord;
                    }
                    if (recruitmentCandidate.PdfUpd != null)
                    {
                        string filenamePdf = await recruitmentCandidate.PdfUpd.CopyPdf(_env.WebRootPath, "userOtherDocs/pdf");
                        if (addition.AdobePdf!=null)
                        {
                            Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, addition.AdobePdf);
                        }
                        addition.AdobePdf = filenamePdf;
                    }
                    if (recruitmentCandidate.PhotoCertificateUpd != null)
                    {
                        string filenameImg = await recruitmentCandidate.PhotoCertificateUpd.CopyImage(_env.WebRootPath, "userOtherDocs/img");
                        if (addition.AdditionCertImage != null)
                        {
                            Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, addition.AdditionCertImage);
                        }
                        addition.AdditionCertImage = filenameImg;
                    }
                }
                
            }

            //Check Scan Pdf
            if (recruitmentCandidate.ScanCommandPhotoUpdate != null)
            {
                if (!recruitmentCandidate.ScanCommandPhotoUpdate.IsPdf())
                {
                    ModelState.AddModelError("ScanCommandPhotoUpdate", "Zəhmət olmasa skan pdf faylını düzgün seçin");
                    return View(vM);
                }
                if (!recruitmentCandidate.ScanCommandPhotoUpdate.PdfSize(3))
                {
                    ModelState.AddModelError("ScanCommandPhotoUpdate", "Skan pdf faylının ölçüsü 3Mb-dan artıq ola bilməz");
                    return View(vM);
                }
                if (findEmpDb.ScanCommand == null)
                {
                    string filenameScanPdf = await recruitmentCandidate.ScanCommandPhotoUpdate.CopyPdf(_env.WebRootPath, "userOtherDocs/pdf");
                    findEmpDb.ScanCommand = filenameScanPdf;
                }
                else
                {
                    string filenameScanPdf = await recruitmentCandidate.ScanCommandPhotoUpdate.CopyPdf(_env.WebRootPath, "userOtherDocs/pdf");
                    Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, findEmpDb.ScanCommand);
                    findEmpDb.ScanCommand = filenameScanPdf;
                }
            }

            
            await _context.SaveChangesAsync();
            //return RedirectToAction("Edit", "Employee", new { id = id });
            //return RedirectToAction("Index","Employee");
            var findDepRedirectToIndex = findEmpDb.Positions.SubDepartment.DepartmentToCompany.DepartmentId;
            return RedirectToAction("Index", "Employee", new { Id = findDepRedirectToIndex });
        }

        [HttpGet]
        public async Task<IActionResult> searchEmp(string getName)
        {
            AppUser finduser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (getName != null)
            {
                var findEmpss = _context.Emplooyeees.Where(w => w.Status != false && w.IsWorking != false &&
                w.CompanyId == finduser.CompaniesId && (w.FirstName.Contains(getName) || w.Lastname.Contains(getName))).OrderBy(w => w.FirstName).ToList();
                return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_EmployeeListForSearch.cshtml", findEmpss);
            }
            var findEmps = _context.Emplooyeees.Where(w => w.Status != false && w.IsWorking != false &&
            w.CompanyId == finduser.CompaniesId).OrderBy(w => w.FirstName).ToList();
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_EmployeeListForSearch.cshtml", findEmps);
        }
        public IActionResult Detail(int? id, int DepId)
        {
            if (id == null) return NotFound();
            EmployeeAllDataDetailVM detailVM = new EmployeeAllDataDetailVM()
            {
                //Emplooyee = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking == true && e.Id == id).FirstOrDefault(),
                EducationsToEmployees = _context.EducationsToEmployees.Where(e => e.Education.Status != false && e.EmplooyeeId == id).ToList(),
                School = _context.Schools.Where(s => s.EducationType.Status != false && s.EmplooyeeId == id).FirstOrDefault(),
                PhoneNumberToEmployee = _context.PhoneNumberToEmployees.Where(p => p.EmplooyeeID == id).FirstOrDefault(),
                CommandsToEmployee = _context.CommandsToEmployees.Where(c => c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false && c.EmplooyeeId == id &&
                                                                        c.Command.Name == "İşə qəbul").FirstOrDefault(),
                LanguageToEmployees = _context.LanguageToEmployees.Where(l => l.LanguageToLanguageLevel.Status != false && l.EmplooyeeId == id).ToList(),
                ComputerToEmployees = _context.ComputerToEmployees.Where(c => c.ComputerSkillToLevels.Status != false && c.EmplooyeeId == id).ToList(),
                RelationToEmployees = _context.RelationToEmployees.Where(r => r.Relation.Status != false && r.EmplooyeeId == id).ToList(),
                DepartmentId = DepId,
                DepartmentToCompany = _context.DepartmentToCompanies.Where(d => d.MenegerId == id).FirstOrDefault()
            };
            if (detailVM == null) return NotFound();
            return View(detailVM);
        }

        //public IActionResult Detail(int? id)
        //{
        //    //image hr
        //    //var mini_image_nav_hr = User.Identity.Name;
        //    //AppUser appUser = await _userManager.FindByEmailAsync(mini_image_nav_hr);
        //    //ViewData["image_hr"] = appUser.Image;
        //    //ViewData["name_hr"] = appUser.Name + " " + appUser.Surname;
        //    //ViewData["company_image_hr"] = appUser.Companies.Image;

        //    if (id == null) return NotFound();
        //    EmployeeAllDataDetailVM detailVM = new EmployeeAllDataDetailVM()
        //    {
        //        Emplooyee=_context.Emplooyeees.Where(e=>e.Status!=false&&e.IsWorking==true&&e.Id==id).FirstOrDefault(),
        //        EducationsToEmployees=_context.EducationsToEmployees.Where(e=>e.Education.Status!=false&&e.EmplooyeeId==id).ToList(),
        //        School=_context.Schools.Where(s=>s.EducationType.Status!=false&&s.EmplooyeeId==id).FirstOrDefault(),
        //        PhoneNumberToEmployee=_context.PhoneNumberToEmployees.Where(p=>p.EmplooyeeID==id).FirstOrDefault()
        //    };
        //    if (detailVM == null) return NotFound();
        //    return View(detailVM);
        //}


    }
}
