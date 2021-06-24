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

namespace InternalSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class AddProfessionController : Controller
    {
        private readonly InternalSysDBContext _context;
        public AddProfessionController(InternalSysDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allprofessions = _context.Professions.Where(w => w.Status != false && w.UniFaculty.Status != false && w.UniFaculty.EducationTypeToUniversity.Universities.Status != false)
                .OrderBy(w => w.UniFaculty.EducationTypeToUniversity.Universities.Name).Take(5);
            return View(allprofessions);
        }
       
        public IActionResult Create()
        {
            var universityfaculty = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false)
                            .OrderBy(w => w.Universities.Name).ToList();
            ViewData["allUniversities"] = universityfaculty;
            return View();
        }
        [HttpGet]
        public IActionResult GetFaculties(int educaEducationTypeToUnivercityId)
        {
            List<UniFaculty> uniFaculties = _context.UniFaculties.Where(w => w.Status != false && w.EducationTypeToUniversityId == educaEducationTypeToUnivercityId).ToList();
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_FacultiesSelectList.cshtml", uniFaculties);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Profession newProfession, int EducationTypeToUnivercityId)
        {
            if (ModelState["Name"].ValidationState != ModelValidationState.Invalid)
            {
                if (EducationTypeToUnivercityId == 0)
                {
                    var universityfaculties = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false)
                                .OrderBy(w => w.Universities.Name).ToList();
                    ViewData["allUniversities"] = universityfaculties;
                    ViewData["nonUniversity"] = "Zəhmət olmasa universitet seçin!!";
                    return View();
                }
                Profession CheckProfession = _context.Professions
                    .Where(w => w.Status != false && w.Name.Trim() == newProfession.Name.Trim() && w.UniFaculty.EducationTypeToUniversityId == EducationTypeToUnivercityId && w.UniFaculty.Status != false
                    && w.UniFaculty.EducationTypeToUniversity.Universities.Status != false && w.UniFacultyId == newProfession.UniFacultyId)
                    .FirstOrDefault();
                if (CheckProfession == null)
                {
                    newProfession.Status = true;
                    await _context.AddAsync(newProfession);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                ViewData["existsProfession"] = "Bu ixtisas artıq mövcuddur!!";
                var universityfaculty = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false)
                                .OrderBy(w => w.Universities.Name).ToList();
                ViewData["allUniversities"] = universityfaculty;
                return View();
            }
            else
            {
                var universityfaculties = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false)
                                 .OrderBy(w => w.Universities.Name).ToList();
                ViewData["allUniversities"] = universityfaculties;
                return View();
            }
        }

        public IActionResult AllProfessions()
        {
            var allprofessions = _context.Professions.Where(w => w.Status != false && w.UniFaculty.Status != false && w.UniFaculty.EducationTypeToUniversity.Universities.Status != false)
                .OrderBy(w => w.UniFaculty.EducationTypeToUniversity.Universities.Name).ToList();
            return View(allprofessions);
        }
        public async Task<IActionResult> DeleteProfession(int ProfessionId)
        {
            Profession profession = await _context.Professions.FindAsync(ProfessionId);
            if (profession == null)
            {
                return NotFound();
            }
            profession.Status = false;
            _context.Entry(profession).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            List<Profession> professions = _context.Professions.Where(w => w.Status != false && w.UniFaculty.Status != false && w.UniFaculty.Status != false && w.UniFaculty.EducationTypeToUniversity.Universities.Status != false).ToList();
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_ProfessionPartial.cshtml", professions);
        }
        int facultyId = 0;
        [HttpGet]
        public async Task<IActionResult> EditProfession(int Id)
        {
            Profession checkProfession = await _context.Professions.Where(w => w.UniFaculty.EducationTypeToUniversity.Universities.Status != false && w.Id == Id).FirstOrDefaultAsync();
            if (checkProfession == null)
            {
                return NotFound();
            }
            var universityfaculty = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false).OrderBy(w => w.Universities.Name).ToList();
            ViewData["keepFacultyId"] = checkProfession.UniFaculty.Id;
            ViewData["allUniversities"] = universityfaculty;
            foreach (var item in universityfaculty)
            {
                if (item.Id == checkProfession.UniFaculty.EducationTypeToUniversityId)
                {
                    facultyId = item.Id;
                }
            }
            var faculties = _context.UniFaculties.Where(w => w.Status != false && w.EducationTypeToUniversity.Universities.Status != false && w.EducationTypeToUniversityId == facultyId).ToList();
            ViewData["allFaculties"] = faculties;
            return View(checkProfession);
        }

        public Profession getInfo(Profession updatedProfession, Profession findProfWithId)
        {
            var universityfacultiesss = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false).OrderBy(w => w.Universities.Name).ToList();
            ViewData["allUniversities"] = universityfacultiesss;
            ViewData["keepFacultyId"] = findProfWithId.UniFaculty.Id;
            foreach (var item in universityfacultiesss)
            {
                if (item.Id == findProfWithId.UniFaculty.EducationTypeToUniversityId)
                {
                    facultyId = item.Id;
                }
            }
            var facultiesss = _context.UniFaculties.Where(w => w.Status != false && w.EducationTypeToUniversity.Universities.Status != false && w.EducationTypeToUniversityId == facultyId).ToList();
            ViewData["allFaculties"] = facultiesss;
            ViewData["existsProfession"] = "Bu ixtisas artıq mövcuddur!!";

            return updatedProfession;
        }

        [HttpPost]
        public async Task<IActionResult> EditProfession(Profession updatedProfession, int EducationTypeToUnivercityId)
        {
            Profession findProfWithId = await _context.Professions.Where(w => w.UniFaculty.EducationTypeToUniversity.Universities.Status != false && w.UniFaculty.Status != false && w.Status != false && w.Id == updatedProfession.Id).FirstOrDefaultAsync();
            updatedProfession.UniFaculty = findProfWithId.UniFaculty;
            if (ModelState["Name"].ValidationState != ModelValidationState.Invalid)
            {
                Profession checkProf = await _context.Professions.Where(w => w.UniFacultyId == updatedProfession.UniFacultyId && w.UniFaculty.EducationTypeToUniversityId == EducationTypeToUnivercityId && w.Name.Trim() == updatedProfession.Name.Trim()).FirstOrDefaultAsync();
                if (checkProf == null)
                {
                    if (findProfWithId.UniFaculty.EducationTypeToUniversityId == EducationTypeToUnivercityId && findProfWithId.UniFacultyId == updatedProfession.UniFacultyId && findProfWithId.Name.Trim() != updatedProfession.Name)
                    {
                        var checkName = _context.Professions.Where(w => w.Status != false && w.UniFaculty.EducationTypeToUniversity.Universities.Status != false && w.Name.Trim() == updatedProfession.Name.Trim() && w.UniFaculty.EducationTypeToUniversityId == EducationTypeToUnivercityId && w.UniFacultyId == updatedProfession.UniFacultyId).FirstOrDefault();
                        if (checkName == null)
                        {
                            findProfWithId.Name = updatedProfession.Name.Trim();
                            _context.Entry(findProfWithId).State = EntityState.Modified;
                            await _context.SaveChangesAsync();
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            return View(getInfo(updatedProfession, findProfWithId));
                        }
                    }
                    if (findProfWithId.UniFaculty.EducationTypeToUniversityId != EducationTypeToUnivercityId && findProfWithId.UniFacultyId != updatedProfession.UniFacultyId)
                    {
                        Profession checkFaculty = await _context.Professions.Where(w => w.Status != false && w.UniFaculty.Status != false && w.UniFaculty.EducationTypeToUniversity.Universities.Status != false && w.UniFacultyId == updatedProfession.UniFacultyId && w.UniFaculty.EducationTypeToUniversityId == EducationTypeToUnivercityId).FirstOrDefaultAsync();
                        if (checkFaculty != null)
                        {
                            findProfWithId.UniFaculty.EducationTypeToUniversityId = EducationTypeToUnivercityId;
                            findProfWithId.UniFacultyId = updatedProfession.UniFacultyId;
                            findProfWithId.Name = updatedProfession.Name;
                            _context.Entry(findProfWithId).State = EntityState.Modified;
                            await _context.SaveChangesAsync();
                            return RedirectToAction(nameof(AllProfessions));
                        }
                        else
                        {
                            var universityfaculties = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false)
                                         .OrderBy(w => w.Universities.Name).ToList();
                            return View(getInfo(updatedProfession, findProfWithId));
                        }
                    }
                    if (findProfWithId.UniFaculty.EducationTypeToUniversityId == EducationTypeToUnivercityId
                        && findProfWithId.UniFacultyId != updatedProfession.UniFacultyId)
                    {
                        Profession checkProfession = await _context.Professions.Where(w => w.Status != false && w.UniFaculty.Status != false && w.UniFaculty.EducationTypeToUniversity.Universities.Status != false && w.UniFacultyId == updatedProfession.UniFacultyId && w.UniFaculty.EducationTypeToUniversityId == EducationTypeToUnivercityId && w.Name.Trim() == findProfWithId.Name.Trim()).FirstOrDefaultAsync();
                        if (checkProfession == null)
                        {
                            findProfWithId.UniFaculty.EducationTypeToUniversityId = EducationTypeToUnivercityId;
                            findProfWithId.UniFacultyId = updatedProfession.UniFacultyId;
                            findProfWithId.Name = updatedProfession.Name;
                            _context.Entry(findProfWithId).State = EntityState.Modified;
                            await _context.SaveChangesAsync();
                            return RedirectToAction(nameof(AllProfessions));
                        }
                        else
                        {
                            return View(getInfo(updatedProfession, findProfWithId));
                        }
                    }
                }

                else
                {
                    return View(getInfo(updatedProfession, findProfWithId));
                }
            }
            var universityfacultiess = _context.EducationTypeToUnivercities.Where(w => w.EducationType.Status != false && w.Universities.Status != false).OrderBy(w => w.Universities.Name).ToList();
            ViewData["allUniversities"] = universityfacultiess;
            ViewData["keepFacultyId"] = findProfWithId.UniFaculty.Id;
            foreach (var item in universityfacultiess)
            {
                if (item.Id == findProfWithId.UniFaculty.EducationTypeToUniversityId)
                {
                    facultyId = item.Id;
                }
            }
            var facultiess = _context.UniFaculties.Where(w => w.Status != false && w.EducationTypeToUniversity.Universities.Status != false && w.EducationTypeToUniversityId == facultyId).ToList();
            ViewData["allFaculties"] = facultiess;
            return View(updatedProfession);
        }
    }
}
