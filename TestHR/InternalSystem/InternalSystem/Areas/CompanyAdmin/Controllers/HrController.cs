using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.CompanyAdmin.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Extentions;
using InternalSystem.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;

namespace InternalSystem.Areas.CompanyAdmin.Controllers
{
    [Area("CompanyAdmin")]
    [Authorize(Roles = "Admin")]
    public class HrController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHostingEnvironment _env;
        public HrController(IHostingEnvironment env,InternalSysDBContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _env = env;

        }
        public async Task<IActionResult> Index()
        {
                AppUser findCurrentUser = await _userManager.FindByEmailAsync(User.Identity.Name);
                if (findCurrentUser == null)
                    NotFound();
                var HRs = await _userManager.GetUsersInRoleAsync(Utility.Roles.HumanResource.ToString());
                ViewBag.userAdmin = findCurrentUser.CompaniesId;
               return View(HRs);
        }
        [HttpGet]
        public  IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HrVM hrVM)
        {

            if (ModelState["Name"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Surname"].ValidationState == ModelValidationState.Invalid ||
                ModelState["FatherName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["PhoneNumber"].ValidationState == ModelValidationState.Invalid ||
                ModelState["UserName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Email"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Password"].ValidationState == ModelValidationState.Invalid ||
                ModelState["ConfirmPassword"].ValidationState == ModelValidationState.Invalid)
            {
                return View(hrVM);
            }

            //Image check
            if (hrVM.Photo != null)
            {
                if (!hrVM.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Şəkil faylı seçin");
                    return View();
                }

                if (!hrVM.Photo.ImageSize(2))
                {
                    ModelState.AddModelError("Photo", "Şəkilin ölçüsü 2Mb-dan artıq ola bilməz");
                    return View();
                }
            }
            else
                return View(hrVM);

            AppUser findCurrentUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            AppUser newUser = new AppUser()
            {
                Name = hrVM.Name,
                Surname = hrVM.Surname,
                FatherName = hrVM.FatherName,
                PhoneNumber = hrVM.PhoneNumber,
                UserName = hrVM.Email,
                Email = hrVM.Email,
                Status = true,
                CompaniesId = findCurrentUser.CompaniesId,
                AdminId = findCurrentUser.Id,
                NormalizedUserName=hrVM.Email
            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, hrVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(hrVM);
            }
            string filename = await hrVM.Photo.CopyImage(_env.WebRootPath, "user");
            newUser.Image = filename;
            await _userManager.AddToRoleAsync(newUser, Utility.Roles.HumanResource.ToString());
            return RedirectToAction("Index", "Hr");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(string id) {

            if (id == null)
                NotFound();
            AppUser findUser =  await _userManager.FindByIdAsync(id);
            return View(findUser);
        }
        [ActionName("Delete")]
        [HttpPost]
        public async Task<IActionResult> DeleteSubmit(string Id) 
        {

            if (Id == null)
                NotFound();
            AppUser findUser =  await _userManager.FindByIdAsync(Id);
            if(findUser==null)
                NotFound();
            findUser.Status = false;
            var result = await _userManager.UpdateAsync(findUser);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Confirm(string id) 
        {
            if (id == null)
                NotFound();
            AppUser findUser =  await _userManager.FindByIdAsync(id);
            if(findUser==null)
                NotFound();
            findUser.Status = true;
            findUser.Emplooyee.IsWorking = true;
            var result = await _userManager.UpdateAsync(findUser);
            return RedirectToAction(nameof(Index));
        }
    }
}
