using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Controllers
{
    [Area("InternalHR")]
    [Authorize(Roles = "HumanResource,HrDepartmentBoss")]

    public class CommandController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public CommandController(RoleManager<IdentityRole> roleManager,UserManager<AppUser> userManager, InternalSysDBContext context)
        {
            _userManager = userManager;
            _context = context;
            _roleManager = roleManager;
        }
       
        public async Task<IActionResult> DetailCommand()
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            //image hr
            //ViewData["image_hr"] = findUser.Image;
            //ViewData["name_hr"] = findUser.Name + " " + findUser.Surname;
            //ViewData["company_image_hr"] = findUser.Companies.Image;
            //
            CommandVM commandVM = new CommandVM()
            {
                CommandsToEmployees = _context.CommandsToEmployees.Where(w => w.Command.Status != false
                && w.Emplooyee.Status != false && w.Emplooyee.CompanyId == findUser.CompaniesId&&w.Emplooyee.IsCandidate==false).ToList(),
            };
            return View(commandVM);
        }
    }
}
