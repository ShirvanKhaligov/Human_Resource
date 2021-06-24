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
    public class SurnameChangeController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public SurnameChangeController(InternalSysDBContext context, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }
        public async Task<IActionResult> Create()
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandSurnameChangeVM surnameChangeVM = new CommandSurnameChangeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.Gender.Name == "Qadın" && e.CompanyId == findUser.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Command.Name == "Soyad dəy.").ToList()
            };
            return View(surnameChangeVM);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CommandSurnameChangeVM commandsSurname)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandSurnameChangeVM surnameChangeVM = new CommandSurnameChangeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.Gender.Name == "Qadın" && e.CompanyId == findUser.CompaniesId).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Command.Name == "Soyad dəy.").ToList()
            };

            if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid ||
               ModelState["Photo"].ValidationState != ModelValidationState.Invalid ||
               ModelState["CreateDate"].ValidationState != ModelValidationState.Invalid ||
               ModelState["NewSurname"].ValidationState != ModelValidationState.Invalid)
            {
                var findEmp = _context.Emplooyeees.Where(e => e.Id == commandsSurname.EmplooyeeId).FirstOrDefault();
                AppUser findEmpAppUser = await _userManager.FindByEmailAsync(findEmp.Email);
                if (findEmp == null) return NotFound();
                var findCommand = _context.Commands.Where(c => c.Status != false && c.Name == "Soyad dəy.").FirstOrDefault();
                if (findCommand == null) return NotFound();

                if (commandsSurname.Photo != null)
                {
                    if (!commandsSurname.Photo.IsPdf())
                    {
                        ModelState.AddModelError("Photo", "Zəhmət olmasa pdf faylını düzgün seçin");
                        return View(surnameChangeVM);
                    }

                    if (!commandsSurname.Photo.PdfSize(2))
                    {
                        ModelState.AddModelError("Photo", "Pdf faylının ölçüsü 2Mb-dan artıq ola bilməz");
                        return View(surnameChangeVM);
                    }
                }

                CommandsToEmployee surnameChangeToEmployee = new CommandsToEmployee();
                surnameChangeToEmployee.CommandId = findCommand.Id;
                surnameChangeToEmployee.EmplooyeeId = commandsSurname.EmplooyeeId;
                surnameChangeToEmployee.CreatedDate = commandsSurname.CreateDate;
                surnameChangeToEmployee.TimeOfExecution = DateTime.Now;
                await _context.CommandsToEmployees.AddAsync(surnameChangeToEmployee);
                await _context.SaveChangesAsync();

                string filenameScanPhoto = await commandsSurname.Photo.CopyPdf(_env.WebRootPath, "userOtherDocs/pfdAllCommands");

                //Add Old Salary Table
                AllCommandsHistory oldSurname = new AllCommandsHistory()
                {
                    EmplooyeeId = commandsSurname.EmplooyeeId,
                    CommandsToEmployeeId = surnameChangeToEmployee.Id,
                    Pdf = filenameScanPhoto,
                    OldSurname = findEmp.Lastname
                };
                await _context.AllCommandsHistories.AddAsync(oldSurname);
                findEmp.Lastname = commandsSurname.NewSurname;
                findEmpAppUser.Surname = commandsSurname.NewSurname;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(surnameChangeVM);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                 w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandSurnameChangeVM surnameChangeVM = new CommandSurnameChangeVM()
            {
                CommandsToEmployee = commandForEmp,
                AllCommandsHistory = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault(),
            };
            return View(surnameChangeVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CommandSurnameChangeVM commandsSurname, int? id)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandSurnameChangeVM surnameChangeVM = new CommandSurnameChangeVM()
            {
                CommandsToEmployee = commandForEmp,
                AllCommandsHistory = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault(),
            };
            if (ModelState["CreateDate"].ValidationState != ModelValidationState.Invalid
             || ModelState["NewSurname"].ValidationState != ModelValidationState.Invalid)
            {
                var emp = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.Id == commandForEmp.EmplooyeeId).FirstOrDefault();
                if (emp == null) return NotFound();
                AppUser findEmpAppUser = await _userManager.FindByEmailAsync(emp.Email);
                var allCommandsHis = _context.AllCommandsHistories.Where(a => a.CommandsToEmployeeId == id).FirstOrDefault();
                var checkCommand = _context.CommandsToEmployees.Where(w => w.Id == id).FirstOrDefault();
                if (checkCommand == null) NotFound();

                if (commandsSurname.PhotoUpd != null)
                {
                    if (!commandsSurname.PhotoUpd.IsPdf())
                    {
                        ModelState.AddModelError("PhotoUpd", "Zəhmət olmasa pdf faylını düzgün seçin");
                        return View(surnameChangeVM);
                    }

                    if (!commandsSurname.PhotoUpd.PdfSize(2))
                    {
                        ModelState.AddModelError("PhotoUpd", "Pdf faylının ölçüsü 2Mb-dan artıq ola bilməz");
                        return View(surnameChangeVM);
                    }

                    string filenameScanPdf = await commandsSurname.PhotoUpd.CopyPdf(_env.WebRootPath, "userOtherDocs/pfdAllCommands");
                    Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, allCommandsHis.Pdf);
                    allCommandsHis.Pdf = filenameScanPdf;
                }
                checkCommand.CreatedDate = commandsSurname.CreateDate;
                emp.Lastname = commandsSurname.NewSurname;
                findEmpAppUser.Surname = commandsSurname.NewSurname;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(surnameChangeVM);
        }
    }
}
