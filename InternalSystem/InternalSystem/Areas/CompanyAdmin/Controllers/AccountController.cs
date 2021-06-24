using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.CompanyAdmin.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.WebUtilities;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace InternalSystem.Areas.CompanyAdmin.Controllers
{
    [Area("CompanyAdmin")]
    [Authorize(Roles = "Admin")]
    public class AccountController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailsender;
        private readonly IHostingEnvironment _env;
        public AccountController(IHostingEnvironment env,IEmailSender emailSender, InternalSysDBContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _emailsender = emailSender;
            _env = env;
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(AccountVM accountVM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
                    if (findUser != null)
                    {
                        bool checkCurrentPpassword = _userManager.CheckPasswordAsync(findUser, accountVM.CurrentPassword).Result;
                        if (checkCurrentPpassword != false)
                        {
                            if (accountVM.ReNewPassword == accountVM.NewPassword)
                            {
                                findUser.PasswordHash = _userManager.PasswordHasher.HashPassword(findUser, accountVM.NewPassword);
                                var result = await _userManager.UpdateAsync(findUser);
                                if (!result.Succeeded)
                                {
                                    ModelState.AddModelError("", "Zəhmət olmasa biraz sonra cəhd edin!!");
                                    return View(accountVM);
                                }
                                else
                                {
                                    var x = User.Identity.Name;
                                    ViewData["successfullyChange"] = "Şifrə uğurla dəyişdirildi!!";
                                    return RedirectToAction("Index", "Dashboard", new { area = "CompanyAdmin" });
                                }
                            }
                            ModelState.AddModelError("", "Zəhmət olmasa yeni şifrə ilə təkrar şifrə uyğun deyil!!");
                            return View(accountVM);
                        }
                        else
                        {
                            ModelState.AddModelError("", "Zəhmət olmasa hazırki parolu düzgün daxil edin!!");
                            return View(accountVM);
                        }
                    }
                    return NotFound();
                }
                catch (System.Exception e)
                {
                    
                }
              
            }
            return View(accountVM);
        }
        //static string keepUserEmail ="";
        [HttpGet]
        public async Task<IActionResult> Information()
        {
            var x = User.Identity.Name;
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (appUser == null)
                NotFound();
            var xx = appUser.Image;
            return View(appUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Information(AppUser updateAppUser, IFormFile Image)
        {
            if (ModelState["Name"].ValidationState != ModelValidationState.Invalid&&
                ModelState["Surname"].ValidationState != ModelValidationState.Invalid&&
                ModelState["FatherName"].ValidationState != ModelValidationState.Invalid)
            {
                var x = User.Identity.Name;
                AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
                if (appUser == null)
                    NotFound();
                appUser.Name = updateAppUser.Name;
                appUser.Surname = updateAppUser.Surname;
                appUser.FatherName = updateAppUser.FatherName;
                //Image check
                if (Image != null)
                {
                    if (!Image.IsImage())
                    {
                        ViewData["error_image"] = "Şəkil faylı seçin";
                        return View(appUser);
                    }

                    if (!Image.ImageSize(2))
                    {
                        ViewData["error_image_size"] = "Şəkilin ölçüsü 2Mb-dan artıq ola bilməz";
                        return View(appUser);
                    }
                    bool deletePicture = Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath,appUser.Image);
                    string filename = await Image.CopyImage(_env.WebRootPath, "admin");
                    appUser.Image = filename;
                }
                await _userManager.UpdateAsync(appUser);
                
                return View(appUser);
            }
            AppUser appUserr = await _userManager.FindByEmailAsync(User.Identity.Name);
            return View(appUserr);
        }
    }
}
