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
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.Controllers
{

    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss")]
    public class WrittenWarningController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public WrittenWarningController(InternalSysDBContext context, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }
        public async Task<IActionResult> Create()
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandSurnameChangeVM commandWarning = new CommandSurnameChangeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.CompanyId == findUser.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Command.Name == "Yazılı xəbərdarlıq").ToList()
            };
            return View(commandWarning);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CommandSurnameChangeVM commandsWarning)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandSurnameChangeVM commandWarningVM = new CommandSurnameChangeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.CompanyId == findUser.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Command.Name == "Yazılı xəbərdarlıq").ToList()
            };
            if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid ||
              ModelState["Photo"].ValidationState != ModelValidationState.Invalid ||
              ModelState["CreateDate"].ValidationState != ModelValidationState.Invalid)
            {
                var findEmp = _context.Emplooyeees.Where(e => e.Id == commandsWarning.EmplooyeeId).FirstOrDefault();
                if (findEmp == null) return NotFound();
                var findCommand = _context.Commands.Where(c => c.Status != false && c.Name == "Yazılı xəbərdarlıq").FirstOrDefault();
                if (findCommand == null) return NotFound();

                if (commandsWarning.Photo != null)
                {
                    if (!commandsWarning.Photo.IsPdf())
                    {
                        ModelState.AddModelError("Photo", "Zəhmət olmasa pdf faylını düzgün seçin");
                        return View(commandWarningVM);
                    }

                    if (!commandsWarning.Photo.PdfSize(2))
                    {
                        ModelState.AddModelError("Photo", "Pdf faylının ölçüsü 2Mb-dan artıq ola bilməz");
                        return View(commandWarningVM);
                    }
                }

                CommandsToEmployee WarningToEmployee = new CommandsToEmployee();
                WarningToEmployee.CommandId = findCommand.Id;
                WarningToEmployee.EmplooyeeId = commandsWarning.EmplooyeeId;
                WarningToEmployee.CreatedDate = commandsWarning.CreateDate;
                WarningToEmployee.TimeOfExecution = DateTime.Now;
                await _context.CommandsToEmployees.AddAsync(WarningToEmployee);
                await _context.SaveChangesAsync();

                string filenameScanPhoto = await commandsWarning.Photo.CopyPdf(_env.WebRootPath, "userOtherDocs/pfdAllCommands");

                //Add Old Salary Table
                AllCommandsHistory warning = new AllCommandsHistory()
                {
                    EmplooyeeId = commandsWarning.EmplooyeeId,
                    CommandsToEmployeeId = WarningToEmployee.Id,
                    Pdf = filenameScanPhoto
                };
                await _context.AllCommandsHistories.AddAsync(warning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(commandWarningVM);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                 w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandSurnameChangeVM commandWarningVM = new CommandSurnameChangeVM()
            {
                CommandsToEmployee = commandForEmp,
                AllCommandsHistory = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault(),
            };
            return View(commandWarningVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CommandSurnameChangeVM commandsWarning, int? id)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandSurnameChangeVM commandWarningVM = new CommandSurnameChangeVM()
            {
                CommandsToEmployee = commandForEmp,
                AllCommandsHistory = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault(),
            };
            if (ModelState["CreateDate"].ValidationState != ModelValidationState.Invalid)
            {
                var emp = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.Id == commandForEmp.EmplooyeeId).FirstOrDefault();
                if (emp == null) return NotFound();
                var allCommandsHis = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault();
                var checkCommand = _context.CommandsToEmployees.Where(w => w.Id == id).FirstOrDefault();
                if (checkCommand == null) NotFound();

                if (commandsWarning.PhotoUpd != null)
                {
                    if (!commandsWarning.PhotoUpd.IsPdf())
                    {
                        ModelState.AddModelError("PhotoUpd", "Zəhmət olmasa pdf faylını düzgün seçin");
                        return View(commandWarningVM);
                    }

                    if (!commandsWarning.PhotoUpd.PdfSize(2))
                    {
                        ModelState.AddModelError("PhotoUpd", "Pdf faylının ölçüsü 2Mb-dan artıq ola bilməz");
                        return View(commandWarningVM);
                    }

                    string filenameScanPdf = await commandsWarning.PhotoUpd.CopyPdf(_env.WebRootPath, "userOtherDocs/pfdAllCommands");
                    Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, allCommandsHis.Pdf);
                    allCommandsHis.Pdf = filenameScanPdf;
                }
                checkCommand.CreatedDate = commandsWarning.CreateDate;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(commandWarningVM);
        }
    }

}
