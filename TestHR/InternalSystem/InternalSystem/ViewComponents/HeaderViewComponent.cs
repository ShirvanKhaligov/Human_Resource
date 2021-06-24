using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.Departments;
using InternalSystem.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        public HeaderViewComponent(InternalSysDBContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppUser currentUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<Emplooyee> emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking == false && e.IsCandidate == false).ToList();
            CommandsToEmployee commandsToEmployee = _context.CommandsToEmployees.Where(c => c.EmplooyeeId == currentUser.EmplooyeeId && c.Command.Name == "İşə qəbul").FirstOrDefault();
            List<DepartmentToCompany> departmentToCompany = _context.DepartmentToCompanies.Where(d => d.Department.Status != false && d.Company.status != false && d.CompanyId == currentUser.CompaniesId).ToList();
            HeaderBioVM headerBio = new HeaderBioVM()
            {
                AppUser = currentUser,
                CommandsToEmployee = commandsToEmployee,
                DepartmentToCompanies = departmentToCompany,
                Emplooyees = emplooyees
            };
            return View(headerBio);
        }
    }
}
