using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss")]
    public class CommandDepBossQuitWorkController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public CommandDepBossQuitWorkController(InternalSysDBContext context, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }
        public async Task<IActionResult> CommandDepBossQuitWorkk()
        {
            AppUser currentHeadHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandDepBossVM quitWorkVM = new CommandDepBossVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.PositionsId == null && e.CompanyId == currentHeadHR.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Emplooyee.Status != true && c.Emplooyee.IsWorking != true && c.Emplooyee.IsCandidate == false &&
                                                                         c.Emplooyee.PositionsId == null && c.Emplooyee.CompanyId == currentHeadHR.CompaniesId && c.Command.Name == "Xitam").Take(300).ToList(),
                DepartmentToCompanies = _context.DepartmentToCompanies.Where(c => c.Meneger.Status != false && c.Meneger.IsWorking != false && c.Meneger.IsCandidate == false &&
                                                                             c.Department.Status != false && c.Company.status != false && c.Meneger.CompanyId == currentHeadHR.CompaniesId).ToList()
            };
            return View(quitWorkVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CommandDepBossQuitWorkk(CommandDepBossVM depBossVM)
        {
            AppUser currentHeadHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandDepBossVM quitWorkVM = new CommandDepBossVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.PositionsId == null && e.CompanyId == currentHeadHR.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Emplooyee.Status != true && c.Emplooyee.IsWorking != true && c.Emplooyee.IsCandidate == false &&
                                                                         c.Emplooyee.PositionsId == null && c.Emplooyee.CompanyId == currentHeadHR.CompaniesId && c.Command.Name == "Xitam").Take(300).ToList(),
                DepartmentToCompanies = _context.DepartmentToCompanies.Where(c => c.Meneger.Status != false && c.Meneger.IsWorking != false && c.Meneger.IsCandidate == false &&
                                                                             c.Department.Status != false && c.Company.status != false && c.Meneger.CompanyId == currentHeadHR.CompaniesId).ToList()
            };
            if (ModelState["EmployeeId"].ValidationState != ModelValidationState.Invalid ||
                ModelState["CreatedDate"].ValidationState != ModelValidationState.Invalid ||
                ModelState["Reason"].ValidationState != ModelValidationState.Invalid)
            {
                Commands findCommand = _context.Commands.Where(c => c.Status != false && c.Name == "Xitam").FirstOrDefault();
                if (findCommand == null) return NotFound();
                Emplooyee findEmp = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.CompanyId == currentHeadHR.CompaniesId && e.Id == depBossVM.EmployeeId).FirstOrDefault();
                if (findEmp == null) return NotFound();
                if (depBossVM.PdfScanQuitWork != null)
                {
                    if (!depBossVM.PdfScanQuitWork.IsPdf())
                    {
                        ModelState.AddModelError("PdfScanQuitWork", "Zəhmət olmasa pdf faylını düzgün seçin");
                        return View(quitWorkVM);
                    }
                    if (!depBossVM.PdfScanQuitWork.PdfSize(4))
                    {
                        ModelState.AddModelError("PdfScanQuitWork", "Pdf faylının ölçüsü 4Mb-dan artıq ola bilməz");
                        return View(quitWorkVM);
                    }
                }
                AppUser findEmpAspNetUsersTable = await _userManager.FindByEmailAsync(findEmp.Email);
                findEmp.Status = false;
                findEmp.IsWorking = false;
                findEmpAspNetUsersTable.Status = false;

                CommandsToEmployee quitWorkToDepBoss = new CommandsToEmployee();
                quitWorkToDepBoss.CommandId = findCommand.Id;
                quitWorkToDepBoss.EmplooyeeId = depBossVM.EmployeeId;
                quitWorkToDepBoss.CreatedDate = depBossVM.CreatedDate;
                quitWorkToDepBoss.TimeOfExecution = DateTime.Now;
                await _context.CommandsToEmployees.AddAsync(quitWorkToDepBoss);
                await _context.SaveChangesAsync();
                if (depBossVM.PdfScanQuitWork != null)
                {
                    string filenameScan = await depBossVM.PdfScanQuitWork.CopyImage(_env.WebRootPath, "userOtherDocs/pdfQuitWork");
                    ScanPdfQuitWork scanPdfQuitEmp = new ScanPdfQuitWork();
                    scanPdfQuitEmp.Pdf = filenameScan;
                    scanPdfQuitEmp.CommandsToEmployeeId = quitWorkToDepBoss.Id;
                    await _context.ScanPdfQuitWorks.AddAsync(scanPdfQuitEmp);
                    await _context.SaveChangesAsync();
                }
                TempData["quitDepBossMsg"] = "Added";
                return RedirectToAction(nameof(CommandDepBossQuitWorkk));
            }
                return View(quitWorkVM);
        }
    }
}
