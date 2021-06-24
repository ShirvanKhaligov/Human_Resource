using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.Employee.Controllers
{

    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss")]
    public class ReawardController : Controller
    {
        private readonly InternalSysDBContext context;
        private readonly UserManager<AppUser> usermanager;
        private readonly IHostingEnvironment env;
        public ReawardController(InternalSysDBContext _context, UserManager<AppUser> _userManager, IHostingEnvironment _env)
        {
            context = _context;
            usermanager = _userManager;
            env = _env;
        }
        public async Task< IActionResult> GetRewardScan(int? employeeId)
        {
            AppUser FindCurrentHeadHr = await usermanager.FindByEmailAsync(User.Identity.Name);
            if (employeeId == null) return NotFound();

            RewardCommandVM RewardScan = new RewardCommandVM()
            {

                ScanForReward = await context.ScanForRewards.Where(x=>x.RewardToEmployee.Emplooyee.Status==true
                &&x.RewardToEmployee.Emplooyee.IsWorking==true
                &&x.RewardToEmployee.Emplooyee.IsCandidate==false&& x.RewardToEmployee.Emplooyee.CompanyId==FindCurrentHeadHr.CompaniesId&& x.RewardToEmployee.EmplooyeeId==employeeId).FirstOrDefaultAsync(),

            };
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_RewardScanToEployee.cshtml", RewardScan);
        }
        public async Task<IActionResult> EmployeeReawrd()
        {
            AppUser currentDepBossHr = await usermanager.FindByEmailAsync(User.Identity.Name);
            RewardCommandVM rewardCommandVM = new RewardCommandVM()
            {
                Emplooyees = context.Emplooyeees.Where(x => x.Status == true && x.IsWorking == true && x.IsCandidate == false && x.CompanyId == currentDepBossHr.CompaniesId).ToList(),

                RewardToEmployees = context.RewardToEmployees.Where(x => x.Emplooyee.Status == true
                  && x.Reward.Status == true
                  && x.Emplooyee.IsWorking == true
                  && x.Emplooyee.IsCandidate == false
                  && x.Emplooyee.CompanyId == currentDepBossHr.CompaniesId
                  && x.Reward.Name == "Mukafat").ToList()

            };
            return View(rewardCommandVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        async public Task<IActionResult> EmployeeReawrd(RewardCommandVM rewardCommandVM)
        {
            AppUser CurrentHrBos = await usermanager.FindByEmailAsync(User.Identity.Name);
            RewardCommandVM rewardCommand = new RewardCommandVM()
            {
                Emplooyees = context.Emplooyeees.Where(x => x.Status == true && x.IsWorking == true && x.IsCandidate == false && x.CompanyId == CurrentHrBos.CompaniesId).ToList(),

                RewardToEmployees = context.RewardToEmployees.Where(x => x.Emplooyee.Status == true
                  && x.Reward.Status == true
                  && x.Emplooyee.IsWorking == true
                  && x.Emplooyee.IsCandidate == false
                  && x.Emplooyee.CompanyId == CurrentHrBos.CompaniesId
                  && x.Reward.Name == "Mukafat").ToList()
            };


            if ((ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid ||
                ModelState["CreatedDate"].ValidationState != ModelValidationState.Invalid ||
                ModelState["Reason"].ValidationState != ModelValidationState.Invalid ||
                ModelState["Money"].ValidationState!=ModelValidationState.Invalid))
            {
                Reward fndreward = context.Rewards.Where(x => x.Status == true && x.Name == "Mukafat").FirstOrDefault();

                if (fndreward == null) return NotFound();
                Emplooyee findEmp = context.Emplooyeees.Where(e => e.Status == true && e.IsWorking == true && e.CompanyId == CurrentHrBos.CompaniesId && e.Id == rewardCommandVM.EmplooyeeId).FirstOrDefault();
                if (rewardCommandVM.ScanRward != null)
                {
                    if (!rewardCommandVM.ScanRward.IsPdf())
                    {
                        ModelState.AddModelError("ScanRward", "Zəhmət olmasa pdf faylını düzgün seçin");
                        return View(rewardCommand);
                    }
                    if (!rewardCommandVM.ScanRward.PdfSize(4))
                    {
                        ModelState.AddModelError("ScanRward", "Pdf faylının ölçüsü 4 Mb-dan artıq ola bilməz");
                        return View(rewardCommand);
                    }

                }
                AppUser findEmpAspNetUsersTable = await usermanager.FindByEmailAsync(findEmp.Email);
                RewardToEmployee rewardToEmployee = new RewardToEmployee();
                rewardToEmployee.RewardId = fndreward.Id;
                rewardToEmployee.EmplooyeeId = rewardCommandVM.EmplooyeeId;
                rewardToEmployee.CreatedDate = rewardCommandVM.CreatedDate;
                rewardToEmployee.TimeOfExecution = DateTime.Now;
                rewardToEmployee.Money = rewardCommandVM.Money;
                rewardToEmployee.Reason = rewardCommandVM.Reason;
                await context.RewardToEmployees.AddAsync(rewardToEmployee);

                await context.SaveChangesAsync();
                if (rewardCommandVM.ScanRward != null)
                {
                    string filenameScan = await rewardCommandVM.ScanRward.CopyImage(env.WebRootPath, "userOtherDocs/mukafat");
                    ScanForReward scanreward = new ScanForReward();
                    scanreward.Pdf = filenameScan;
                    scanreward.RewardToEmployeeId = rewardToEmployee.Id;
                    await context.ScanForRewards.AddAsync(scanreward);
                    await context.SaveChangesAsync();

                }
                TempData["quitEmpMsg"] = "Added";
                // ModelState.Clear();
                return RedirectToAction(nameof(EmployeeReawrd));
            }

            return View(rewardCommandVM);
        }      
        public async Task<IActionResult> Detail( int? id)
        {
            if (id == null) return NotFound();

            AppUser FindCurrentHr = await usermanager.FindByEmailAsync(User.Identity.Name);
            RewardToEmployee rewardToEmployee = await context.RewardToEmployees.FindAsync(id);
            RewardCommandVM rewardCommandVM = new RewardCommandVM()
            {
                RewardToEmployee = context.RewardToEmployees.Where(x => x.Reward.Status == true &&x.Id==id
                  && x.Emplooyee.Status == true && x.Emplooyee.IsWorking == true && x.Emplooyee.CompanyId == FindCurrentHr.CompaniesId).FirstOrDefault(),
            };
            if (rewardCommandVM == null) return NotFound();

          
            return View(rewardCommandVM);

        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var rewardtoemplo = await context.RewardToEmployees.Where(x => x.Status == true && x.Emplooyee.Status == true && x.Emplooyee.Status == true).FirstOrDefaultAsync();
            if (rewardtoemplo == null)
            {
                return NotFound();

            }

            AppUser currentHr = await usermanager.FindByEmailAsync(User.Identity.Name);
            RewardCommandVM rewardCommandVM = new RewardCommandVM
            {
                RewardToEmployees = context.RewardToEmployees.Where(x => x.Status == true && x.EmplooyeeId == id).ToList(),
                Emplooyees = context.Emplooyeees.Where(x => x.Status == true && x.Status == true
                  && x.IsWorking == true
                  && x.IsCandidate == false
                  && x.CompanyId == currentHr.CompaniesId)
            };
            return View(rewardtoemplo);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            AppUser FindHrBoss = await usermanager.FindByEmailAsync(User.Identity.Name);


            return View();
        }
    }
}
