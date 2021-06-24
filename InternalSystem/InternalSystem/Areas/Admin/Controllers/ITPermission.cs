using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Admin.ViewModels;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InternalSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ITPermission : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHostingEnvironment _env;
        //private PermissionType findPermission;
        public ITPermission(InternalSysDBContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _env = env;
        }
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> GetAllPers()
        {
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (appUser == null)
            {
                return NotFound();
            }
            PerrmissionITVM permisionVM = new PerrmissionITVM()
            {
                Permissions=_context.PermissionToEmployeees.Where(x=>x.Emplooyee.Positions.SubDepartment.DepartmentToCompany.DepartmentId==40).OrderByDescending(x=>x.Permission.CreatingTime).ToList().Take(100)
            };
            return View(permisionVM);
        }
    }
}
