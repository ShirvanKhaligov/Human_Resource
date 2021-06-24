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
    public class ReprimandController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public ReprimandController(InternalSysDBContext context, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }
        public async Task<IActionResult> Create()
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandSurnameChangeVM reprimandVM = new CommandSurnameChangeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.CompanyId == findUser.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Command.Name == "Töhmət(Əmək intizamının pozulması)").ToList()
            };
            return View(reprimandVM);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CommandSurnameChangeVM commandsReprimand)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandSurnameChangeVM reprimandVM = new CommandSurnameChangeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.CompanyId == findUser.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Command.Name == "Töhmət(Əmək intizamının pozulması)").ToList()
            };
            if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid ||
               ModelState["Photo"].ValidationState != ModelValidationState.Invalid ||
               ModelState["CreateDate"].ValidationState != ModelValidationState.Invalid)
            {
                var findEmp = _context.Emplooyeees.Where(e => e.Id == commandsReprimand.EmplooyeeId).FirstOrDefault();
                if (findEmp == null) return NotFound();
                var findCommand = _context.Commands.Where(c => c.Status != false && c.Name == "Töhmət(Əmək intizamının pozulması)").FirstOrDefault();
                if (findCommand == null) return NotFound();

                if (commandsReprimand.Photo != null)
                {
                    if (!commandsReprimand.Photo.IsPdf())
                    {
                        ModelState.AddModelError("Photo", "Zəhmət olmasa pdf faylını düzgün seçin");
                        return View(reprimandVM);
                    }

                    if (!commandsReprimand.Photo.PdfSize(2))
                    {
                        ModelState.AddModelError("Photo", "Pdf faylının ölçüsü 2Mb-dan artıq ola bilməz");
                        return View(reprimandVM);
                    }
                }

                CommandsToEmployee notificationToEmployee = new CommandsToEmployee();
                notificationToEmployee.CommandId = findCommand.Id;
                notificationToEmployee.EmplooyeeId = commandsReprimand.EmplooyeeId;
                notificationToEmployee.CreatedDate = commandsReprimand.CreateDate;
                notificationToEmployee.TimeOfExecution = DateTime.Now;
                await _context.CommandsToEmployees.AddAsync(notificationToEmployee);
                await _context.SaveChangesAsync();

                string filenameScanPhoto = await commandsReprimand.Photo.CopyPdf(_env.WebRootPath, "userOtherDocs/pfdAllCommands");

                //Add Old Salary Table
                AllCommandsHistory reprimandPdf = new AllCommandsHistory()
                {
                    EmplooyeeId = commandsReprimand.EmplooyeeId,
                    CommandsToEmployeeId = notificationToEmployee.Id,
                    Pdf = filenameScanPhoto
                };

                await _context.AllCommandsHistories.AddAsync(reprimandPdf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(reprimandVM);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                 w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandSurnameChangeVM reprimandVM = new CommandSurnameChangeVM()
            {
                CommandsToEmployee = commandForEmp,
                AllCommandsHistory = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault(),
            };
            return View(reprimandVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CommandSurnameChangeVM commandsReprimand, int? id)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandSurnameChangeVM reprimandVM = new CommandSurnameChangeVM()
            {
                CommandsToEmployee = commandForEmp,
                AllCommandsHistory = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault(),
            };
            if (ModelState["CreateDate"].ValidationState != ModelValidationState.Invalid)
            {
                var allCommandsHis = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault();
                var checkCommand = _context.CommandsToEmployees.Where(w => w.Id == id).FirstOrDefault();
                if (checkCommand == null) NotFound();

                if (commandsReprimand.PhotoUpd != null)
                {
                    if (!commandsReprimand.PhotoUpd.IsPdf())
                    {
                        ModelState.AddModelError("PhotoUpd", "Zəhmət olmasa pdf faylını düzgün seçin");
                        return View(reprimandVM);
                    }

                    if (!commandsReprimand.PhotoUpd.PdfSize(2))
                    {
                        ModelState.AddModelError("PhotoUpd", "Pdf faylının ölçüsü 2Mb-dan artıq ola bilməz");
                        return View(reprimandVM);
                    }

                    string filenameScanPdf = await commandsReprimand.PhotoUpd.CopyPdf(_env.WebRootPath, "userOtherDocs/pfdAllCommands");
                    Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, allCommandsHis.Pdf);
                    allCommandsHis.Pdf = filenameScanPdf;
                }
                checkCommand.CreatedDate = commandsReprimand.CreateDate;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(reprimandVM);
        }
    }
}
