using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "Member")]
    public class AccountController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailsender;
        public AccountController(IEmailSender emailSender, InternalSysDBContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _emailsender = emailSender;
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
            //var x = User.Identity.Name;
            //var b = _context.Emplooyeees.Where(e => e.Status != false && e.Email == x).FirstOrDefault();
            //ViewData["image_employee_nav"] = b.Image;
            //ViewData["company_image_employee"] = b.Company.Image;
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
                    var currentSession = User.Identity.Name;
                    AppUser findUser = await _userManager.FindByEmailAsync(currentSession);
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
                                  
                                    return RedirectToAction("Index", "Dashboard", new { area = "Employee" });
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
                catch (Exception)
                { }
            
            }
            return View(accountVM);
        }
    }
}
