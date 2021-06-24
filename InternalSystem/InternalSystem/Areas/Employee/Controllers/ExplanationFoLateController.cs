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
    public class ExplanationFoLateController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        //private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHostingEnvironment _env;
        private PermissionType findPermission;
        public ExplanationFoLateController(InternalSysDBContext context, UserManager<AppUser> userManager,
                               RoleManager<IdentityRole> roleManager, IHostingEnvironment env)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
            _env = env;
        }


        public async Task<IActionResult> CreateExplanation()
        {
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            AppUser user = await _userManager.FindByEmailAsync(User.Identity.Name);

            if (user == null)
            {
                return NotFound();
            }

            EXPLANANTIONVM permissionForHrVM = new EXPLANANTIONVM()
            {
                Explanations = _context.ExplanationToEmployees.Where(x => x.EmplooyeeId == user.EmplooyeeId).OrderByDescending(x => x.Explanation.CreatingTime).ToList(),

                PermissionTypes = _context.PermissionTypes.ToList(),
            };
            return View(permissionForHrVM);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> CreateExplanation(EXPLANANTIONVM eXPLANANTIONVM)
        {
            AppUser user = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (user == null) return NotFound();

            eXPLANANTIONVM.Explanations = _context.ExplanationToEmployees.Where(s => s.EmplooyeeId == user.EmplooyeeId).OrderByDescending(x => x.Explanation.CreatingTime).ToList();
            eXPLANANTIONVM.PermissionTypes = _context.PermissionTypes.ToList();

            if (ModelState["PermissionTypeName"].ValidationState == ModelValidationState.Invalid)
            {
                return View(eXPLANANTIONVM);

            }

            if (eXPLANANTIONVM.PermissionTypeName == "Saatlıq")
            {
                findPermission = _context.PermissionTypes.Find(1);
            }
            else if (eXPLANANTIONVM.PermissionTypeName == "Günlük")
            {
                findPermission = _context.PermissionTypes.Find(2);
            }
            Explanation newexplanation = new Explanation();
            if (findPermission.Name == "Saatlıq")
            {

                if (string.IsNullOrWhiteSpace(eXPLANANTIONVM.ReasonOne))
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa səbəbi daxil edin!!";
                    eXPLANANTIONVM.Explanations = _context.ExplanationToEmployees.Where(w => w.EmplooyeeId == user.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    eXPLANANTIONVM.PermissionTypes = _context.PermissionTypes.ToList();
                    return View(eXPLANANTIONVM);
                }
                if (eXPLANANTIONVM.ReasonOne.Length > 300)
                {
                    ViewData["fillAllInputs"] = "Səbəb 300 hərfdən artıq ola bilməz";
                    eXPLANANTIONVM.Permissions = _context.PermissionToEmployeees.Where(w => w.EmplooyeeId == user.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    eXPLANANTIONVM.PermissionTypes = _context.PermissionTypes.ToList();
                    return View(eXPLANANTIONVM);
                }
                //var findToDate = permission.FromDate.AddHours(permission.Hour); //find beetwen hours
                newexplanation.FromDateForHour = eXPLANANTIONVM.FromDateForHour;
                newexplanation.ToDate = eXPLANANTIONVM.ToDateForHour;
                newexplanation.FromDate = eXPLANANTIONVM.FromDate;
                newexplanation.PermissionTypeId = findPermission.Id;
                //newPermission.FromDate = permission.FromDate;
                newexplanation.CreatingTime = DateTime.Now;
                newexplanation.Description = eXPLANANTIONVM.Description;
                newexplanation.Reason = eXPLANANTIONVM.ReasonOne;
            }
            else if (findPermission.Name == "Günlük")
            {
                if (string.IsNullOrWhiteSpace(eXPLANANTIONVM.ReasonOne))
                {
                    ViewData["fillAllInputs"] = "Zəhmət olmasa səbəbi daxil edin!!";
                    eXPLANANTIONVM.Explanations = _context.ExplanationToEmployees.Where(w => w.EmplooyeeId == user.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                    eXPLANANTIONVM.PermissionTypes = _context.PermissionTypes.ToList();
                    return View(eXPLANANTIONVM);
                }
                //if (eXPLANANTIONVM.Description.Length > 300)
                //{
                //    ViewData["fillAllInputs"] = "Səbəb 100 hərfdən artıq ola bilməz";
                //    eXPLANANTIONVM.Explanations = _context.ExplanationToEmployees.Where(w => w.EmplooyeeId == user.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
                //    eXPLANANTIONVM.PermissionTypes = _context.PermissionTypes.ToList();
                //    return View(eXPLANANTIONVM);
                //}


                //newPermission.PermissionTypeId = findPermission.Id;
                //newPermission.FromDate = permisionVM.FromDateForDay;
                //newPermission.ToDate = permisionVM.ToDateForDay;

                //newPermission.Reason = permisionVM.ReasonTwo;
                
                //newPermission.CreatingTime = DateTime.Now;
                //bax indi debug edirem fikir ver descrtiption null gelecek


                newexplanation.PermissionTypeId = findPermission.Id;
                newexplanation.FromDate = eXPLANANTIONVM.FromDateForDay;
                newexplanation.ToDate = eXPLANANTIONVM.ToDateForDay;
                newexplanation.Reason = eXPLANANTIONVM.ReasonOne;//dropdownsert
                newexplanation.Description = eXPLANANTIONVM.Description2;//textartarea
                newexplanation.CreatingTime = DateTime.Now;
              


            }
            //else if (findPermission.Name == "Günlük")
            //{
            //    if (string.IsNullOrWhiteSpace(eXPLANANTIONVM.Description))
            //    {
            //        ViewData["fillAllInputs"] = "Zəhmət olmasa saat seçin və bütün xanaları doldurun";

            //        eXPLANANTIONVM.Explanations = _context.ExplanationToEmployees.Where(w => w.EmplooyeeId == user.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
            //        eXPLANANTIONVM.PermissionTypes = _context.PermissionTypes.ToList();
            //        return View(eXPLANANTIONVM);
            //    }
            //    if (eXPLANANTIONVM.Description.Length > 125)
            //    {
            //        ViewData["fillAllInputs"] = "Səbəb 100 hərfdən artıq ola bilməz";
            //        eXPLANANTIONVM.Explanations = _context.ExplanationToEmployees.Where(w => w.EmplooyeeId == user.EmplooyeeId).OrderByDescending(w => w.Id).ToList();
            //        eXPLANANTIONVM.PermissionTypes = _context.PermissionTypes.ToList();
            //        return View(eXPLANANTIONVM);
            //    }
            //    newexplanation.PermissionTypeId = findPermission.Id;
            //    newexplanation.FromDate = eXPLANANTIONVM.FromDateForDay;
            //    newexplanation.ToDate = eXPLANANTIONVM.ToDateForDay;
            //    newexplanation.Description = eXPLANANTIONVM.Description;
            //   // newexplanation.Description = eXPLANANTIONVM.Description;
            //    newexplanation.ExeTime = DateTime.Now;
            //}
            await _context.Explanations.AddAsync(newexplanation);
            await _context.SaveChangesAsync();
            ExplanationToEmployee explanationToEmployee = new ExplanationToEmployee();
            explanationToEmployee.EmplooyeeId = user.EmplooyeeId;
            explanationToEmployee.Emplooyee = _context.Emplooyeees.Where(w => w.Id == user.EmplooyeeId).FirstOrDefault();
            explanationToEmployee.PermissionId = newexplanation.Id;
            explanationToEmployee.Explanation = newexplanation;
            await _context.ExplanationToEmployees.AddAsync(explanationToEmployee);
            await _context.SaveChangesAsync();
            ModelState.Clear();
            EXPLANANTIONVM permissionVM = new EXPLANANTIONVM()
            {
                Explanations = _context.ExplanationToEmployees.Where(w => w.EmplooyeeId == user.EmplooyeeId).OrderByDescending(w => w.Id).ToList().Take(100),
                PermissionTypes = _context.PermissionTypes.ToList(),
            };
            //return View(permissionVM);
            return RedirectToAction(nameof(CreateExplanation));

        }





    }
}
