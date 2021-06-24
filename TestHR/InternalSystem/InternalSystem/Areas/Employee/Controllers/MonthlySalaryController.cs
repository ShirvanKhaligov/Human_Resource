using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss")]
    public class MonthlySalaryController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public MonthlySalaryController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, InternalSysDBContext context)
        {
            _userManager = userManager;
            _context = context;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            AppUser finduser = await _userManager.FindByEmailAsync(User.Identity.Name);


            MonthlySalary msvm = new MonthlySalary()
            {
                //  Employees= _context.Emplooyeees.Where(w => w.Status != false
                //&& w.IsWorking == true && w.CompanyId == finduser.CompaniesId && w.Company.status != false && w.IsCandidate == false).OrderBy(w => w.Id).ToList(),
             CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Emplooyee.Status != false && c.Emplooyee.IsWorking == true && c.Emplooyee.CompanyId == finduser.CompaniesId&& c.Emplooyee.Positions!=null &&
                                                                      c.Emplooyee.Company.status != false && c.Emplooyee.IsCandidate == false && c.CommandId == 1).OrderBy(s => s.Emplooyee.Id),
             // CMDtoEMPTOHOURs=_context.CMDtoEMPTOHOURs.Where(x=>x.CommandsToEmployee.Emplooyee.Status==true&& x.CommandsToEmployee.Emplooyee.IsWorking==true&& x.CommandsToEmployee.Emplooyee.CompanyId==finduser.CompaniesId&&x.CommandsToEmployee.Emplooyee.Positions!=null&&
             // x.CommandsToEmployee.Emplooyee.Company.status==true&&x.CommandsToEmployee.Emplooyee.IsCandidate==false).OrderBy(x=>x.CommandsToEmployee.Emplooyee.Id).ToList()
            };
            return View(msvm);


        }
    }
}
