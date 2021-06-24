using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.Permissions;
using InternalSystem.Areas.InternalHR.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InternalSystem.Areas.InternalHR.Controllers
{
    [Area("InternalHR")]
    [Authorize(Roles = "HumanResource,HrDepartmentBoss")]
    public class PermissionForHr : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        //private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHostingEnvironment _env;
        public PermissionForHr(InternalSysDBContext context, UserManager<AppUser> userManager,
                               RoleManager<IdentityRole> roleManager, IHostingEnvironment env)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
            _env = env;
        }


        public async Task<IActionResult> AllPermitionsForHR()
        {
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            PermissionForHrVM permissionVM = new PermissionForHrVM()
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
                        w.Permission.FromDateForHour.Month == DateTime.Now.Month &&
                        w.Permission.FromDate.Year == DateTime.Now.Year &&
                        w.Permission.FromDateForHour.Year == DateTime.Now.Year &&
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
                        Permissions = _context.PermissionToEmployeees.Where(w => w.Permission.Confirm != false&& w.Emplooyee.CompanyId==appUser.CompaniesId).OrderByDescending(w => w.Permission.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_PermissionPartial.cshtml", permissionVMm);
                }
                else if (howSearch == "daily")
                {
                    PermissionVM permissionVMmm = new PermissionVM()
                    {
                        Permissions = _context.PermissionToEmployeees.Where(w => w.Emplooyee.CompanyId == appUser.CompaniesId && w.Permission.FromDate.Day == DateTime.Now.Day &&
                        w.Permission.FromDateForHour.Day == DateTime.Now.Day && w.Permission.Confirm != false).OrderByDescending(w => w.Permission.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_PermissionPartial.cshtml", permissionVMmm);
                }
                else if (howSearch == "monthly")
                {
                    PermissionVM permissionVMMm = new PermissionVM()
                    {
                        Permissions = _context.PermissionToEmployeees.Where(w => w.Emplooyee.CompanyId == appUser.CompaniesId && w.Permission.FromDate.Month == DateTime.Now.Month &&
                        w.Permission.FromDateForHour.Month == DateTime.Now.Month &&
                        w.Permission.FromDate.Year == DateTime.Now.Year &&
                        w.Permission.FromDateForHour.Year == DateTime.Now.Year &&
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
        [HttpGet]
        public async Task<IActionResult> searchExp(string getName, string howSearch)
        {

            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (howSearch != null && getName != null)
            {
                if (howSearch == "all")
                {
                    EXPLANANTIONVM permissionVMm = new EXPLANANTIONVM()
                    {
                        Explanations = _context.ExplanationToEmployees.Where(w => (w.Emplooyee.FirstName.Contains(getName) || w.Emplooyee.Lastname.Contains(getName)) && w.Emplooyee.CompanyId == appUser.CompaniesId ).OrderByDescending(w => w.Explanation.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_ExplanationPartial.cshtml", permissionVMm);
                }
                else if (howSearch == "daily")
                {
                    EXPLANANTIONVM permissionVMmm = new EXPLANANTIONVM()
                    {
                        Explanations = _context.ExplanationToEmployees.Where(w => (w.Emplooyee.FirstName.Contains(getName) || w.Emplooyee.Lastname.Contains(getName)) && w.Emplooyee.CompanyId == appUser.CompaniesId && w.Explanation.FromDate.Day == DateTime.Now.Day &&
                        w.Explanation.FromDateForHour.Day == DateTime.Now.Day ).OrderByDescending(w => w.Explanation.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_ExplanationPartial.cshtml", permissionVMmm);
                }
                else if (howSearch == "monthly")
                {
                    EXPLANANTIONVM permissionVMM = new EXPLANANTIONVM()
                    {
                        Explanations = _context.ExplanationToEmployees.Where(w => (w.Emplooyee.FirstName.Contains(getName) || w.Emplooyee.Lastname.Contains(getName)) && w.Emplooyee.CompanyId == appUser.CompaniesId && w.Explanation.FromDate.Month == DateTime.Now.Month &&
                        w.Explanation.FromDateForHour.Month == DateTime.Now.Month &&
                        w.Explanation.FromDate.Year == DateTime.Now.Year &&
                        w.Explanation.FromDateForHour.Year == DateTime.Now.Year).OrderByDescending(w => w.Explanation.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_ExplanationPartial.cshtml", permissionVMM);
                }
            }
            else if (getName == null && howSearch != null)
            {
                if (howSearch == "all")
                {
                    EXPLANANTIONVM permissionVMm = new EXPLANANTIONVM()
                    {
                        Explanations = _context.ExplanationToEmployees.Where( w=> w.Emplooyee.CompanyId == appUser.CompaniesId).OrderByDescending(w => w.Explanation.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_ExplanationPartial.cshtml", permissionVMm);
                }
                else if (howSearch == "daily")
                {
                    EXPLANANTIONVM permissionVMmm = new EXPLANANTIONVM()
                    {
                        Explanations = _context.ExplanationToEmployees.Where(w => w.Emplooyee.CompanyId == appUser.CompaniesId && w.Explanation.FromDate.Day == DateTime.Now.Day &&
                        w.Explanation.FromDateForHour.Day == DateTime.Now.Day  ).OrderByDescending(w => w.Explanation.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_ExplanationPartial.cshtml", permissionVMmm);
                }
                else if (howSearch == "monthly")
                {
                    EXPLANANTIONVM permissionVMMm = new EXPLANANTIONVM()
                    {
                        Explanations = _context.ExplanationToEmployees.Where(w => w.Emplooyee.CompanyId == appUser.CompaniesId && w.Explanation.FromDate.Month == DateTime.Now.Month &&
                        w.Explanation.FromDateForHour.Month == DateTime.Now.Month &&
                        w.Explanation.FromDate.Year == DateTime.Now.Year &&
                        w.Explanation.FromDateForHour.Year == DateTime.Now.Year).OrderByDescending(w => w.Explanation.FromDate).ToList(),
                    };
                    return PartialView("~/Areas/Employee/Views/Shared/PartialView/_ExplanationPartial.cshtml", permissionVMMm);
                }

                EXPLANANTIONVM permissionVMM = new EXPLANANTIONVM()
                {
                    Explanations = _context.ExplanationToEmployees.Where(w => w.Emplooyee.CompanyId == appUser.CompaniesId ).OrderByDescending(w => w.Explanation.FromDate).ToList(),
                };
                return PartialView("~/Areas/Employee/Views/Shared/PartialView/_ExplanationPartial.cshtml", permissionVMM);
            }
            EXPLANANTIONVM permissionVM = new EXPLANANTIONVM()
            {
                Explanations = _context.ExplanationToEmployees.Where(w => (w.Emplooyee.FirstName.Contains(getName) || w.Emplooyee.Lastname.Contains(getName)) && w.Emplooyee.CompanyId == appUser.CompaniesId).OrderByDescending(w => w.Explanation.FromDate).ToList(),
            };
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_ExplanationPartial.cshtml", permissionVM);
        }

        public async Task<IActionResult> AllExplanationForHr()
        {
            AppUser user = await _userManager.FindByEmailAsync(User.Identity.Name);
            ExplanationForHrVM explanationForHrVM = new ExplanationForHrVM()
            {
                Explanations = _context.ExplanationToEmployees.Where(x => x.Emplooyee.CompanyId == user.CompaniesId).OrderByDescending(x => x.Explanation.ExeTime).ToList(),

            };
            return View(explanationForHrVM);
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AppUser currentHr = await _userManager.FindByEmailAsync(User.Identity.Name);
            ExplanationToEmployee explanation = await _context.ExplanationToEmployees.FindAsync(id);
            ExplanationHRVm explanationHRVm = new ExplanationHRVm()
            {
                ExplanationToEmploy = _context.ExplanationToEmployees.Where(x => x.Emplooyee.CompanyId == currentHr.CompaniesId && x.Id == id).FirstOrDefault(),

            };
            if (explanationHRVm == null)
            {
                return NotFound();
            }


            return View(explanationHRVm);
        }
    }
}
