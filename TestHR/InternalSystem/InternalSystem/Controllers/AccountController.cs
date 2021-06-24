using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Utilities;
using InternalSystem.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;


namespace InternalSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailsender;
        public AccountController(
            InternalSysDBContext context,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            IEmailSender emailsender
            )
        {

            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _emailsender = emailsender;

        }




        
        public IActionResult ForgotPasswordSec()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPasswordSec(LoginVM loginVM)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(loginVM.Email);
            if (findUser == null)
            {
                //ViewData["noUser"] = "Istifadəçi mövcud deyil!!";
                return RedirectToAction(nameof(LoginSec));
            }
            if (findUser.Status == false)
            {
                //ViewData["noUser"] = "Istifadəçi mövcud deyil!!";
                return RedirectToAction(nameof(LoginSec));
            }



            string token = await _userManager.GeneratePasswordResetTokenAsync(findUser);

            byte[] tokenGeneratedBytes = Encoding.UTF8.GetBytes(token);
            var codeEncoded = WebEncoders.Base64UrlEncode(tokenGeneratedBytes);
            await _emailsender.SendEmailAsync(loginVM.Email, "Şifrənizi yeniləyin!!",
                $"Bu linki izləyərək şifrənizi yeniləyin" +
                $"<a  href='{HtmlEncoder.Default.Encode($"http://hr.ferrumcapital.az:9090//Account/ResetPassword?token={codeEncoded}&userId={findUser.Id}")}'>" +
                $"  Link" +
                $"</a>"
                );
            ViewData["Sent meesage"] = "Təsdiq mesajı göndərildi!";
            return View("VerifyEmail");
        }
    

        public IActionResult LoginSec()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginSec(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            AppUser findUser = await _userManager.FindByEmailAsync(loginVM.Email);
             
            try
            {
                if (findUser == null)
                {
                    ModelState.AddModelError("", "Lazımi məlumatlarınız tapılmadı.Zəhmət olmasa insan resursları şöbəsinə müraciət edin.");
                }
                else if (findUser.Emplooyee.IsCandidate == false && findUser.Emplooyee.IsWorking == false && findUser.Emplooyee.Status == true)
                {
                    ModelState.AddModelError("", "Əmriniz verilməyib.İnsan resursları şöbəsinə müraciət edin.");

                }
                else if (findUser.Emplooyee.Status == false && findUser.Emplooyee.IsWorking == false)
                {
                    ModelState.AddModelError("", "İşçi statunuz ləğv edilib.Bizimlə birgə həmkar olduğunuz üçün təşəkkürlər.");
                }
                else if (findUser == null)
                {
                    ModelState.AddModelError("", "Email və ya şifrə yalnışdır");
                    return View(loginVM);
                }
                else if (findUser.Companies.status != false)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(loginVM.Email, loginVM.Password, true, true);
                    if (result.Succeeded)
                    {
                        if (await _userManager.IsInRoleAsync(findUser, Utility.SuperAdminRole))
                        {
                            return new RedirectToActionResult("Index", "Dashboard", routeValues: new
                            {
                                area = "Admin"
                            });
                        }
                        else if (await _userManager.IsInRoleAsync(findUser, Utility.AdminRole))
                        {
                            return new RedirectToActionResult("Index", "Dashboard", routeValues: new
                            {
                                area = "CompanyAdmin"
                            });
                        }
                        else if (await _userManager.IsInRoleAsync(findUser, Utility.HumanresourceRole))
                        {
                            return new RedirectToActionResult("Index", "Dashboard", routeValues: new
                            {
                                area = "InternalHR"
                            });
                        }
                        return new RedirectToActionResult("Index", "Dashboard", routeValues: new
                        {
                            area = "Employee"
                        });
                    }
                    else
                    {
                        ModelState.AddModelError("", "Email və ya şifrə yalnışdır");

                    }
                }
                
                return View(loginVM);
            }
            catch (Exception ex)
            {
               return RedirectToAction(nameof(LoginSec));
            }
            
        }



        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> LogOutsSec()
        {
            await _signInManager.SignOutAsync();
            //return RedirectToAction(nameof(LoginSec));
            return new RedirectToActionResult("Index", "Dashboard", routeValues: new
            {
                area = "Employee"
            });

            //return new JavaScriptResult();
        }


        #region LastLoginSys
        //public IActionResult Login()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Login(LoginVM loginVM)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(loginVM);
        //    }
        //    AppUser findUser = await _userManager.FindByEmailAsync(loginVM.Email);
        //    //var actives = await _userManager.Fin(loginVM.Is);


        //    if (findUser == null)
        //    {
        //        ModelState.AddModelError("", "Email və ya şifrə yalnışdır");
        //        return View(loginVM);
        //    }

        //    if (findUser.Companies.status != false)
        //    {
        //        Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(loginVM.Email, loginVM.Password, true, true);
        //        if (result.Succeeded)
        //        {
        //            if (await _userManager.IsInRoleAsync(findUser, Utility.SuperAdminRole))
        //            {
        //                return new RedirectToActionResult("Index", "Dashboard", routeValues: new
        //                {
        //                    area = "Admin"
        //                });
        //            }
        //            else if (await _userManager.IsInRoleAsync(findUser, Utility.AdminRole))
        //            {
        //                return new RedirectToActionResult("Index", "Dashboard", routeValues: new
        //                {
        //                    area = "CompanyAdmin"
        //                });
        //            }
        //            else if (await _userManager.IsInRoleAsync(findUser, Utility.HumanresourceRole))
        //            {
        //                return new RedirectToActionResult("Index", "Dashboard", routeValues: new
        //                {
        //                    area = "InternalHR"
        //                });
        //            }
        //            return new RedirectToActionResult("Index", "Dashboard", routeValues: new
        //            {
        //                area = "Employee"
        //            });
        //        }
        //    }
        //    ModelState.AddModelError("", "Email və ya şifrə yalnışdır");
        //    return View(loginVM);
        //}


        //[ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        //public async Task<IActionResult> LogOut()
        //{
        //    await _signInManager.SignOutAsync();
        //    return RedirectToAction(nameof(LoginSec));
        //    //return new RedirectToActionResult("Index", "Dashboard", routeValues: new
        //    //{
        //    //    area = "Employee"
        //    //});

        //    //return new JavaScriptResult();
        //}

        //[System.ComponentModel.Browsable(false)]
        //public bool IsPostBack { get; }
        //protected void PageLoad(object sender,EventArgs eventArgs)
        //{
        //    if (!IsPostBack)
        //    {
        //if (Session["user"])
        //{

        //}
        //    }
        //}

        //public class JavaScriptResult : ContentResult
        //{
        //    public JavaScriptResult(string script)
        //    {
        //        this.Content = script;
        //        this.ContentType = "application/javascript";

        //    }
        //}


        //public IActionResult DoSomething()
        //{
        //    return new JavaScriptResult("alert('Hello world!');");
        //}

        //public async Task<IActionResult> ForgotPassword(LoginVM loginVM)
        //{
        //    AppUser findUser = await _userManager.FindByEmailAsync(loginVM.Email);
        //    if (findUser == null)
        //    {
        //        //ViewData["noUser"] = "Istifadəçi mövcud deyil!!";
        //        return RedirectToAction(nameof(Login));
        //    }
        //    if (findUser.Status == false)
        //    {
        //        //ViewData["noUser"] = "Istifadəçi mövcud deyil!!";
        //        return RedirectToAction(nameof(Login));
        //    }



        //    string token = await _userManager.GeneratePasswordResetTokenAsync(findUser);

        //    byte[] tokenGeneratedBytes = Encoding.UTF8.GetBytes(token);
        //    var codeEncoded = WebEncoders.Base64UrlEncode(tokenGeneratedBytes);
        //    await _emailsender.SendEmailAsync(loginVM.Email, "Şifrənizi yeniləyin!!",
        //        $"Bu linki izləyərək şifrənizi yeniləyin" +
        //        $"<a  href='{HtmlEncoder.Default.Encode($"http://hr.ferrumcapital.az:9090//Account/ResetPassword?token={codeEncoded}&userId={findUser.Id}")}'>" +
        //        $"  Link" +
        //        $"</a>"
        //        );
        //    ViewData["Sent meesage"] = "Təsdiq mesajı göndərildi!";
        //    return View("VerifyEmail");
        //}

        //public IActionResult ResetPassword(string token, string userId)
        //{
        //    var model = new AccountVM
        //    {
        //        Token = token,
        //        UserId = userId
        //    };
        //    return View(model);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ResetPassword(AccountVM resetAccountVM)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        ModelState.AddModelError("", "Şifrə düzgün deyil");
        //        return View(resetAccountVM);
        //    }
        //    var user = await _userManager.FindByIdAsync(resetAccountVM.UserId);
        //    if (user == null)
        //    {
        //        ModelState.AddModelError("", "İstifadəçi mövcud deyil");
        //        return View(resetAccountVM);
        //    }

        //    var codeDecodedBytes = WebEncoders.Base64UrlDecode(resetAccountVM.Token);
        //    var codeDecoded = Encoding.UTF8.GetString(codeDecodedBytes);
        //    var result = await _userManager.ResetPasswordAsync(user, codeDecoded, resetAccountVM.NewPassword);

        //    if (!result.Succeeded)
        //    {
        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError("", error.Description);
        //        }
        //        return View(resetAccountVM);
        //    }

        //    return RedirectToAction(nameof(Login));
        //}
        #endregion


    }
}
