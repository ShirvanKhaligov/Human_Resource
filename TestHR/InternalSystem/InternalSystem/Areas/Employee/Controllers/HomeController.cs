using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "Member")]
    public class HomeController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHostingEnvironment _env;
        public HomeController(InternalSysDBContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _env = env;
        }
        [HttpGet]
        public async Task<IActionResult> Information()
        {
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (appUser == null)
                NotFound();
            InformationVM informationVM = new InformationVM()
            {
                AppUser = appUser,
                EducationsToEmployee = _context.EducationsToEmployees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).ToList(),
                DepartmentToCompanyy=_context.DepartmentToCompanies.Where(d=>d.MenegerId==appUser.EmplooyeeId).FirstOrDefault(),
                DeviceToEmployees=_context.DeviceToEmployees.Where(c=>c.EmplooyeeId==appUser.EmplooyeeId).ToList(),
               
            };
            return View(informationVM);
        }
        [HttpPost]
        public async Task<IActionResult> Information(IFormFile imageUploadd)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            //var x=await _userManager.fin
            if (appUser == null)
                NotFound();
            InformationVM informationVM = new InformationVM()
            {
                AppUser = appUser,
                EducationsToEmployee = _context.EducationsToEmployees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).ToList(),
            };
            if (imageUploadd != null)
            {
                if (!imageUploadd.IsImage())
                {
                    ViewData["error_image"] = "Şəkil faylı seçin";
                    return View(informationVM);
                }

                if (!imageUploadd.ImageSize(2))
                {
                    ViewData["error_image_size"] = "Şəkilin ölçüsü 2Mb-dan artıq ola bilməz";
                    return View(informationVM);
                }
                if (appUser.Image != null)
                {
                    bool deletePicture = Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, appUser.Image);
                    if (await _userManager.IsInRoleAsync(appUser, Utilities.Utility.HumanresourceRole.ToString()))
                    {
                        string filenameAppUser = await imageUploadd.CopyImage(_env.WebRootPath, "hr");
                        appUser.Image = filenameAppUser;
                    }
                }
                bool deleteuser =  Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, appUser.Emplooyee.Image);
                string filename = await imageUploadd.CopyImage(_env.WebRootPath, "user");
                appUser.Emplooyee.Image = filename;
            }
            await _userManager.UpdateAsync(appUser);
           
            return View(informationVM);
        }

    }
}
