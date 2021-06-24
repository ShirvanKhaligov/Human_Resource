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
    public class NotificationController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public NotificationController(InternalSysDBContext context, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }
        public async Task<IActionResult> Create()
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandSurnameChangeVM notificationVM = new CommandSurnameChangeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.CompanyId == findUser.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Command.Name == "Xəbərdarlıq(Bildiriş)").ToList()
            };
            return View(notificationVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CommandSurnameChangeVM commandsNotification)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandSurnameChangeVM notificationVM = new CommandSurnameChangeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.CompanyId == findUser.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Command.Name == "Xəbərdarlıq(Bildiriş)").ToList()
            };
            if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid ||
               ModelState["Photo"].ValidationState != ModelValidationState.Invalid ||
               ModelState["CreateDate"].ValidationState != ModelValidationState.Invalid)
            {
                var findEmp = _context.Emplooyeees.Where(e => e.Id == commandsNotification.EmplooyeeId).FirstOrDefault();
                if (findEmp == null) return NotFound();
                var findCommand = _context.Commands.Where(c => c.Status != false && c.Name == "Xəbərdarlıq(Bildiriş)").FirstOrDefault();
                if (findCommand == null) return NotFound();

                if (commandsNotification.Photo != null)
                {
                    if (!commandsNotification.Photo.IsPdf())
                    {
                        ModelState.AddModelError("Photo", "Zəhmət olmasa pdf faylını düzgün seçin");
                        return View(notificationVM);
                    }

                    if (!commandsNotification.Photo.PdfSize(2))
                    {
                        ModelState.AddModelError("Photo", "Pdf faylının ölçüsü 2Mb-dan artıq ola bilməz");
                        return View(notificationVM);
                    }
                }

                CommandsToEmployee notificationToEmployee = new CommandsToEmployee();
                notificationToEmployee.CommandId = findCommand.Id;
                notificationToEmployee.EmplooyeeId = commandsNotification.EmplooyeeId;
                notificationToEmployee.CreatedDate = commandsNotification.CreateDate;
                notificationToEmployee.TimeOfExecution = DateTime.Now;
                await _context.CommandsToEmployees.AddAsync(notificationToEmployee);
                await _context.SaveChangesAsync();

                string filenameScanPhoto = await commandsNotification.Photo.CopyPdf(_env.WebRootPath, "userOtherDocs/pfdAllCommands");

                //Add Old Salary Table
                AllCommandsHistory notificationPdf = new AllCommandsHistory()
                {
                    EmplooyeeId = commandsNotification.EmplooyeeId,
                    CommandsToEmployeeId = notificationToEmployee.Id,
                    Pdf = filenameScanPhoto
                };

                await _context.AllCommandsHistories.AddAsync(notificationPdf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(notificationVM);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                 w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandSurnameChangeVM notificationVM = new CommandSurnameChangeVM()
            {
                CommandsToEmployee = commandForEmp,
                AllCommandsHistory = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault(),
            };
            return View(notificationVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CommandSurnameChangeVM commandsNotification, int? id)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandSurnameChangeVM notificationVM = new CommandSurnameChangeVM()
            {
                CommandsToEmployee = commandForEmp,
                AllCommandsHistory = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault(),
            };
            if (ModelState["CreateDate"].ValidationState != ModelValidationState.Invalid)
            {
                var allCommandsHis = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault();
                var checkCommand = _context.CommandsToEmployees.Where(w => w.Id == id).FirstOrDefault();
                if (checkCommand == null) NotFound();

                if (commandsNotification.PhotoUpd != null)
                {
                    if (!commandsNotification.PhotoUpd.IsPdf())
                    {
                        ModelState.AddModelError("PhotoUpd", "Zəhmət olmasa pdf faylını düzgün seçin");
                        return View(notificationVM);
                    }

                    if (!commandsNotification.PhotoUpd.PdfSize(2))
                    {
                        ModelState.AddModelError("PhotoUpd", "Pdf faylının ölçüsü 2Mb-dan artıq ola bilməz");
                        return View(notificationVM);
                    }

                    string filenameScanPdf = await commandsNotification.PhotoUpd.CopyPdf(_env.WebRootPath, "userOtherDocs/pfdAllCommands");
                    Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, allCommandsHis.Pdf);
                    allCommandsHis.Pdf = filenameScanPdf;
                }
                checkCommand.CreatedDate = commandsNotification.CreateDate;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(notificationVM);
        }
    }
}
