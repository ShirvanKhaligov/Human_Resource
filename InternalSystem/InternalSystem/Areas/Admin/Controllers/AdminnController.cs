using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Admin.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Extentions;
using InternalSystem.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace InternalSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "SuperAdmin")]
    public class AdminnController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHostingEnvironment _env;
        public AdminnController(InternalSysDBContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _env = env;
        }

        #region RoleSeeder Create
        //public async Task RoleSeeder()
        //{
        //    if (!await _roleManager.RoleExistsAsync(Utility.Roles.Admin.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.Admin.ToString()));
        //    }
        //    if (!await _roleManager.RoleExistsAsync(Utility.Roles.Member.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.Member.ToString()));
        //    }

        //    if (!await _roleManager.RoleExistsAsync(Utility.Roles.SuperAdmin.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.SuperAdmin.ToString()));
        //    }
        //    if (!await _roleManager.RoleExistsAsync(Utility.Roles.HumanResource.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.HumanResource.ToString()));
        //    }
        //    if (!await _roleManager.RoleExistsAsync(Utility.Roles.DepartmentBoss.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.DepartmentBoss.ToString()));
        //    }


        //    if (!await _roleManager.RoleExistsAsync(Utility.Roles.HrDepartmentBoss.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.HrDepartmentBoss.ToString()));
        //    }
        //    if (!await _roleManager.RoleExistsAsync(Utility.Roles.DeviceResponsible.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.DeviceResponsible.ToString()));
        //    }
        //    if (!await _roleManager.RoleExistsAsync(Utility.Roles.Director.ToString()))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(Utility.Roles.Director.ToString()));
        //    }
        //}
        #endregion
        public async Task<IActionResult> Index()
        {
            AdminVM adminVM = new AdminVM()
            {
                Companies = _context.Companies.Where(c => c.status != false),
                AppUsers = await _userManager.GetUsersInRoleAsync(Utilities.Utility.AdminRole.ToString())
            };
            return View(adminVM);
        }
        public async Task<IActionResult> AllAdminList()
        {
            AdminVM adminVM = new AdminVM()
            {
                Companies = _context.Companies.Where(c => c.status != false),
                AppUsers = await _userManager.GetUsersInRoleAsync(Utilities.Utility.AdminRole.ToString())
                //AppUsers = _userManager.Users.Where(u => u.Status != false).ToList()
            };
            return View(adminVM);
        }
        public IActionResult Create()
        {
            AdminVM adminVM = new AdminVM()
            {
                Companies = _context.Companies.Where(c => c.status != false).ToList()
            };

            return View(adminVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdminVM adminVM, int companyName)
        {
            var vm = new AdminVM
            {
                Companies = _context.Companies.Where(c => c.status != false).ToList()
            };
            if (companyName == 0)
            {
                ViewData["error_select_company"] = "Zəhmət olmasa şirkət seçin";
                return View(new AdminVM { Companies = _context.Companies.Where(d => d.status != false).ToList() });
            }

            if (ModelState["Name"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Surname"].ValidationState == ModelValidationState.Invalid ||
                ModelState["FatherName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["PhoneNumber"].ValidationState == ModelValidationState.Invalid ||
                ModelState["UserName"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Email"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Password"].ValidationState == ModelValidationState.Invalid ||
                ModelState["ConfirmPassword"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View(vm);
            }

            //Image check
            if (!adminVM.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Şəkil faylı seçin");
                return View(vm);
            }

            if (!adminVM.Photo.ImageSize(2))
            {
                ModelState.AddModelError("Photo", "Şəkilin ölçüsü 2Mb-dan artıq ola bilməz");
                return View(vm);
            }

            AppUser newUser = new AppUser()
            {
                Name = adminVM.Name,
                Surname = adminVM.Surname,
                PhoneNumber = adminVM.PhoneNumber,
                UserName = adminVM.Email,
                FatherName = adminVM.FatherName,
                Email = adminVM.Email,
                CompaniesId = companyName,
                Status = true
            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, adminVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(vm);
            }

            string filename = await adminVM.Photo.CopyImage(_env.WebRootPath, "admin");
            newUser.Image = filename;
            await _userManager.AddToRoleAsync(newUser, Utility.Roles.Admin.ToString());
            ////await _signInManager.SignInAsync(newUser, false);
            return RedirectToAction("Index", "Adminn");
        }

        #region Edit 
        //public async Task<IActionResult> Edit(string id)
        //{
        //    if (id == null) { return NotFound(); }
        //    AppUser appUser = _userManager.Users.Include(a=>a.AdminTable).FirstOrDefault(c => c.Id == id);
        //    ViewData["adminCompany"] = appUser.AdminTable.CompaniesId;
        //    AdminVM adminVM = new AdminVM()
        //    {
        //        Companies = _context.Companies.Where(c => c.status != false),
        //        AdminTables = _context.AdminTables.Where(a => a.Status != false&&a.CompaniesId== appUser.AdminTable.CompaniesId),
        //        AdminTable= appUser.AdminTable,
        //        AppUser = appUser
        //    };
        //    return View(adminVM);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(AdminVM adminVM, int companyName)
        //{
        //    if (companyName == 0) { return NotFound(); }
        //    AppUser appUser = _userManager.Users.Include(a => a.AdminTable).Include(a => a.AdminTable.Companies).First(p => p.AdminTable.CompaniesId == companyName);
        //    ViewData["adminCompany"] = appUser.AdminTable.CompaniesId;
        //    var vm = new AdminVM
        //    {
        //        Companies = _context.Companies.Where(c => c.status != false).ToList(),
        //        AdminTable = appUser.AdminTable
        //    };

        //    if (ModelState["Name"].ValidationState == ModelValidationState.Invalid ||
        //    ModelState["Surname"].ValidationState == ModelValidationState.Invalid ||
        //    ModelState["FatherName"].ValidationState == ModelValidationState.Invalid ||
        //    ModelState["PhoneNumber"].ValidationState == ModelValidationState.Invalid ||
        //    ModelState["UserName"].ValidationState == ModelValidationState.Invalid ||
        //    ModelState["Email"].ValidationState == ModelValidationState.Invalid ||
        //    ModelState["Password"].ValidationState == ModelValidationState.Invalid ||
        //    ModelState["ConfirmPassword"].ValidationState == ModelValidationState.Invalid)
        //    {
        //        return View(vm);
        //    }

        //    if (appUser == null) { return NotFound(); }

        //    //Image check
        //    if (adminVM.PhotoUpd != null)
        //    {
        //        if (!adminVM.PhotoUpd.IsImage())
        //        {
        //            ModelState.AddModelError("PhotoUpd", "Şəkil faylı seçin");
        //            return View(vm);
        //        }

        //        if (!adminVM.Photo.ImageSize(2))
        //        {
        //            ModelState.AddModelError("PhotoUpd", "Şəkilin ölçüsü 2Mb-dan artıq ola bilməz");
        //            return View(vm);
        //        }
        //    }

        //    appUser.AdminTable.FatherName = adminVM.FatherName;
        //    appUser.AdminTable.CompaniesId = companyName;

        //    appUser.Name = adminVM.Name;
        //    appUser.Surname = adminVM.Surname;
        //    appUser.PhoneNumber = adminVM.PhoneNumber;
        //    appUser.UserName = adminVM.UserName;
        //    appUser.Email = adminVM.Email;
        //    appUser.PasswordHash = _userManager.PasswordHasher.HashPassword(appUser, adminVM.Password);

        //    var result = _userManager.UpdateAsync(appUser);
        //    return Content("oldu");
        //}
        #endregion
        public IActionResult Delete(string id)
        {
            if (id == null) { return NotFound(); }
            AppUser app = _userManager.Users.FirstOrDefault(u => u.Id == id);
            if (app == null) { return NotFound(); }
            return View(app);
        }
        [ActionName("Delete")]
        [HttpPost]
        public async Task<IActionResult> DeleteAdmin(string id)
        {
            if (id == null) { return NotFound(); }
            AppUser appUser = _userManager.Users.FirstOrDefault(a => a.Id == id);
            if (appUser == null) { return NotFound(); }
            appUser.Status = false;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
