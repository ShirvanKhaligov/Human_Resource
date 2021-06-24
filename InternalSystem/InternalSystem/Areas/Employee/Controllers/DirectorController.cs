using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.Models.Departments;
using InternalSystem.Utilities;
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
    public class DirectorController : Controller
    {

        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public DirectorController(InternalSysDBContext context,
                                 UserManager<AppUser> userManager,
                                 IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }


        public IActionResult GetScanPdf(int? empId)
        {
            if (empId == null) return NotFound();

            CommandDirector scanVM = new CommandDirector()
            {
                Emplooyee = _context.Emplooyeees.Where(w => w.Status != false && w.IsCandidate == false && w.Id == empId).FirstOrDefault(),
            };
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetScanPdfToEmployee.cshtml", scanVM);
        }



        public async Task<IActionResult> CreateDirector()
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false && w.MenegerId == null &&
                                                                                         w.CompanyId == findUser.CompaniesId).ToList();

            CommandDirector depBossVM = new CommandDirector()
            {
                Emplooyees = _context.Emplooyeees.Where(w => w.Status != false && w.IsWorking == false && w.CompanyId == findUser.CompaniesId && w.IsCandidate == false).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Emplooyee.PositionsId == null && c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false && c.Emplooyee.IsCandidate == false &&
                                                                             c.Emplooyee.CompanyId == findUser.CompaniesId && c.Command.Status != false && c.Command.Name == "İşə qəbul").ToList(),
                WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
                TaxBreaks = _context.TaxBreaks.ToList(),
                DepartmentToCompanies = departments,
            };
            if (depBossVM == null) return NotFound();
            return View(depBossVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDirector(CommandDirector vM, int? WorkPlace)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
                                                                                       w.CompanyId == findUser.CompaniesId).ToList();

            CommandDirector depBossVM = new CommandDirector()
            {
                Emplooyees = _context.Emplooyeees.Where(w => w.Status != false && w.IsWorking == false && w.CompanyId == findUser.CompaniesId && w.IsCandidate == false).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.EmplooyeeId == c.Emplooyee.Positions.SubDepartment.DepartmentToCompany.MenegerId && c.Emplooyee.Status != false &&
                                                                              c.Emplooyee.IsWorking != false && c.Emplooyee.IsCandidate == false &&
                                                                              c.Emplooyee.CompanyId == findUser.CompaniesId && c.Command.Status != false && c.Command.Name == "İşə qəbul").ToList(),
                WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
                TaxBreaks = _context.TaxBreaks.ToList(),
                DepartmentToCompanies = departments,
            };
            if (ModelState["EmployeeId"].ValidationState != ModelValidationState.Invalid
               && ModelState["WorkTimeOfTypeId"].ValidationState != ModelValidationState.Invalid
               && ModelState["CreatedDate"].ValidationState != ModelValidationState.Invalid
               && ModelState["DepartmentId"].ValidationState != ModelValidationState.Invalid
               && ModelState["Salary"].ValidationState != ModelValidationState.Invalid)
            {
                Emplooyee findEmp = _context.Emplooyeees.Where(w => w.Id == vM.EmployeeId && w.Status != false).FirstOrDefault();
                if (findEmp == null) NotFound();
                Commands findCommand = _context.Commands.Where(w => w.Status != false && w.Name == "İşə qəbul").FirstOrDefault();
                DepartmentToCompany departmentToCompany = _context.DepartmentToCompanies.Where(d => d.DepartmentId == vM.DepartmentId).FirstOrDefault();
                // departmentToCompany.MenegerId = vM.EmployeeId;
                AppUser findCurrentUser = await _userManager.FindByEmailAsync(User.Identity.Name);
                AppUser newDep = new AppUser()
                {
                    Name = findEmp.FirstName,
                    Surname = findEmp.Lastname,
                    FatherName = findEmp.FatherName,
                    UserName = findEmp.Email,
                    Email = findEmp.Email,
                    Status = true,
                    CompaniesId = findCurrentUser.CompaniesId,
                    EmplooyeeId = findEmp.Id,
                };
                //check workPlace,
                if (WorkPlace == null || WorkPlace == 0)
                {
                    ViewData["error_WorkPlace"] = "Zəhmət olmasa iş növünü seçin";
                    return View(depBossVM);
                }
                //if (createdDate.Year < 2010)
                //{
                //    ViewData["error_createDateDepBoss"] = "Zəhmət olmasa qəbul vaxtını seçin";
                //    return View(depBossVM);
                //}
                IdentityResult identityResult = await _userManager.CreateAsync(newDep, "rR@23.");
                if (!identityResult.Succeeded)
                {
                    foreach (var error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(depBossVM);
                }
                await _userManager.AddToRoleAsync(newDep, Utility.Roles.Director.ToString());
                await _userManager.AddToRoleAsync(newDep, Utility.Roles.Member.ToString());
                findEmp.IsWorking = true;

                findEmp.WorkTimeOfTypeId = vM.WorkTimeOfTypeId;
                var baseeId = _context.WorkPlaceAdditions.Where(w => w.Name == "Əsas iş yeri").FirstOrDefault().Id;
                var addId = _context.WorkPlaceAdditions.Where(w => w.Name == "Əlavə iş yeri").FirstOrDefault().Id;
                if (WorkPlace == 1)
                {
                    findEmp.WorkPlaceAdditionId = baseeId;
                }
                else if (WorkPlace == 2)
                {
                    findEmp.WorkPlaceAdditionId = addId;
                }
                if (vM.TaxBreakId != null)
                {
                    TaxBreakToEmplooyee newTaxBreakToEmplooyee = new TaxBreakToEmplooyee();
                    newTaxBreakToEmplooyee.TaxBreakId = vM.TaxBreakId;
                    newTaxBreakToEmplooyee.EmplooyeeId = vM.EmployeeId;
                    await _context.TaxBreakToEmplooyees.AddAsync(newTaxBreakToEmplooyee);
                    await _context.SaveChangesAsync();
                }
                if (vM.WorkBookAddition.WorkbookNumber != null || vM.WorkBookAddition.ContractNumber != null || vM.WorkBookAddition.SSNNumber != null)
                {
                    WorkBookAddition newWorkBookAddition = new WorkBookAddition();
                    if (vM.WorkBookAddition.WorkbookNumber != null)
                    {
                        newWorkBookAddition.WorkbookNumber = vM.WorkBookAddition.WorkbookNumber.Trim();
                    }
                    if (vM.WorkBookAddition.ContractNumber != null)
                    {
                        newWorkBookAddition.ContractNumber = vM.WorkBookAddition.ContractNumber.Trim();
                    }
                    if (vM.WorkBookAddition.SSNNumber != null)
                    {
                        newWorkBookAddition.SSNNumber = vM.WorkBookAddition.SSNNumber.Trim();
                    }
                    await _context.WorkBookAdditions.AddAsync(newWorkBookAddition);
                    await _context.SaveChangesAsync();
                    findEmp.WorkBookAdditionId = newWorkBookAddition.Id;
                }
                findEmp.Salary = vM.Salary;

                CommandsToEmployee commandsToEmployee = new CommandsToEmployee();
                commandsToEmployee.EmplooyeeId = vM.EmployeeId;//
                commandsToEmployee.CommandId = findCommand.Id;
                //commandsToEmployee1.Description = commandVM.Description;
                commandsToEmployee.CreatedDate = vM.CreatedDate;
                commandsToEmployee.TimeOfExecution = DateTime.Now;
                _context.Entry(findEmp).State = EntityState.Modified;
                await _context.CommandsToEmployees.AddAsync(commandsToEmployee);
                await _context.SaveChangesAsync();
                TempData["msgDepBoss"] = "Added";
                return RedirectToAction(nameof(CreateDirector));                          
            }
            return View(depBossVM);
        }

        public async Task<IActionResult> DetailDirector(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AppUser FindUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandsToEmployee command = await _context.CommandsToEmployees.FindAsync(id);
            DepartmentToCompany departmentBoss =  _context.DepartmentToCompanies.Where(d =>
              d.Company.status != false).FirstOrDefault();
          
           
            CommandDirector depBossVM = new CommandDirector()
            {
                CommandsToEmployee = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false &&
                                                                        c.Emplooyee.CompanyId == FindUser.CompaniesId && c.Id == id).FirstOrDefault(),
                TaxBreakToEmplooyee = _context.TaxBreakToEmplooyees.Where(t => t.Emplooyee.Status != false && t.Emplooyee.IsWorking != false && t.Emplooyee.CompanyId == FindUser.CompaniesId &&
                                                                          t.EmplooyeeId == command.EmplooyeeId).FirstOrDefault(),
                DepartmentToCompany = departmentBoss
            };
            if (depBossVM == null) return NotFound();
            return View(depBossVM);


        }

    }
}
