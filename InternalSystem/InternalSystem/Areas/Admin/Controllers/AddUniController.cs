using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.Education;
using InternalSystem.Areas.InternalHR.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class AddUniController : Controller
    {
        private readonly InternalSysDBContext _context;
        public AddUniController(InternalSysDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var eduAndUni = _context.EducationTypeToUnivercities.Include(w => w.Universities).Include(w => w.EducationType)
                 .Where(w => w.Universities.Status != false && w.EducationType.Status != false)
                 .OrderBy(w => w.Universities.Name).Take(5);
            return View(eduAndUni);
        }
        public async Task<IActionResult> Create()
        {
            AllModelVM allModelVM = new AllModelVM()
            {
                EducationTypes = await _context.EducationTypes.Where(w => w.Status != false).OrderBy(p => p.Name).ToListAsync()
            };
            ViewData["EducationTypes"] = allModelVM.EducationTypes;
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Universities newUniversity, int EducationTypeId)
        {
            if (ModelState["Name"].ValidationState != ModelValidationState.Invalid)
            {
                if (EducationTypeId == 0)
                {
                    ViewData["NonEducationTypes"] = "Zəhmət olmasa təhsilin növünü seçin!!";
                    AllModelVM allModelVMM = new AllModelVM()
                    {
                        EducationTypes = await _context.EducationTypes.Where(w => w.Status != false).OrderBy(p => p.Name).ToListAsync()
                    };
                    ViewData["EducationTypes"] = allModelVMM.EducationTypes;
                    return View(newUniversity);
                }
                EducationTypeToUnivercity educationType = _context.EducationTypeToUnivercities.Include(w => w.Universities).Include(w => w.EducationType)
                    .Where(w => w.Universities.Name == newUniversity.Name && w.EducationType.Id == EducationTypeId && w.EducationType.Status != false && w.Universities.Status != false)
                    .FirstOrDefault();
                Universities check = _context.Universities.Where(w => w.Name == newUniversity.Name && w.Status != false).FirstOrDefault();
                if (check == null || (check != null && educationType == null))
                {
                    newUniversity.Name = newUniversity.Name.Trim();
                    newUniversity.Status = true;
                    EducationTypeToUnivercity newRel = new EducationTypeToUnivercity
                    {
                        Universities = newUniversity,
                        EducationTypeId = EducationTypeId,
                        UniversitiesId = newUniversity.Id,
                    };
                    await _context.EducationTypeToUnivercities.AddAsync(newRel);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewData["exitUniversity"] = "Bu təhsil növündə universitet artıq mövcuddur!!";
                    AllModelVM allModelVMs = new AllModelVM()
                    {
                        EducationTypes = await _context.EducationTypes.Where(w => w.Status != false).OrderBy(p => p.Name).ToListAsync()
                    };
                    ViewData["EducationTypes"] = allModelVMs.EducationTypes;
                    return View(newUniversity);
                }
            }
            AllModelVM allModelVM = new AllModelVM()
            {
                EducationTypes = await _context.EducationTypes.Where(w => w.Status != false).OrderBy(p => p.Name).ToListAsync()
            };
            ViewData["EducationTypes"] = allModelVM.EducationTypes;
            return View();
        }
        public IActionResult AllUniversities()
        {
            var eduAndUni = _context.EducationTypeToUnivercities.Include(w => w.Universities).Include(w => w.EducationType)
                .Where(w => w.Universities.Status != false && w.EducationType.Status != false).OrderBy(w => w.Universities.Name).ToList();
            return View(eduAndUni);

        }
        [HttpPost]
        public async Task<IActionResult> DeleteFromAllUn(int UniversityId)
        {
            Universities findUniversity = _context.Universities.Where(w => w.Id == UniversityId).FirstOrDefault();
            findUniversity.Status = false;
            _context.Entry(findUniversity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            var eduAndUni = _context.EducationTypeToUnivercities.Where(w => w.Universities.Status != false && w.EducationType.Status != false)
                .OrderBy(w => w.Universities.Name)
                .ToList();
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_UniversitiesPartial.cshtml", eduAndUni);
        }
        public static EducationTypeToUnivercity keepEditedUni;
        public async Task<IActionResult> EditUniversity(int Id)
        {
            EducationTypeToUnivercity find = _context.EducationTypeToUnivercities
                .Where(w => w.Universities.Status != false && w.Universities.Id == Id && w.EducationType.Status != false)
                .FirstOrDefault();
            find.Universities.Name.Trim();
            ViewData["UniName"] = find.Universities.Name.Trim();
            ViewData["UniId"] = find.Universities.Id;
            keepEditedUni = find;
            AllModelVM allModelVM = new AllModelVM()
            {
                EducationTypes = await _context.EducationTypes.Where(w => w.Status != false).OrderBy(p => p.Name).ToListAsync()
            };
            ViewData["EducationTypes"] = allModelVM.EducationTypes;
            return View(find);
        }
        public async Task<IActionResult> EditUniversitySubmit(string UniversityName, int EducationTypeId, int UniversityId)
        {
            if (string.IsNullOrWhiteSpace(UniversityName))
            {
                ViewData["emptyName"] = "Zəhmət olmasa xananı boş buraxmayın!!";
                AllModelVM allModelVMM = new AllModelVM()
                {
                    EducationTypes = await _context.EducationTypes.Where(w => w.Status != false).OrderBy(p => p.Name).ToListAsync()
                };
                ViewData["UniId"] = UniversityId;
                ViewData["EducationTypes"] = allModelVMM.EducationTypes;
                return View("EditUniversity", keepEditedUni);
            }
            UniversityName.Trim();
            List<EducationTypeToUnivercity> universities = _context.EducationTypeToUnivercities.Where(w => w.Universities.Name == UniversityName && w.Universities.Status != false).ToList();
            if (universities != null)
            {
                foreach (var Uni in universities)
                {
                    if (Uni.UniversitiesId != UniversityId && Uni.EducationTypeId == EducationTypeId)
                    {

                        ViewData["exitUniversity"] = "Bu təhsil növündə universitet artıq mövcuddur!!";
                        AllModelVM allModelVMs = new AllModelVM()
                        {
                            EducationTypes = await _context.EducationTypes.Where(w => w.Status != false).OrderBy(p => p.Name).ToListAsync()
                        };
                        ViewData["EducationTypes"] = allModelVMs.EducationTypes;
                        return View("EditUniversity", keepEditedUni);
                    }
                }
                EducationTypeToUnivercity educationType = _context.EducationTypeToUnivercities.Include(w => w.Universities).Include(w => w.EducationType)
                    .Where(w => w.EducationType.Status != false && w.Universities.Status != false && w.UniversitiesId == UniversityId && w.EducationTypeId == keepEditedUni.EducationTypeId)
                    .FirstOrDefault();
                Universities checkUserWithId = _context.Universities.Where(w => w.Id == UniversityId && w.Status != false).FirstOrDefault();
                checkUserWithId.Name = UniversityName;
                educationType.EducationTypeId = EducationTypeId;
                educationType.UniversitiesId = checkUserWithId.Id;
                _context.Entry(educationType).State = EntityState.Modified;
                _context.Entry(checkUserWithId).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AllUniversities));
            }
            else
            {
                ViewData["exitUniversity"] = "Bu təhsil növündə universitet artıq mövcuddur!!";
                AllModelVM allModelVMs = new AllModelVM()
                {
                    EducationTypes = await _context.EducationTypes.Where(w => w.Status != false).OrderBy(p => p.Name).ToListAsync()
                };
                ViewData["EducationTypes"] = allModelVMs.EducationTypes;
                return View("EditUniversity", keepEditedUni);
            }
        }
    }
}
