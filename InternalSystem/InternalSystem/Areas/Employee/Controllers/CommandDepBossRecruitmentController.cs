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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss")]
    public class CommandDepBossRecruitmentController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public CommandDepBossRecruitmentController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, InternalSysDBContext context)
        {
            _userManager = userManager;
            _context = context;
            _roleManager = roleManager;
        }
        public IActionResult GetScanPdf(int? empId)
        {
            if (empId == null) return NotFound();

            CommandEmployeeVM scanVM = new CommandEmployeeVM()
            {
                Emplooyee = _context.Emplooyeees.Where(w => w.Status != false && w.IsCandidate == false && w.Id == empId).FirstOrDefault(),
            };
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetScanPdfToEmployee.cshtml", scanVM);
        }
        public async Task<IActionResult> CreateDepBossRecruitmentCommand()
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false && w.MenegerId==null&&
                                                                                         w.CompanyId == findUser.CompaniesId).ToList();

            CommandDepBossVM depBossVM = new CommandDepBossVM()
            {
                Emplooyees=_context.Emplooyeees.Where(w => w.Status != false && w.IsWorking == false && w.CompanyId == findUser.CompaniesId && w.IsCandidate == false).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c =>c.Emplooyee.PositionsId==null&& c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false && c.Emplooyee.IsCandidate == false &&
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
        public async Task<IActionResult> CreateDepBossRecruitmentCommand(CommandDepBossVM vM,int? WorkPlace)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
                                                                                       w.CompanyId == findUser.CompaniesId).ToList();

            CommandDepBossVM depBossVM = new CommandDepBossVM()
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
                departmentToCompany.MenegerId = vM.EmployeeId;
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
                await _userManager.AddToRoleAsync(newDep, Utility.Roles.DepartmentBoss.ToString());
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
                return RedirectToAction(nameof(CreateDepBossRecruitmentCommand));
            }
                return View(depBossVM);
        }
        public async Task<IActionResult> UpdateDepBossRecruitmentCommand(int? id)
        {
            if (id == null) NotFound();
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
                                                                                         w.CompanyId == findUser.CompaniesId).ToList();
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                   w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            var taxBreakEmp = _context.TaxBreakToEmplooyees.Where(t => t.Emplooyee.Status != false && t.Emplooyee.IsWorking != false &&
                                                                  t.EmplooyeeId == commandForEmp.EmplooyeeId).FirstOrDefault();
            var dept = _context.DepartmentToCompanies.Where(e => e.Company.status != false && e.Department.Status != false && e.MenegerId == commandForEmp.EmplooyeeId).FirstOrDefault();
            CommandDepBossVM depBossVM = new CommandDepBossVM()
            {
                CommandsToEmployee= commandForEmp,
                WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
                TaxBreaks = _context.TaxBreaks.ToList(),
                DepartmentToCompanies = departments,
                TaxBreakToEmplooyee = taxBreakEmp,
                DepartmentToCompany=dept
            };
            if (depBossVM == null) NotFound();
            return View(depBossVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateDepBossRecruitmentCommand(CommandDepBossVM DepBosvM,int? id,int? EmpId)
        {
            if (id == null) NotFound();
            if (EmpId == null) NotFound();
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
                                                                                         w.CompanyId == findUser.CompaniesId).ToList();
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                   w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            var taxBreakEmp = _context.TaxBreakToEmplooyees.Where(t => t.Emplooyee.Status != false && t.Emplooyee.IsWorking != false &&
                                                                  t.EmplooyeeId == commandForEmp.EmplooyeeId).FirstOrDefault();
            CommandDepBossVM depBossVM = new CommandDepBossVM()
            {
                CommandsToEmployee = commandForEmp,
                WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
                TaxBreaks = _context.TaxBreaks.ToList(),
                DepartmentToCompanies = departments,
                TaxBreakToEmplooyee = taxBreakEmp,
            };
            if (ModelState["CreatedDate"].ValidationState != ModelValidationState.Invalid &&
               ModelState["WorkTimeOfTypeId"].ValidationState != ModelValidationState.Invalid &&
               ModelState["Salary"].ValidationState != ModelValidationState.Invalid &&
               ModelState["DepartmentId"].ValidationState != ModelValidationState.Invalid)
            {
                var deptToComp = _context.DepartmentToCompanies.Where(d => d.MenegerId == EmpId).FirstOrDefault();
                DepartmentToCompany departmentTos = _context.DepartmentToCompanies.Where(d => d.Department.Status != false && d.Company.status != false &&
                                                    d.CompanyId == findUser.CompaniesId && d.DepartmentId == DepBosvM.DepartmentId).FirstOrDefault();
                var checkCommand = _context.CommandsToEmployees.Where(w => w.Id == id).FirstOrDefault();
                if (checkCommand == null) NotFound();
                checkCommand.Emplooyee.WorkTimeOfTypeId = DepBosvM.WorkTimeOfTypeId;
                var baseeId = _context.WorkPlaceAdditions.Where(w => w.Name == "Əsas iş yeri").FirstOrDefault().Id;
                var addId = _context.WorkPlaceAdditions.Where(w => w.Name == "Əlavə iş yeri").FirstOrDefault().Id;
                if (DepBosvM.WorkPlace == 1)
                {
                    checkCommand.Emplooyee.WorkPlaceAdditionId = baseeId;
                }
                else if (DepBosvM.WorkPlace == 2)
                {
                    checkCommand.Emplooyee.WorkPlaceAdditionId = addId;
                }

                if (DepBosvM.TaxBreakId != null)
                {
                    if (taxBreakEmp != null)
                    {
                        taxBreakEmp.TaxBreakId = DepBosvM.TaxBreakId;
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        TaxBreakToEmplooyee newTaxBreakToEmplooyee = new TaxBreakToEmplooyee();
                        newTaxBreakToEmplooyee.TaxBreakId = DepBosvM.TaxBreakId;
                        newTaxBreakToEmplooyee.EmplooyeeId = checkCommand.EmplooyeeId;
                        await _context.TaxBreakToEmplooyees.AddAsync(newTaxBreakToEmplooyee);
                        await _context.SaveChangesAsync();
                    }
                }
                else
                {
                    if (taxBreakEmp != null)
                    {
                        _context.TaxBreakToEmplooyees.Remove(taxBreakEmp);
                        await _context.SaveChangesAsync();
                    }
                }

                if (DepBosvM.WorkBookAddition.WorkbookNumber != null || DepBosvM.WorkBookAddition.ContractNumber != null || DepBosvM.WorkBookAddition.SSNNumber != null)
                {
                    if (checkCommand.Emplooyee.WorkBookAdditionId != null)
                    {
                        if (DepBosvM.WorkBookAddition.WorkbookNumber != null)
                        {
                            checkCommand.Emplooyee.WorkBookAddition.WorkbookNumber = DepBosvM.WorkBookAddition.WorkbookNumber.Trim();
                        }
                        else
                        {
                            checkCommand.Emplooyee.WorkBookAddition.WorkbookNumber = null;
                        }
                        if (DepBosvM.WorkBookAddition.ContractNumber != null)
                        {
                            checkCommand.Emplooyee.WorkBookAddition.ContractNumber = DepBosvM.WorkBookAddition.ContractNumber.Trim();
                        }
                        else
                        {
                            checkCommand.Emplooyee.WorkBookAddition.ContractNumber = null;
                        }
                        if (DepBosvM.WorkBookAddition.SSNNumber != null)
                        {
                            checkCommand.Emplooyee.WorkBookAddition.SSNNumber = DepBosvM.WorkBookAddition.SSNNumber.Trim();
                        }
                        else
                        {
                            checkCommand.Emplooyee.WorkBookAddition.SSNNumber = null;
                        }
                        //checkCommand.Emplooyee.WorkBookAddition.WorkbookNumber = employeeVM.WorkBookAddition.WorkbookNumber.Trim();
                        //checkCommand.Emplooyee.WorkBookAddition.ContractNumber = employeeVM.WorkBookAddition.ContractNumber.Trim();
                        //checkCommand.Emplooyee.WorkBookAddition.SSNNumber = employeeVM.WorkBookAddition.SSNNumber.Trim();
                    }
                    else
                    {
                        WorkBookAddition newWorkBookAddition = new WorkBookAddition();
                        if (DepBosvM.WorkBookAddition.WorkbookNumber != null)
                        {
                            newWorkBookAddition.WorkbookNumber = DepBosvM.WorkBookAddition.WorkbookNumber.Trim();
                        }
                        if (DepBosvM.WorkBookAddition.ContractNumber != null)
                        {
                            newWorkBookAddition.ContractNumber = DepBosvM.WorkBookAddition.ContractNumber.Trim();
                        }
                        if (DepBosvM.WorkBookAddition.SSNNumber != null)
                        {
                            newWorkBookAddition.SSNNumber = DepBosvM.WorkBookAddition.SSNNumber.Trim();
                        }
                        await _context.WorkBookAdditions.AddAsync(newWorkBookAddition);
                        await _context.SaveChangesAsync();
                        checkCommand.Emplooyee.WorkBookAdditionId = newWorkBookAddition.Id;
                    }
                }
                else
                {
                    if (checkCommand.Emplooyee.WorkBookAdditionId != null)
                    {
                        checkCommand.Emplooyee.WorkBookAddition.WorkbookNumber = null;
                        checkCommand.Emplooyee.WorkBookAddition.ContractNumber = null;
                        checkCommand.Emplooyee.WorkBookAddition.SSNNumber = null;
                    }
                }
                deptToComp.MenegerId = null;
                departmentTos.MenegerId = EmpId;
                checkCommand.Emplooyee.Salary = DepBosvM.Salary;
                checkCommand.CreatedDate = DepBosvM.CreatedDate;
                checkCommand.TimeOfExecution = DateTime.Now;
                _context.Entry(checkCommand).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                //TempData["msgDepB"] = "Added";
                return RedirectToAction(nameof(CreateDepBossRecruitmentCommand));

            }
                return View(depBossVM);
        }

        public async Task<IActionResult> DetailDepBossRecruitmentCommand(int? id)
        {
            if (id == null) return NotFound();
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandsToEmployee commands = await _context.CommandsToEmployees.FindAsync(id);
            DepartmentToCompany departmentBoss = _context.DepartmentToCompanies.Where(d => d.Department.Status != false && d.Company.status != false && d.Meneger.Status != false &&
                                                                                      d.MenegerId == commands.EmplooyeeId).FirstOrDefault();
            CommandDepBossVM depBossVM = new CommandDepBossVM()
            {
                CommandsToEmployee = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false &&
                                                                        c.Emplooyee.CompanyId == findUser.CompaniesId && c.Id == id).FirstOrDefault(),
                TaxBreakToEmplooyee = _context.TaxBreakToEmplooyees.Where(t => t.Emplooyee.Status != false && t.Emplooyee.IsWorking != false && t.Emplooyee.CompanyId == findUser.CompaniesId &&
                                                                          t.EmplooyeeId == commands.EmplooyeeId).FirstOrDefault(),
                DepartmentToCompany=departmentBoss
            };
            if (depBossVM == null) return NotFound();
            return View(depBossVM);
        }
    }
}
