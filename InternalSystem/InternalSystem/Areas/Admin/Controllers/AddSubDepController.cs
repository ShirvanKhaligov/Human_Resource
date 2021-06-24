using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.Departments;
using InternalSystem.Areas.InternalHR.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class AddSubDepController : Controller
    {
        private readonly InternalSysDBContext _context;
        public AddSubDepController(InternalSysDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DeptAndSubDeptVM allModelVM = new DeptAndSubDeptVM()
            {
                SubDepartments = _context.SubDepartments.Where(p => p.Status != false &&
                                                               p.DepartmentToCompany.Department.Status != false &&
                                                               p.DepartmentToCompany.Company.status != false).OrderByDescending(a => a.Id).Take(5),

            };
            return View(allModelVM);
        }

        public IActionResult AllSubDepartmant()
        {
            DeptAndSubDeptVM allModelVM = new DeptAndSubDeptVM()
            {
                SubDepartments = _context.SubDepartments.Where(p => p.Status != false &&
                                                                p.DepartmentToCompany.Department.Status != false &&
                                                                p.DepartmentToCompany.Company.status != false).OrderByDescending(a => a.Id).ToList()
            };
            return View(allModelVM);
        }

        public IActionResult Create()
        {
            DeptAndSubDeptVM allModelVM = new DeptAndSubDeptVM
            {
                Departments = _context.Departments.Where(d => d.Status != false).ToList(),
                Companiess = _context.Companies.Where(c => c.status != false).ToList()
            };
            return View(allModelVM);
        }

        [HttpGet]
        public IActionResult CreateDepLoad(int id)
        {
            //List<Department> departments = _context.Departments.Where(f => f.Status != false&&f).ToList();
            List<DepartmentToCompany> Department = _context.DepartmentToCompanies.Where(d => d.Department.Status != false && d.Company.Id == id).ToList();
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_GetDepartmentPartial.cshtml", Department);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DeptAndSubDeptVM deptAndSub, int? CompanyId, int? depId)
        {
            DeptAndSubDeptVM vM = new DeptAndSubDeptVM()
            {
                Departments = _context.Departments.Where(d => d.Status != false).ToList(),
                Companiess = _context.Companies.Where(c => c.status != false).ToList()
            };
            if (string.IsNullOrWhiteSpace(deptAndSub.SubDepartment.Name))
            {
                return View(vM);
            }

            if (CompanyId == 0 || CompanyId == null)
            {
                ModelState.AddModelError("Companies.Name", "Şöbəni daxil edin");
                return View(vM);
            }
            if (depId == 0 || depId == null)
            {
                ModelState.AddModelError("Department.Name", "Şöbəni daxil edin");
                return View(vM);
            }
            var db = _context.SubDepartments.Any(s => s.DepartmentToCompany.DepartmentId == depId && s.DepartmentToCompany.CompanyId == CompanyId
            && s.Name == deptAndSub.SubDepartment.Name);
            if (db)
            {
                ModelState.AddModelError("SubDepartment.Name", "Bu adda alt şöbə artiq mövcuddur");
                return View(vM);
            }

            var depAndCompanyId = _context.DepartmentToCompanies.Where(d => d.CompanyId == CompanyId && d.DepartmentId == depId).FirstOrDefault();
            if (depAndCompanyId == null)
            {
                return NotFound();
            }
            SubDepartment newsubDepartment = new SubDepartment()
            {
                Name = deptAndSub.SubDepartment.Name.Trim(),
                DepartmentToCompanyId = depAndCompanyId.Id,
                Status = true
            };

            await _context.SubDepartments.AddAsync(newsubDepartment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null) return NotFound();
            var subDepDb = await _context.SubDepartments.FindAsync(Id);
            if (subDepDb == null) return NotFound();
            DeptAndSubDeptVM deptVM = new DeptAndSubDeptVM()
            {
                Companiess = _context.Companies.Where(c => c.status != false),
                DepartmentToCompanies = _context.DepartmentToCompanies.Where(d => d.CompanyId == subDepDb.DepartmentToCompany.CompanyId && d.Department.Status != false),
                CompaniesId = subDepDb.DepartmentToCompany.CompanyId,
                DepartmentId = subDepDb.DepartmentToCompany.DepartmentId,
                SubDepartment = subDepDb
            };
            return View(deptVM);
        }

        public IActionResult GetDepartment(int Id)
        {
            List<DepartmentToCompany> Department = _context.DepartmentToCompanies.Where(d => d.Department.Status != false && d.Company.Id == Id).ToList();
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_GetDepartmentEditPartial.cshtml", Department);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, DeptAndSubDeptVM deptVM, int? compEditId, int? DeptEditId)
        {
            if (id == null) return NotFound();
            DeptAndSubDeptVM dept = new DeptAndSubDeptVM()
            {
                Departments = _context.Departments.Where(d => d.Status != false).ToList(),
                Companiess = _context.Companies.Where(d => d.status != false).ToList(),
                DepartmentToCompanies = _context.DepartmentToCompanies.Where(d => d.DepartmentId == DeptEditId && d.CompanyId == compEditId)
            };
            if (compEditId == 0 || compEditId == null)
            {
                ViewData["error_compName"] = "Zəhmət olmasa şirkət adını daxil edin";
                return View(dept);
            }
            if (DeptEditId == 0 || DeptEditId == null)
            {
                ViewData["error_deptName"] = "Zəhmət olmasa şöbə adını daxil edin";
                return View(dept);
            }

            var subDepartmentDb = await _context.SubDepartments.FindAsync(id);
            if (subDepartmentDb == null) return RedirectToAction(nameof(Index));

            if (string.IsNullOrWhiteSpace(deptVM.SubDepartment.Name))
            {
                return View(dept);
            }
            var checkCompSubdDept = _context.SubDepartments.Any(d => d.DepartmentToCompany.DepartmentId == DeptEditId && d.DepartmentToCompany.CompanyId == compEditId && d.Name == deptVM.SubDepartment.Name);
            if (checkCompSubdDept)
            {
                ModelState.AddModelError("SubDepartment.Name", "Bu adda alt şöbə artiq mövcuddur");
                return View(dept);
            }

            subDepartmentDb.DepartmentToCompany.CompanyId = compEditId;
            subDepartmentDb.DepartmentToCompany.DepartmentId = DeptEditId;
            subDepartmentDb.Name = deptVM.SubDepartment.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int? SubDepartmentId)
        {
            SubDepartment dpmt = _context.SubDepartments.Find(SubDepartmentId);
            dpmt.Status = false;
            _context.Entry(dpmt).State = EntityState.Modified;
            _context.SaveChanges();
            DeptAndSubDeptVM allModelVM = new DeptAndSubDeptVM()
            {
                Companiess = _context.Companies.Where(c => c.status != false),
                Departments = _context.Departments.Where(d => d.Status != false),
                SubDepartments = _context.SubDepartments.Where(s => s.Status != false && s.DepartmentToCompany.Department.Status != false && s.DepartmentToCompany.Company.status != false)
            };
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_SubDepartmentPartial.cshtml", allModelVM);
        }

    }
}
