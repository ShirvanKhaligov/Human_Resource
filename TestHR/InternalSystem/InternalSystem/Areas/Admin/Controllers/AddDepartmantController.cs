using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.Departments;
using InternalSystem.Areas.InternalHR.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class AddDepartmantController : Controller
    {
        private readonly InternalSysDBContext _context;
        public AddDepartmantController(InternalSysDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DeptAndSubDeptVM deptVM = new DeptAndSubDeptVM()
            {
                Departments = _context.Departments.Where(d => d.Status != false),
                DepartmentToCompanies = _context.DepartmentToCompanies.Where(dc => dc.Company.status != false && dc.Department.Status != false).Include(c => c.Company).OrderByDescending(p => p.Id).Take(5)
            };
            return View(deptVM);
        }
        public IActionResult AllDepartmant()
        {
            DeptAndSubDeptVM deptVM = new DeptAndSubDeptVM()
            {
                DepartmentToCompanies = _context.DepartmentToCompanies.Where(dc => dc.Company.status != false && dc.Department.Status != false).OrderByDescending(p => p.Id).ToList(),
                Departments = _context.Departments.Where(p => p.Status != false)
            };
            return View(deptVM);
        }
        public IActionResult Create()
        {
            DeptAndSubDeptVM deptVM = new DeptAndSubDeptVM()
            {
                Companiess = _context.Companies.Where(c => c.status != false).ToList()
            };
            return View(deptVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DeptAndSubDeptVM deptAndSub)
        {
            DeptAndSubDeptVM deptVM = new DeptAndSubDeptVM()
            {
                Companiess = _context.Companies.Where(c => c.status != false)
            };
            if (ModelState["Department.Name"].ValidationState == ModelValidationState.Invalid)
            {
                return View(deptVM);
            }

            if (deptAndSub.CompaniesId == 0 || deptAndSub.CompaniesId == null)
            {
                ModelState.AddModelError("CompaniesId", "Zəhmət olmasa şirkəti seçin");
                return View(deptVM);
            }
            var departmentTo = _context.DepartmentToCompanies.Where(d => d.CompanyId == deptAndSub.CompaniesId && d.Department.Name == deptAndSub.Department.Name).FirstOrDefault();
            if (departmentTo != null)
            {
                ModelState.AddModelError("Companies.Name", "Bu adda şöbə artıq mövcuddur");
                return View(deptVM);
            }

            Department department = new Department()
            {
                Name = deptAndSub.Department.Name.Trim(),
                Status = true
            };
            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();

            var deptAndCompany = new DepartmentToCompany()
            {
                CompanyId = deptAndSub.CompaniesId,
                DepartmentId = department.Id
            };
            await _context.DepartmentToCompanies.AddAsync(deptAndCompany);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var departmentDb = await _context.DepartmentToCompanies
                                             .FirstOrDefaultAsync(p => p.Id == id);
            if (departmentDb == null) return NotFound();
            DeptAndSubDeptVM deptVM = new DeptAndSubDeptVM()
            {
                Department = departmentDb.Department,
                CompaniesId = departmentDb.CompanyId,
                Companiess = _context.Companies.Where(d => d.status != false)
            };
            if (deptVM == null) return NotFound();
            return View(deptVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, DeptAndSubDeptVM departmentToComp)
        {
            DepartmentToCompany departmentToCompany = await _context.DepartmentToCompanies.FindAsync(id);
            DeptAndSubDeptVM vM = new DeptAndSubDeptVM()
            {
                Companiess = _context.Companies.Where(d => d.status != false)
            };

            if (departmentToCompany == null)
            {
                return RedirectToAction(nameof(Index));
            }

            if (ModelState["Department.Name"].ValidationState == ModelValidationState.Invalid)
            {
                return View(vM);
            }
            if (departmentToComp.CompaniesId == 0 || departmentToComp.CompaniesId == null)
            {
                ViewData["error_company_dept"] = "Zəhmət olmasa şirkət seçin";
                return View(vM);
            }
            DepartmentToCompany checkDepartmentToCompany = _context.DepartmentToCompanies.Where(d => d.CompanyId == departmentToComp.CompaniesId && d.Department.Name == departmentToComp.Department.Name).FirstOrDefault();

            if (checkDepartmentToCompany != null)
            {
                ModelState.AddModelError("Department.Name", "Bu adda şöbə artıq mövcuddur");
                return View(vM);
            }

            departmentToCompany.Department.Name = departmentToComp.Department.Name;
            departmentToCompany.CompanyId = departmentToComp.CompaniesId;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int? DepartmentId)
        {
            Department dpmt = _context.Departments.Find(DepartmentId);
            dpmt.Status = false;
            _context.Entry(dpmt).State = EntityState.Modified;
            _context.SaveChanges();

            DeptAndSubDeptVM vM = new DeptAndSubDeptVM()
            {
                //Companiess = _context.Companies.Where(c => c.status != false),
                DepartmentToCompanies = _context.DepartmentToCompanies.Where(dc => dc.Company.status != false && dc.Department.Status != false).OrderByDescending(p => p.Id).ToList(),
                Departments = _context.Departments.Where(p => p.Status != false)
            };
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_DepartmentPartial.cshtml", vM);
        }
    }
}
