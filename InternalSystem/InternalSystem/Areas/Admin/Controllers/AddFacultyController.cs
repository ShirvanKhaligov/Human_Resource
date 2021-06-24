using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.Education;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using static InternalSystem.Utilities.Utility;

namespace InternalSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class AddFacultyController : Controller
    {
        private readonly InternalSysDBContext _context;
        public AddFacultyController(InternalSysDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var uniFac = _context.UniFaculties.Where(w => w.Status != false && w.EducationTypeToUniversity.Universities.Status != false)
                .OrderBy(w => w.EducationTypeToUniversity.Universities.Name).Take(5);

            return View(uniFac);
        }
        //[HttpGet]
        public IActionResult Create()
        {
            var universityfaculty = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false)
                .OrderBy(w => w.Universities.Name).ToList();
            ViewData["universityList"] = universityfaculty;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int EducationTypeToUniversityId, UniFaculty newfaculty)
        {
            if (ModelState["Name"].ValidationState != ModelValidationState.Invalid)
            {
                if (EducationTypeToUniversityId == 0)
                {
                    ViewData["noneUniversity"] = "Zəhmət olmasa Universiteti seçin!!";
                    var universityfaculties = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false)
                        .OrderBy(w => w.Universities.Name).ToList();
                    ViewData["universityList"] = universityfaculties;
                    return View(newfaculty);
                }
                var checkFaculty = _context.UniFaculties.Where(w => w.Status != false && w.Name.Trim() == newfaculty.Name.Trim() && w.EducationTypeToUniversityId == EducationTypeToUniversityId).FirstOrDefault();
                if (checkFaculty == null)
                {
                    newfaculty.Status = true;
                    newfaculty.EducationTypeToUniversityId = EducationTypeToUniversityId;
                    await _context.UniFaculties.AddAsync(newfaculty);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                ViewData["existsFaculty"] = "Bu fakultə artıq mövcuddur!!";
                var universityfaculty = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false)
                    .OrderBy(w => w.Universities.Name).ToList();
                ViewData["universityList"] = universityfaculty;
                return View(newfaculty);
            }
            else
            {
                var universityfaculties = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false).ToList();
                ViewData["universityList"] = universityfaculties;
                return View();
            }
        }
        public async Task<IActionResult> DeleteFaculty(int FacultyId)
        {
            UniFaculty uniFaculty = await _context.UniFaculties.FindAsync(FacultyId);
            uniFaculty.Status = false;
            _context.Entry(uniFaculty).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            var faculties = _context.UniFaculties.Where(w => w.Status != false && w.EducationTypeToUniversity.Universities.Status != false).OrderBy(w => w.Name).ToList();
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_Facultiespartiol.cshtml", faculties);
        }
        public async Task<IActionResult> AllFaculties()
        {
            var faculties =await _context.UniFaculties.Where(w => w.Status != false && w.EducationTypeToUniversity.Universities.Status != false)
                .OrderBy(w => w.EducationTypeToUniversity.Universities.Name).ToListAsync();
            return View(faculties);
        }
        [HttpGet]
        public async Task<IActionResult> EditFaculty(int Id)
        {
            UniFaculty faculty = await _context.UniFaculties.FindAsync(Id);
            var universityfaculty = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false)
                .OrderBy(w => w.Universities.Name).ToList();
            ViewData["universityList"] = universityfaculty;
            return View(faculty);
        }
        [HttpPost]
        public async Task<IActionResult> EditFaculty(UniFaculty updatedFaculty, int EducationTypeToUniversityId)
        {
            if (ModelState["Name"].ValidationState != ModelValidationState.Invalid)
            {
                if (EducationTypeToUniversityId == 0)
                {
                    ViewData["noneUniversity"] = "Zəhmət olmasa Universiteti seçin!!";
                    var universityfacultiess = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false)
                        .OrderBy(w => w.Universities.Name).ToList();
                    ViewData["universityList"] = universityfacultiess;
                    return View(updatedFaculty);
                }
                UniFaculty checkFaculty = _context.UniFaculties.Where(w => w.Status != false && w.Name.Trim() == updatedFaculty.Name.Trim() && w.EducationTypeToUniversityId == EducationTypeToUniversityId).FirstOrDefault();
                if (checkFaculty == null)
                {
                    UniFaculty checkFacultyWithId = _context.UniFaculties.Find(updatedFaculty.Id);
                    checkFacultyWithId.EducationTypeToUniversityId = EducationTypeToUniversityId;
                    checkFacultyWithId.Name = updatedFaculty.Name;
                    //_context.Entry(checkFaculty).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(AllFaculties));
                }
                else
                {
                    ViewData["existsFaculty"] = "Bu fakultə artıq mövcuddur!!";
                    var universityfaculty = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false).ToList();
                    ViewData["universityList"] = universityfaculty;
                    return View(updatedFaculty);
                }
            }
            var universityfaculties = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false)
                .OrderBy(w => w.Universities.Name).ToList();
            ViewData["universityList"] = universityfaculties;
            return View(updatedFaculty);
        }
    }
}
