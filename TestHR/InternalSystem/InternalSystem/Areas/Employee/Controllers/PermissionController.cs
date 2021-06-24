using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "Member")]
    public class PermissionController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHostingEnvironment _env;
        public PermissionController(InternalSysDBContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _env = env;
        }
        [HttpGet]
        public async Task<IActionResult> GetPermission()
        {
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (appUser == null)
                NotFound();
            PermissionVM permissionVM = new PermissionVM()
            {
                Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Permission.CreatingTime).ToList(),
                permissionTypes = _context.PermissionTypes.ToList(),
            };
            return View(permissionVM);
        }
        PermissionType findPermission;
        [HttpPost]
        public async Task<IActionResult> GetPermission(PermissionVM permission)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (appUser == null)
                NotFound();
            if (permission.PermissionType == "none")
            {
                ViewData["fillAllInputs"] = "Zəhmət olmasa saat seçin və bütün xanaları doldurun!!";

                permission.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                permission.permissionTypes = _context.PermissionTypes.ToList();
                return View(permission);
            }
            else if (permission.PermissionType == "One")
            {
                findPermission = _context.PermissionTypes.Find(1);
            }
            else if (permission.PermissionType == "Two")
            {
                findPermission = _context.PermissionTypes.Find(2);
            }
            Permission newPermission = new Permission();
            if (findPermission.Name == "Saatlıq")
            {
                if (permission.FromDate.Year < DateTime.Now.Year &&
                    permission.FromDate.Month < DateTime.Now.Month)
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa tarixi düzgün seçin!!";
                    permission.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permission.permissionTypes = _context.PermissionTypes.ToList();
                    return View(permission);
                }
                if (permission.ToDateForHour.Hour < permission.FromDateForHour.Hour ||
                    string.IsNullOrWhiteSpace(permission.PermissionType))
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa saat intervalın düzgün seçin!!";
                    permission.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permission.permissionTypes = _context.PermissionTypes.ToList();
                    return View(permission);
                }
                if (string.IsNullOrWhiteSpace(permission.ReasonOne))
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa səbəbi daxil edin!!";
                    permission.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permission.permissionTypes = _context.PermissionTypes.ToList();
                    return View(permission);
                }
                if (permission.ReasonOne.Length>100)
                {
                    ViewData["fillAllInputs"] = "Səbəb 100 hərfdən artıq ola bilməz";
                    permission.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permission.permissionTypes = _context.PermissionTypes.ToList();
                    return View(permission);
                }
                //var findToDate = permission.FromDate.AddHours(permission.Hour); //find beetwen hours
                newPermission.FromDateForHour = permission.FromDateForHour;
                newPermission.ToDate = permission.ToDateForHour;
                newPermission.FromDate = permission.FromDate;
                newPermission.PermissionTypeId = findPermission.Id;
                newPermission.FromDate = permission.FromDate;
                newPermission.CreatingTime = DateTime.Now;
                newPermission.Reason = permission.ReasonOne;
            }
            else if (findPermission.Name == "Günlük")
            {
                if (permission.FromDateForDay.Year < DateTime.Now.Year &&
                    permission.FromDateForDay.Month < DateTime.Now.Month)
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa vaxtı düzgün seçin!!";
                    permission.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permission.permissionTypes = _context.PermissionTypes.ToList();
                    return View(permission);
                }
                else if (permission.ToDateForDay.Year <= DateTime.Now.Year &&
                    permission.ToDateForDay.Month <= DateTime.Now.Month &&
                    permission.ToDateForDay.Day == permission.FromDateForDay.Day)
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa vaxtı düzgün seçin!!";
                    permission.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permission.permissionTypes = _context.PermissionTypes.ToList();
                    return View(permission);
                }
                if (string.IsNullOrWhiteSpace(permission.ReasonTwo) ||
                    string.IsNullOrWhiteSpace(permission.PermissionType))
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa saat seçin və bütün xanaları doldurun!!";

                    permission.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permission.permissionTypes = _context.PermissionTypes.ToList();
                    return View(permission);
                }
                if (permission.ReasonTwo.Length > 100)
                {
                    ViewData["fillAllInputs"] = "Səbəb 100 hərfdən artıq ola bilməz";
                    permission.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    permission.permissionTypes = _context.PermissionTypes.ToList();
                    return View(permission);
                }
                newPermission.PermissionTypeId = findPermission.Id;
                newPermission.FromDate = permission.FromDateForDay;
                newPermission.ToDate = permission.ToDateForDay;
                newPermission.Reason = permission.ReasonTwo;
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

            //for testing
            PermissionVM permissionVM = new PermissionVM()
            {
                Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == appUser.EmplooyeeId).OrderByDescending(w => w.Id).ToList(),
                permissionTypes = _context.PermissionTypes.ToList(),
            };
            return View(permissionVM);
        }
        public async Task<IActionResult> AllPermitions()
        {
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (appUser == null)
                NotFound();
            PermissionVM permissionVM = new PermissionVM()
            {
                Permissions = _context.PermissionToEmployeees.Where(w => w.Emplooyee.Positions.SubDepartment.DepartmentToCompany.MenegerId == appUser.EmplooyeeId).OrderByDescending(w => w.Permission.CreatingTime).ToList()            };
            return View(permissionVM);
        }
        public async Task<IActionResult> CondirmPermissionByDep(int? perId)
        {
            if (perId == null) NotFound();
            Permission findPermission = _context.Permissions.Where(w => w.Id == perId).FirstOrDefault();
            findPermission.Confirm = true;
            _context.Entry(findPermission).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (appUser == null)
                NotFound();
            PermissionVM permissionVM = new PermissionVM()
            {
                Permissions = _context.PermissionToEmployeees.Where(w => w.Emplooyee.Positions.SubDepartment.DepartmentToCompany.MenegerId == appUser.EmplooyeeId).OrderByDescending(w => w.Permission.CreatingTime).ToList(),
            };
            return RedirectToAction(nameof(AllPermitions));
        }
        public async Task<IActionResult> CancelermissionByDep(int? perId)
        {
            if (perId == null) NotFound();
            Permission findPermission = _context.Permissions.Where(w => w.Id == perId).FirstOrDefault();
            findPermission.Cancel = true;
            _context.Entry(findPermission).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (appUser == null)
                NotFound();
            PermissionVM permissionVM = new PermissionVM()
            {
                Permissions = _context.PermissionToEmployeees.Where(w => w.Emplooyee.Positions.SubDepartment.DepartmentToCompany.MenegerId == appUser.EmplooyeeId).OrderByDescending(w => w.Permission.CreatingTime).ToList(),
            };
            return RedirectToAction(nameof(AllPermitions));
        }
        public async Task<IActionResult> AllPermitionsForHR()
        {
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            PermissionVM permissionVM = new PermissionVM()
            {
                Permissions = _context.PermissionToEmployeees.Where(w => w.Permission.Confirm != false && appUser.CompaniesId == w.Emplooyee.CompanyId).OrderByDescending(w => w.Permission.FromDate).ToList(),
            };
            return View(permissionVM);
        }
        [HttpGet]
        public async Task<IActionResult> searchPer(string getName, string howSearch)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (howSearch != null && getName != null)
            {
                if (howSearch == "all")
                {
                    PermissionVM permissionVMm = new PermissionVM()
                    {
                        Permissions = _context.PermissionToEmployeees.Where(w => (w.Emplooyee.FirstName.Contains(getName) || w.Emplooyee.Lastname.Contains(getName)) && w.Emplooyee.CompanyId == appUser.CompaniesId && w.Permission.Confirm != false).OrderByDescending(w => w.Permission.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_PermissionPartial.cshtml", permissionVMm);
                }
                else if (howSearch == "daily")
                {
                    PermissionVM permissionVMmm = new PermissionVM()
                    {
                        Permissions = _context.PermissionToEmployeees.Where(w => (w.Emplooyee.FirstName.Contains(getName) || w.Emplooyee.Lastname.Contains(getName)) && w.Emplooyee.CompanyId == appUser.CompaniesId && w.Permission.FromDate.Day == DateTime.Now.Day &&
                        w.Permission.FromDateForHour.Day == DateTime.Now.Day && w.Permission.Confirm != false).OrderByDescending(w => w.Permission.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_PermissionPartial.cshtml", permissionVMmm);
                }
                else if (howSearch == "monthly")
                {
                    PermissionVM permissionVMM = new PermissionVM()
                    {
                        Permissions = _context.PermissionToEmployeees.Where(w => (w.Emplooyee.FirstName.Contains(getName) || w.Emplooyee.Lastname.Contains(getName)) && w.Emplooyee.CompanyId == appUser.CompaniesId && w.Permission.FromDate.Month == DateTime.Now.Month &&
                        //w.Permission.FromDateForHour.Month == DateTime.Now.Month&&
                        w.Permission.FromDate.Year == DateTime.Now.Year &&
                        //w.Permission.FromDateForHour.Year == DateTime.Now.Year &&
                        w.Permission.Confirm != false).OrderByDescending(w => w.Permission.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_PermissionPartial.cshtml", permissionVMM);
                }
            }
            else if (getName == null && howSearch != null)
            {
                if (howSearch == "all")
                {
                    PermissionVM permissionVMm = new PermissionVM()
                    {
                        Permissions = _context.PermissionToEmployeees.Where(w => w.Permission.Confirm != false).OrderByDescending(w => w.Permission.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_PermissionPartial.cshtml", permissionVMm);
                }
                else if (howSearch == "daily")
                {
                    PermissionVM permissionVMmm = new PermissionVM()
                    {
                        Permissions = _context.PermissionToEmployeees.Where(w => w.Emplooyee.CompanyId == appUser.CompaniesId && w.Permission.FromDate.Day == DateTime.Now.Day &&
                        /*w.Permission.FromDateForHour.Day == DateTime.Now.Day &&*/ w.Permission.Confirm != false).OrderByDescending(w => w.Permission.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_PermissionPartial.cshtml", permissionVMmm);
                }
                else if (howSearch == "monthly")
                {
                    PermissionVM permissionVMMm = new PermissionVM()
                    {
                        Permissions = _context.PermissionToEmployeees.Where(w => w.Emplooyee.CompanyId == appUser.CompaniesId && w.Permission.FromDate.Month == DateTime.Now.Month &&
                        //w.Permission.FromDateForHour.Month == DateTime.Now.Month &&
                        w.Permission.FromDate.Year == DateTime.Now.Year &&
                        //w.Permission.FromDateForHour.Year == DateTime.Now.Year &&
                        w.Permission.Confirm != false).OrderByDescending(w => w.Permission.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_PermissionPartial.cshtml", permissionVMMm);
                }

                PermissionVM permissionVMM = new PermissionVM()
                {
                    Permissions = _context.PermissionToEmployeees.Where(w => w.Emplooyee.CompanyId == appUser.CompaniesId && w.Permission.Confirm != false).OrderByDescending(w => w.Permission.FromDate).ToList(),
                };
                return PartialView("~/Areas/Employee/Views/Shared/PartialView/_PermissionPartial.cshtml", permissionVMM);
            }
            PermissionVM permissionVM = new PermissionVM()
            {
                Permissions = _context.PermissionToEmployeees.Where(w => (w.Emplooyee.FirstName.Contains(getName) || w.Emplooyee.Lastname.Contains(getName)) && w.Emplooyee.CompanyId == appUser.CompaniesId && w.Permission.Confirm != false).OrderByDescending(w => w.Permission.FromDate).ToList(),
            };
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_PermissionPartial.cshtml", permissionVM);
        }

        public IActionResult AllVacation()
        {
            return View();
        }
    }
}
