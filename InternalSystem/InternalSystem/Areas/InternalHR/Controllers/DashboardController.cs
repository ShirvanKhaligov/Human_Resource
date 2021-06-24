using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.InternalHR.Controllers
{
    [Area("InternalHR")]
    [Authorize(Roles = "HumanResource,HrDepartmentBoss")]

    public class DashboardController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        public DashboardController(InternalSysDBContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            AppUser currentHr = await _userManager.FindByEmailAsync(User.Identity.Name);
            AllModelVM allModel = new AllModelVM()
            {
                EmpCount = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.CompanyId == currentHr.CompaniesId).Count(),
                DepCount = _context.DepartmentToCompanies.Where(x => x.CompanyId == currentHr.CompaniesId && x.Department.Status == true).Count(),
                DepToComCount = _context.DepartmentToCompanies.Where(c => c.DepartmentId == currentHr.CompaniesId).Count(),
                DepartmentToCompanies = _context.DepartmentToCompanies.Where(x => x.CompanyId == currentHr.CompaniesId).ToList(),

                PositionCount = _context.Positions.Where(x => x.Status == true && x.SubDepartment.DepartmentToCompany.CompanyId == currentHr.CompaniesId).Count(),
                WomenCount = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.CompanyId == currentHr.CompaniesId && e.GenderId == 2).Count(),
                MenCount = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.CompanyId == currentHr.CompaniesId && e.GenderId == 1).Count(),

            };
            return View(allModel);
        }
        public async Task<IActionResult> Departamentlər()
        {
            AppUser curHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            AllModelVM allModelVM = new AllModelVM()
            {
                Departments = _context.Departments.Where(x => x.Status != false).ToList(),
                DepartmentToCompanies = _context.DepartmentToCompanies.Where(x => x.CompanyId == curHR.CompaniesId && x.Department.Status == true).ToList(),
                Emplooyees = _context.Emplooyeees.Where(s => s.Status != false && s.IsWorking != false && s.CompanyId == curHR.CompaniesId && s.PositionsId != null).ToList()


            };
            return View(allModelVM);
        }

        public async Task<IActionResult> PositionList()
        {

            AppUser currentHr = await _userManager.FindByEmailAsync(User.Identity.Name);
            DeptAndSubDeptVM deptAndSubDeptVM = new DeptAndSubDeptVM
            {
                Positions = _context.Positions.Where(xn => xn.Status != false
                
                  && xn.SubDepartment.Status != false
                  && xn.SubDepartment.DepartmentToCompany.Department.Status != false
                  //&& xn.SubDepartment.DepartmentToCompany.Company.status != false
                  && xn.SubDepartment.DepartmentToCompany.CompanyId==currentHr.CompaniesId).OrderByDescending(xnx=>xnx.Name.Length).ToList()
            };
            return View(deptAndSubDeptVM);






        }


    }
}
