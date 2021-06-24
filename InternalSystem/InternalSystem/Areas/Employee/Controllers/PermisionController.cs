using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "Member")]
    public class PermisionController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHostingEnvironment _env;
        private PermissionType findPermission;
        public PermisionController(InternalSysDBContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _env = env;
        }

        public async Task<IActionResult> GetPermission()
        {
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (appUser == null) return NotFound();
            PermisionVM permissionVM = new PermisionVM()
            {
                Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Permission.CreatingTime).ToList(),
                PermissionTypes = _context.PermissionTypes.ToList(),
                //PermissionTypeId=_context.
            };
            return View(permissionVM);
            //if (true)
            //{

            //}
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetPermission(PermisionVM permisionVM)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (appUser == null) return NotFound();
            //PermisionVM permissionVM = new PermisionVM()
            //{
            permisionVM.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Permission.CreatingTime).ToList();
            permisionVM.PermissionTypes = _context.PermissionTypes.ToList();
            //};

            if (ModelState["PermissionTypeName"].ValidationState == ModelValidationState.Invalid)
            {
                return View(permisionVM);
            }
            if (permisionVM.PermissionTypeName == "Saatlıq")
            {
                findPermission = _context.PermissionTypes.Find(1);
            }
            else if (permisionVM.PermissionTypeName == "Günlük")
            {
                findPermission = _context.PermissionTypes.Find(2);
            }
            Permission newPermission = new Permission();
            if (findPermission.Name == "Saatlıq")
            {
                if (permisionVM.FromDate.Year < DateTime.Now.Year && //duz
                    permisionVM.FromDate.Month < DateTime.Now.Month)
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa tarixi düzgün seçin";
                    permisionVM.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Permission.CreatingTime).ToList();
                    permisionVM.PermissionTypes = _context.PermissionTypes.ToList();
                    return View(permisionVM);
                }
                if (permisionVM.ToDateForHour.Hour < permisionVM.FromDateForHour.Hour)
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa saat intervalı düzgün seçin";
                    permisionVM.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permisionVM.PermissionTypes = _context.PermissionTypes.ToList();
                    return View(permisionVM);
                }
                if (string.IsNullOrWhiteSpace(permisionVM.ReasonOne))
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa səbəbi daxil edin!!";
                    permisionVM.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permisionVM.PermissionTypes = _context.PermissionTypes.ToList();
                    return View(permisionVM);
                }
                if (permisionVM.ReasonOne.Length > 125)
                {
                    ViewData["fillAllInputs"] = "Səbəb 100 hərfdən artıq ola bilməz";
                    permisionVM.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permisionVM.PermissionTypes = _context.PermissionTypes.ToList();
                    return View(permisionVM);
                }
                //var findToDate = permission.FromDate.AddHours(permission.Hour); //find beetwen hours
                newPermission.FromDateForHour = permisionVM.FromDateForHour;
                newPermission.ToDate = permisionVM.ToDateForHour;
                newPermission.FromDate = permisionVM.FromDate;
                newPermission.PermissionTypeId = findPermission.Id;
                //newPermission.FromDate = permission.FromDate;
                newPermission.CreatingTime = DateTime.Now;
                newPermission.Reason = permisionVM.ReasonOne;
            }
            else if (findPermission.Name == "Günlük")
            {
                if (permisionVM.FromDateForDay.Year < DateTime.Now.Year &&
                    permisionVM.FromDateForDay.Month < DateTime.Now.Month)
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa vaxtı düzgün seçin";
                    permisionVM.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permisionVM.PermissionTypes = _context.PermissionTypes.ToList();
                    return View(permisionVM);
                }
                if (permisionVM.ToDateForDay.Year <= DateTime.Now.Year &&
                    permisionVM.ToDateForDay.Month <= DateTime.Now.Month &&
                    permisionVM.ToDateForDay.Day == permisionVM.FromDateForDay.Day)
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa vaxtı düzgün seçin";
                    permisionVM.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permisionVM.PermissionTypes = _context.PermissionTypes.ToList();
                    return View(permisionVM);
                }
                if (string.IsNullOrWhiteSpace(permisionVM.ReasonTwo))
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa saat seçin və bütün xanaları doldurun";

                    permisionVM.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permisionVM.PermissionTypes = _context.PermissionTypes.ToList();
                    return View(permisionVM);
                }
                if (permisionVM.ReasonTwo.Length > 125)
                {
                    ViewData["fillAllInputs"] = "Səbəb 100 hərfdən artıq ola bilməz";
                    permisionVM.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permisionVM.PermissionTypes = _context.PermissionTypes.ToList();
                    return View(permisionVM);
                }
                newPermission.PermissionTypeId = findPermission.Id;
                newPermission.FromDate = permisionVM.FromDateForDay;
                newPermission.ToDate = permisionVM.ToDateForDay;
                newPermission.Reason = permisionVM.ReasonTwo;
                newPermission.CreatingTime = DateTime.Now;
            }
            await _context.Permissions.AddAsync(newPermission);
            await _context.SaveChangesAsync();
            PermissionToEmployeee permissionToEmployeee = new PermissionToEmployeee();
            permissionToEmployeee.EmplooyeeId = appUser.EmplooyeeId;
            permissionToEmployeee.Emplooyee = _context.Emplooyeees.Where(w => w.Id == appUser.EmplooyeeId).FirstOrDefault();
            permissionToEmployeee.PermissionId = newPermission.Id;
            permissionToEmployeee.Permission = newPermission;
            await _context.PermissionToEmployeees.AddAsync(permissionToEmployeee);
            await _context.SaveChangesAsync();
            ModelState.Clear();
            PermisionVM permissionVM = new PermisionVM()
            {
                Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList().Take(100),
                PermissionTypes = _context.PermissionTypes.ToList(),
            };
            //return View(permissionVM);
            return RedirectToAction(nameof(GetPermission));

        }
        [Authorize(Roles = "DepartmentBoss")]
        public async Task<IActionResult> AllPermitions()
        {
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (appUser == null)
                NotFound();
            PermisionVM permissionVM = new PermisionVM()
            {
                Permissions = _context.PermissionToEmployeees.Where(w => w.Emplooyee.Positions.SubDepartment.DepartmentToCompany.MenegerId == appUser.EmplooyeeId).OrderByDescending(w => w.Permission.CreatingTime).ToList().Take(100)
            };
            return View(permissionVM);
        }
        [Authorize(Roles = "DepartmentBoss")]
        public async Task<IActionResult> ConfirmPermissionByDep(int? perId)
        {
            if (perId == null) return NotFound();
            Permission findPermission = _context.Permissions.Where(w => w.Id == perId).FirstOrDefault();
            findPermission.Confirm = true;
            _context.Entry(findPermission).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (appUser == null) return NotFound();
            PermisionVM permissionVM = new PermisionVM()
            {
                Permissions = _context.PermissionToEmployeees.Where(w => w.Emplooyee.Positions.SubDepartment.DepartmentToCompany.MenegerId == appUser.EmplooyeeId).OrderByDescending(w => w.Permission.CreatingTime).ToList().Take(100)
            };
            return RedirectToAction(nameof(AllPermitions));
        }
        [Authorize(Roles = "DepartmentBoss")]
        //[HttpPost]
        public async Task<IActionResult> CancelermissionByDep(int? perId)
        {
            //if (ModelBindingContext.NestedScope)
            //{

            //}

            if (perId == null) return NotFound();
            Permission findPermission = _context.Permissions.Where(w => w.Id == perId).FirstOrDefault();
            findPermission.Cancel = true;
            _context.Entry(findPermission).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (appUser == null) return NotFound();
            PermissionVM permissionVM = new PermissionVM()
            {
                Permissions = _context.PermissionToEmployeees.Where(w => w.Emplooyee.Positions.SubDepartment.DepartmentToCompany.MenegerId == appUser.EmplooyeeId).OrderByDescending(w => w.Permission.CreatingTime).ToList().Take(100)
            };
            return RedirectToAction(nameof(AllPermitions));
        }

        public IActionResult AllVacation()
        {
            return View();
        }
    }
}
