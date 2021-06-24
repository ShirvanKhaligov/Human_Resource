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
    public class AddPositionController : Controller
    {
        private readonly InternalSysDBContext _context;
        public AddPositionController(InternalSysDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DeptAndSubDeptVM deptAndSub = new DeptAndSubDeptVM
            {
                Positions = _context.Positions.Where(p => p.Status != false && p.SubDepartment.Status != false &&
                                                          p.SubDepartment.DepartmentToCompany.Department.Status != false &&
                                                          p.SubDepartment.DepartmentToCompany.Company.status != false)
                                                         .OrderByDescending(p => p.Id).Take(5)
            };
            return View(deptAndSub);
        }

        public IActionResult AllPosition()
        {
            DeptAndSubDeptVM deptAndSub = new DeptAndSubDeptVM
            {
                Positions = _context.Positions.Where(p => p.Status != false && p.SubDepartment.Status != false &&
                                                          p.SubDepartment.DepartmentToCompany.Department.Status != false &&
                                                          p.SubDepartment.DepartmentToCompany.Company.status != false)
                                                         .OrderByDescending(p => p.Id).ToList()
            };
            return View(deptAndSub);
        }

        public IActionResult Create()
        {
            DeptAndSubDeptVM deptAndSub = new DeptAndSubDeptVM
            {
                Companiess = _context.Companies.Where(c => c.status != false),
                Positions = _context.Positions.Where(p => p.Status != false && p.SubDepartment.Status != false &&
                                                        p.SubDepartment.DepartmentToCompany.Department.Status != false &&
                                                        p.SubDepartment.DepartmentToCompany.Company.status != false)
                                                         .OrderByDescending(p => p.Id).ToList()
            };
            return View(deptAndSub);
        }

        //Create Action.Department load in ajax 
        [HttpGet]
        public IActionResult CreateDeptLoad(int id)
        {
            List<DepartmentToCompany> departmentToCompanies = _context.DepartmentToCompanies
                .Where(w => w.CompanyId == id && w.Department.Status != false).ToList();
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_GetDeptPositionPartial.cshtml", departmentToCompanies);


        }
        //Create Action.SubDepartment load in ajax 
        [HttpGet]
        public IActionResult CreateSubDLoad(int id)
        {
            List<SubDepartment> subdepartments = _context.SubDepartments
                .Where(w => w.DepartmentToCompany.DepartmentId == id && w.Status != false).ToList();
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_GetSubDeptPositionPartial.cshtml", subdepartments);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DeptAndSubDeptVM deptAndSub, int? CompanyId, int? DepartmentId, int? SubDepartmentId)
        {
            DeptAndSubDeptVM vM = new DeptAndSubDeptVM()
            {
                Companiess = _context.Companies.Where(c => c.status != false).ToList(),
                Departments = _context.Departments.Where(d => d.Status != false).ToList(),
                SubDepartments = _context.SubDepartments.Where(s => s.Status != false).ToList(),
                Positions = _context.Positions.Where(s => s.Status != false).ToList()
            };
            //check null and 0
            if (CompanyId == 0 || CompanyId == null)
            {
                ViewData["companyNull"] = "Zəhmət olmasa şirkəti seçin";
                return View(vM);
            }
            if (DepartmentId == 0 || DepartmentId == null)
            {
                ViewData["DepartmentNull"] = "Zəhmət olmasa şöbəni seçin";
                return View(vM);
            }
            if (SubDepartmentId == 0 || SubDepartmentId == null)
            {
                ViewData["SubdepartmentNull"] = "Zəhmət olmasa alt şöbəni seçin";
                return View(vM);
            }
            if (ModelState["Position.Name"].ValidationState == ModelValidationState.Invalid)
            {
                return View(vM);
            }

            //check database
            var checkDb = _context.Positions.Any(p => p.Name == deptAndSub.Position.Name && p.Status != false && p.SubDepartment.Id == SubDepartmentId &&
                                                      p.SubDepartment.Status != false && p.SubDepartment.DepartmentToCompany.DepartmentId == DepartmentId &&
                                                      p.SubDepartment.DepartmentToCompany.Department.Status != false && p.SubDepartment.DepartmentToCompany.CompanyId == CompanyId &&
                                                      p.SubDepartment.DepartmentToCompany.Company.status != false);

            if (checkDb)
            {
                ModelState.AddModelError("Position.Name", "Bu adda vezife mövcuddur");
                return View(vM);
            }

            var newPosition = new Position
            {
                Name = deptAndSub.Position.Name.Trim(),
                SubDepartmentId = SubDepartmentId,
                Status = true
            };
            await _context.AddAsync(newPosition);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == 0 || id == null) return NotFound();
            var posDb = await _context.Positions.FindAsync(id);

            var posDbVM = new DeptAndSubDeptVM()
            {
                Position = posDb,
                Companiess = _context.Companies.Where(c => c.status != false),
                DepartmentToCompanies = _context.DepartmentToCompanies.Where(d => d.CompanyId == posDb.SubDepartment.DepartmentToCompany.CompanyId && d.Department.Status != false).ToList(),
                CompaniesId = posDb.SubDepartment.DepartmentToCompany.CompanyId,
                DepartmentId = posDb.SubDepartment.DepartmentToCompany.DepartmentId,
                SubDepartmentId = posDb.SubDepartmentId,
                SubDepartments = _context.SubDepartments.Where(c => c.Status != false && c.DepartmentToCompanyId == posDb.SubDepartment.DepartmentToCompany.Id).ToList(),
            };
            if (posDbVM == null) return NotFound();
            return View(posDbVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, DeptAndSubDeptVM deptAndSub, int? CompanyId, int? DepartmentId, int? SubDepartmentId)
        {
            DeptAndSubDeptVM vM = new DeptAndSubDeptVM()
            {
                Companiess = _context.Companies.Where(c => c.status != false).ToList(),
                Departments = _context.Departments.Where(d => d.Status != false).ToList(),
                SubDepartments = _context.SubDepartments.Where(s => s.Status != false).ToList(),
                Positions = _context.Positions.Where(s => s.Status != false).ToList()
            };
            if (CompanyId == 0 || CompanyId == null)
            {
                ViewData["companyNull"] = "Zəhmət olmasa şirkəti seçin";
                return View(vM);
            }
            if (DepartmentId == 0 || DepartmentId == null)
            {
                ViewData["DepartmentNull"] = "Zəhmət olmasa şöbəni seçin";
                return View(vM);
            }
            if (SubDepartmentId == 0 || SubDepartmentId == null)
            {
                ViewData["SubdepartmentNull"] = "Zəhmət olmasa alt şöbəni seçin";
                return View(vM);
            }
            if (ModelState["Position.Name"].ValidationState == ModelValidationState.Invalid)
            {
                return View(vM);
            }


            //check database
            var checkDb = _context.Positions.Any(p => p.Name == deptAndSub.Position.Name && p.Status != false && p.SubDepartment.Id == SubDepartmentId &&
                                                      p.SubDepartment.Status != false && p.SubDepartment.DepartmentToCompany.DepartmentId == DepartmentId &&
                                                      p.SubDepartment.DepartmentToCompany.Department.Status != false && p.SubDepartment.DepartmentToCompany.CompanyId == CompanyId &&
                                                      p.SubDepartment.DepartmentToCompany.Company.status != false);
            if (checkDb)
            {
                ModelState.AddModelError("Position.Name", "Bu adda vezife mövcuddur");
                return View(vM);
            }

            var position = _context.Positions.Where(w => w.Status != false).FirstOrDefault(p => p.Id == id);
            position.Name = deptAndSub.Position.Name;
            position.SubDepartmentId = SubDepartmentId;
            position.SubDepartment.DepartmentToCompany.CompanyId = CompanyId;
            position.SubDepartment.DepartmentToCompany.DepartmentId = DepartmentId;
            _context.Entry(position).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int PositionId)
        {
            Position position = await _context.Positions.FindAsync(PositionId);
            if (position == null)
            {
                return NotFound();
            }
            position.Status = false;
            _context.Entry(position).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            DeptAndSubDeptVM deptVm = new DeptAndSubDeptVM
            {
                Positions = _context.Positions.Where(p => p.Status != false && p.SubDepartment.Status != false &&
                                                        p.SubDepartment.DepartmentToCompany.Department.Status != false &&
                                                        p.SubDepartment.DepartmentToCompany.Company.status != false).ToList(),
                Departments = _context.Departments.Where(d => d.Status != false).ToList(),
                Companiess = _context.Companies.Where(c => c.status != false).ToList(),
                SubDepartments = _context.SubDepartments.Where(s => s.Status != false).ToList()
            };
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_PositionDeletePartial.cshtml", deptVm);
        }

    }
}
