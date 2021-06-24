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
    public class CommandEmpQuitWorkController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public CommandEmpQuitWorkController(InternalSysDBContext context, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }

        public async Task<IActionResult> CommandEmpQuitWorkk()
        {
            AppUser currentHeadHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandEmployeeVM quitWorkVM = new CommandEmployeeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.PositionsId != null && e.CompanyId == currentHeadHR.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Emplooyee.Status != true && c.Emplooyee.IsWorking != true && c.Emplooyee.IsCandidate == false &&
                                                                         c.Emplooyee.PositionsId != null && c.Emplooyee.CompanyId == currentHeadHR.CompaniesId && c.Command.Name == "Xitam").Take(300).ToList()
            ,
                Items = _context.Items.ToList(),
            };
            return View(quitWorkVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CommandEmpQuitWorkk(CommandEmployeeVM employeeVM)
        {
            AppUser currentHeadHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            //Emplooyee findEmp = _context.Emplooyeees.Where(e => e.Status != true && e.IsWorking != true && e.Id == employeeVM.EmplooyeeId).FirstOrDefault();
            //AppUser findEmpAspNetUsersTable = await _userManager.FindByEmailAsync(findEmp.Email);
            CommandEmployeeVM quitWorkVM = new CommandEmployeeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.PositionsId != null && e.CompanyId == currentHeadHR.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Emplooyee.Status != true && c.Emplooyee.IsWorking != true && c.Emplooyee.IsCandidate == false &&
                                                                         c.Emplooyee.PositionsId != null && c.Emplooyee.CompanyId == currentHeadHR.CompaniesId && c.Command.Name == "Xitam").Take(300).ToList(),
                Items = _context.Items.ToList(),
            };

            if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid ||
                ModelState["CreatedDate"].ValidationState != ModelValidationState.Invalid ||
                ModelState["Reason"].ValidationState != ModelValidationState.Invalid ||
                ModelState["ItemId"].ValidationState != ModelValidationState.Invalid)
            {
                Commands findCommand = _context.Commands.Where(c => c.Status != false && c.Name == "Xitam").FirstOrDefault();
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
                //quitWorkToEmployee.Command.Description = employeeVM.Reason;
                //quitWorkToEmployee.Description = employeeVM.Reason;
                quitWorkToEmployee.ItemId = employeeVM.ItemId;

                quitWorkToEmployee.TimeOfExecution = DateTime.Now;
                await _context.CommandsToEmployees.AddAsync(quitWorkToEmployee);
                await _context.SaveChangesAsync();
                if (employeeVM.PdfScanQuitWork != null)
                {
                    //string filenameScan = await employeeVM.PdfScanQuitWork.CopyImage(_env.WebRootPath, "userOtherDocs/pdfQuitWork");
                    //ScanPdfQuitWork scanPdfQuitEmp = new ScanPdfQuitWork();
                    //scanPdfQuitEmp.Pdf = filenameScan;
                    //scanPdfQuitEmp.CommandsToEmployeeId = quitWorkToEmployee.Id;
                    //await _context.ScanPdfQuitWorks.AddAsync(scanPdfQuitEmp);
                    //await _context.SaveChangesAsync();
                    string filenameScan = await employeeVM.PdfScanQuitWork.CopyImage(_env.WebRootPath, "userOtherDocs/pdfQuitWork");
                    ScanPdfCommands scanPdfQuitEmp = new ScanPdfCommands();
                    scanPdfQuitEmp.EmplooyeeId = employeeVM.EmplooyeeId;
                    scanPdfQuitEmp.Pdf = filenameScan;
                    //scanPdfQuitEmp.CommandsToEmployeeId = quitWorkToEmployee.Id;
                    scanPdfQuitEmp.CreatedDate = DateTime.Now;
                    await _context.ScanPdfCommands.AddAsync(scanPdfQuitEmp);
                    await _context.SaveChangesAsync();
                }
                TempData["quitEmpMsg"] = "Added";
                return RedirectToAction(nameof(CommandEmpQuitWorkk));
            }
            return View(quitWorkVM);
        }


        public IActionResult CommandEmpVacation()
        {
            return View();
        }


        public async Task<IActionResult> Update()
        {
            return Ok();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            AppUser currentusr = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandfoEmp = _context.CommandsToEmployees.Where(s => s.Emplooyee.Status == true && s.Emplooyee.IsWorking == true && s.Emplooyee.IsCandidate == false && s.Id == id).FirstOrDefault();
            CommandEmployeeVM commandEmployeeVM = new CommandEmployeeVM()
            {
                CommandsToEmployee = commandfoEmp,
                AllCommandsHistory = _context.AllCommandsHistories.Where(x => x.CommandsToEmployeeId == id).FirstOrDefault(),
            };
            return View(commandEmployeeVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public async Task<IActionResult> XitamDeyis(CommandEmployeeVM commandEmployeeVM,int? id)
        {

            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();

            return Ok();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(CommandSurnameChangeVM commandsSurname, int? id)
        //{
        //    AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
        //    var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
        //                                                        w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
        //    CommandSurnameChangeVM surnameChangeVM = new CommandSurnameChangeVM()
        //    {
        //        CommandsToEmployee = commandForEmp,
        //        AllCommandsHistory = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault(),
        //    };
        //    if (ModelState["CreateDate"].ValidationState != ModelValidationState.Invalid
        //     || ModelState["NewSurname"].ValidationState != ModelValidationState.Invalid)
        //    {
        //        var emp = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.Id == commandForEmp.EmplooyeeId).FirstOrDefault();
        //        if (emp == null) return NotFound();
        //        AppUser findEmpAppUser = await _userManager.FindByEmailAsync(emp.Email);
        //        var allCommandsHis = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault();
        //        var checkCommand = _context.CommandsToEmployees.Where(w => w.Id == id).FirstOrDefault();
        //        if (checkCommand == null) NotFound();

        //        if (commandsSurname.PhotoUpd != null)
        //        {
        //            if (!commandsSurname.PhotoUpd.IsPdf())
        //            {
        //                ModelState.AddModelError("PhotoUpd", "Zəhmət olmasa pdf faylını düzgün seçin");
        //                return View(surnameChangeVM);
        //            }

        //            if (!commandsSurname.PhotoUpd.PdfSize(2))
        //            {
        //                ModelState.AddModelError("PhotoUpd", "Pdf faylının ölçüsü 2Mb-dan artıq ola bilməz");
        //                return View(surnameChangeVM);
        //            }

        //            string filenameScanPdf = await commandsSurname.PhotoUpd.CopyPdf(_env.WebRootPath, "userOtherDocs/pfdAllCommands");
        //            Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, allCommandsHis.Pdf);
        //            allCommandsHis.Pdf = filenameScanPdf;
        //        }
        //        checkCommand.CreatedDate = commandsSurname.CreateDate;
        //        emp.Lastname = commandsSurname.NewSurname;
        //        findEmpAppUser.Surname = commandsSurname.NewSurname;
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Create));
        //    }
        //    return View(surnameChangeVM);
        //}

    }
}
