using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.ViewModels;
using InternalSystem.Extentions;
using InternalSystem.Utilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.WebUtilities;

namespace InternalSystem.Areas.InternalHR.Controllers
{
    [Area("InternalHR")]
    [Authorize(Roles = "HumanResource,HrDepartmentBoss")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _singinManager;
        public RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailsender;
        private readonly InternalSysDBContext _context;
        private readonly IHostingEnvironment _env;
        public AuthController(IHostingEnvironment env,InternalSysDBContext context, 
                              UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, 
                              IEmailSender emailSender, SignInManager<AppUser> singinManager)
        {
            _userManager = userManager;
            _singinManager = singinManager;
            //_configuration = configuration;
            _emailsender = emailSender;
            _roleManager = roleManager;
            _context = context;
            _env = env;
        }
        //---------------------------------------------------Change Password--------------------------------------------------------------
        [HttpGet]
        public IActionResult ChangePassword()
        {
            //image hr
            //var mini_image_nav_hr = User.Identity.Name;
            //AppUser appUser = await _userManager.FindByEmailAsync(mini_image_nav_hr);
            //ViewData["image_hr"] = appUser.Image;
            //ViewData["name_hr"] = appUser.Name + " " + appUser.Surname;
            //ViewData["company_image_hr"] = appUser.Companies.Image;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(PasswordVM PasswordVM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var currentSession = User.Identity.Name;
                    AppUser findUser = await _userManager.FindByNameAsync(currentSession);
                    if (findUser != null)
                    {
                        bool checkCurrentPpassword = _userManager.CheckPasswordAsync(findUser, PasswordVM.CurrentPassword).Result;
                        if (checkCurrentPpassword != false)
                        {
                            if (PasswordVM.ReNewPassword == PasswordVM.NewPassword)
                            {
                                findUser.PasswordHash = _userManager.PasswordHasher.HashPassword(findUser, PasswordVM.NewPassword);
                                var result = await _userManager.UpdateAsync(findUser);
                                if (!result.Succeeded)
                                {
                                    ModelState.AddModelError("", "Zəhmət olmasa biraz sonra cəhd edin");
                                    return View(PasswordVM);
                                }
                                else
                                {
                                    var x = User.Identity.Name;
                                    ViewData["successfullyChange"] = "Şifrə uğurla dəyişdirildi";
                                   
                                    return RedirectToAction("Index", "Dashboard", new { area = "InternalHR" });
                                }
                            }
                            ModelState.AddModelError("", "Zəhmət olmasa yeni şifrə ilə təkrar şifrəni uyğun yazın");
                            return View(PasswordVM);
                        }
                        else
                        {
                            ModelState.AddModelError("", "Zəhmət olmasa hazırki parolu düzgün daxil edin");
                            return View(PasswordVM);
                        }
                    }
                    return NotFound();
                }
                catch (Exception)
                {}
             
            }
            return View(PasswordVM);
        }
        [HttpGet]
        public async Task<IActionResult> Information()
        {
            var x = User.Identity.Name;
            

            HrInformationImageVM ımageVM = new HrInformationImageVM
            {
                AppUser = await _userManager.FindByEmailAsync(User.Identity.Name),
                Emplooyee = _context.Emplooyeees.Where(e => e.Status != false && e.Email == x).FirstOrDefault()
            };
            if (ımageVM == null) NotFound();
            return View(ımageVM);
           
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Information(HrInformationImageVM updateAppUser, IFormFile Image)
        {
            var x = User.Identity.Name;
            HrInformationImageVM vM = new HrInformationImageVM
            {
                AppUser = await _userManager.FindByEmailAsync(User.Identity.Name),
                Emplooyee = _context.Emplooyeees.Where(e => e.Status != false && e.Email == x).FirstOrDefault()
            };
            if (ModelState["AppUser.Name"].ValidationState != ModelValidationState.Invalid &&
                ModelState["AppUser.Surname"].ValidationState != ModelValidationState.Invalid &&
                ModelState["AppUser.FatherName"].ValidationState != ModelValidationState.Invalid)
            {
              
                //AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
               
                if (vM == null)
                    NotFound();
                vM.AppUser.Name = updateAppUser.AppUser.Name.Trim();
                vM.AppUser.Surname = updateAppUser.AppUser.Surname.Trim();
                vM.AppUser.FatherName = updateAppUser.AppUser.FatherName.Trim();
                //For Employee table
                if (vM.Emplooyee != null)
                {
                    vM.Emplooyee.FirstName = updateAppUser.AppUser.Name.Trim();
                    vM.Emplooyee.Lastname = updateAppUser.AppUser.Surname.Trim();
                    vM.Emplooyee.FatherName = updateAppUser.AppUser.FatherName.Trim();
                }
                //Image check
                if (Image != null)
                {
                    if (!Image.IsImage())
                    {
                        //ModelState.AddModelError("Image", "Şəkil faylı seçin");
                        ViewData["Image_error"] = "Şəkil faylı seçin";
                        return View(vM);
                    }

                    if (!Image.ImageSize(2))
                    {
                        //ModelState.AddModelError("Image", "Şəkilin ölçüsü 2Mb-dan artıq ola bilməz");
                        ViewData["Image_error_size"] = "Şəkilin ölçüsü 2Mb-dan artıq ola bilməz";
                        return View(vM);
                    }
                    if (vM.AppUser.Image != null)
                    {
                        bool deletePicture = Utility.DeleteImageFromFolder(_env.WebRootPath, vM.AppUser.Image);
                        string filename = await Image.CopyImage(_env.WebRootPath, "user");
                        vM.AppUser.Image = filename;
                        if (vM.Emplooyee!=null)
                        {
                            vM.Emplooyee.Image = filename;
                        }
                    }
                }

                //AppUser appUser = await _userManager.FindByEmailAsync(x);
                //ViewData["image_hr"] = appUser.Image;
                //ViewData["name_hr"] = appUser.Name + " " + appUser.Surname;
                //ViewData["company_image_hr"] = appUser.Companies.Image;
                await _userManager.UpdateAsync(vM.AppUser);
                return View(vM);
            }
            //AppUser appUserr = await _userManager.FindByEmailAsync(User.Identity.Name);
            return View(vM);
        }
    }

}
