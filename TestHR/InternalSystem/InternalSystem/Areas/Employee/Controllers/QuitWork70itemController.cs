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
    public class QuitWork70itemController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public QuitWork70itemController(InternalSysDBContext context, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }
        public async Task<IActionResult> Create()
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandEmployeeVM reprimandVM = new CommandEmployeeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.PositionsId != null && e.CompanyId == findUser.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Emplooyee.Status != true && c.Emplooyee.IsWorking != true && c.Emplooyee.IsCandidate == false &&
                                                                         c.Emplooyee.PositionsId != null && c.Emplooyee.CompanyId == findUser.CompaniesId && c.Command.Name == "Xitam(70in ç-si ilə)").Take(300).ToList()
            };
            return View(reprimandVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CommandEmployeeVM employeeVM)
        {
            AppUser currentHeadHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandEmployeeVM quitWorkVM = new CommandEmployeeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.PositionsId != null && e.CompanyId == currentHeadHR.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Emplooyee.Status != true && c.Emplooyee.IsWorking != true && c.Emplooyee.IsCandidate == false &&
                                                                         c.Emplooyee.PositionsId != null && c.Emplooyee.CompanyId == currentHeadHR.CompaniesId && c.Command.Name == "Xitam(70in ç-si ilə)").Take(300).ToList()
            };

            if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid ||
                ModelState["CreatedDate"].ValidationState != ModelValidationState.Invalid)
            {
                Commands findCommand = _context.Commands.Where(c => c.Status != false && c.Name == "Xitam(70in ç-si ilə)").FirstOrDefault();
                if (findCommand == null) return NotFound();
                Emplooyee findEmp = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.CompanyId == currentHeadHR.CompaniesId && e.Id == employeeVM.EmplooyeeId).FirstOrDefault();
                if (findEmp == null) return NotFound();
                if (employeeVM.PdfScanQuitWork != null)
                {
                    if (!employeeVM.PdfScanQuitWork.IsPdf())
                    {
                        ModelState.AddModelError("PdfScanQuitWork", "Zəhmət olmasa pdf faylını düzgün seçin");
                        return View(quitWorkVM);
                    }
                    if (!employeeVM.PdfScanQuitWork.PdfSize(4))
                    {
                        ModelState.AddModelError("PdfScanQuitWork", "Pdf faylının ölçüsü 4Mb-dan artıq ola bilməz");
                        return View(quitWorkVM);
                    }
                }


                AppUser findEmpAspNetUsersTable = await _userManager.FindByEmailAsync(findEmp.Email);
                findEmp.Status = false;
                findEmp.IsWorking = false;
                findEmpAspNetUsersTable.Status = false;

                CommandsToEmployee quitWorkToEmployee = new CommandsToEmployee();
                quitWorkToEmployee.CommandId = findCommand.Id;
                quitWorkToEmployee.EmplooyeeId = employeeVM.EmplooyeeId;
                quitWorkToEmployee.CreatedDate = employeeVM.CreatedDate;
                quitWorkToEmployee.TimeOfExecution = DateTime.Now;
                await _context.CommandsToEmployees.AddAsync(quitWorkToEmployee);
                await _context.SaveChangesAsync();

                string filenameScan = await employeeVM.PdfScanQuitWork.CopyImage(_env.WebRootPath, "userOtherDocs/pdfQuitWork");

                //Add Old Salary Table
                AllCommandsHistory reprimandPdf = new AllCommandsHistory()
                {
                    EmplooyeeId = employeeVM.EmplooyeeId,
                    CommandsToEmployeeId = quitWorkToEmployee.Id,
                    Pdf = filenameScan
                };

                await _context.AllCommandsHistories.AddAsync(reprimandPdf);
                await _context.SaveChangesAsync();

                //TempData["quitEmpMsg"] = "Added";

                return RedirectToAction(nameof(Create));
            }
            return View(quitWorkVM);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != true && w.Emplooyee.IsWorking != true &&
                                                                 w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandEmployeeVM quitWorkVM = new CommandEmployeeVM()
            {
                CommandsToEmployee = commandForEmp,
                AllCommandsHistory = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault(),
            };
            return View(quitWorkVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CommandEmployeeVM commandsQuitWork, int? id)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != true && w.Emplooyee.IsWorking != true &&
                                                                 w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandEmployeeVM quitWorkVM = new CommandEmployeeVM()
            {
                CommandsToEmployee = commandForEmp,
                AllCommandsHistory = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault(),
            };
            if (ModelState["CreatedDate"].ValidationState != ModelValidationState.Invalid)
            {
                var allCommandsHis = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault();
                var checkCommand = _context.CommandsToEmployees.Where(w => w.Id == id).FirstOrDefault();
                if (checkCommand == null) NotFound();

                if (commandsQuitWork.PdfScanQuitWorkUpd != null)
                {
                    if (!commandsQuitWork.PdfScanQuitWorkUpd.IsPdf())
                    {
                        ModelState.AddModelError("PdfScanQuitWorkUpd", "Zəhmət olmasa pdf faylını düzgün seçin");
                        return View(quitWorkVM);
                    }

                    if (!commandsQuitWork.PdfScanQuitWorkUpd.PdfSize(2))
                    {
                        ModelState.AddModelError("PdfScanQuitWorkUpd", "Pdf faylının ölçüsü 2Mb-dan artıq ola bilməz");
                        return View(quitWorkVM);
                    }

                    string filenameScanPdf = await commandsQuitWork.PdfScanQuitWorkUpd.CopyPdf(_env.WebRootPath, "userOtherDocs/pdfQuitWork");
                    Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, allCommandsHis.Pdf);
                    allCommandsHis.Pdf = filenameScanPdf;
                }
                checkCommand.CreatedDate = commandsQuitWork.CreatedDate;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(quitWorkVM);
        }
    }
}
