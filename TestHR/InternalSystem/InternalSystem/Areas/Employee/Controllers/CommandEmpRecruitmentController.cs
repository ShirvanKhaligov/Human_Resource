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
    public class CommandEmpRecruitmentController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public CommandEmpRecruitmentController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, InternalSysDBContext context)
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
        public IActionResult GetSubDepartments(int? id)
        {
            if (id == null) NotFound();
            List<SubDepartment> subDepartments = _context.SubDepartments.Where(w => w.Status != false &&
            w.DepartmentToCompany.DepartmentId == id).ToList();
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_SubDepartmentSelectList.cshtml", subDepartments);
        }
        public IActionResult GetPositions(int? id)
        {
            if (id == null) NotFound();
            List<Position> positions = _context.Positions.Where(w => w.Status != false &&
            w.SubDepartmentId == id).ToList();
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_PositionSelectList.cshtml", positions);
        }

        public async Task<IActionResult> CreateEmpRecruitmentCommand()
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
                List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
                                                                                             w.CompanyId == findUser.CompaniesId).ToList();

            CommandEmployeeVM employeeVM = new CommandEmployeeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(w => w.Status != false && w.IsWorking == false && w.CompanyId == findUser.CompaniesId && w.IsCandidate == false).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false && c.Emplooyee.IsCandidate == false &&
                                                                         c.Emplooyee.PositionsId != null && c.Emplooyee.CompanyId == findUser.CompaniesId && c.Command.Status != false && c.Command.Name == "İşə qəbul").ToList(),
                //Commandss = _context.Commands.Where(w => w.Status != false).ToList(),
                WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
                TaxBreaks = _context.TaxBreaks.ToList(),
                DepartmentToCompanies = departments,
            };
            return View(employeeVM);
        }

        #region Last CreateEmpRecruitmentCommand
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> CreateEmpRecruitmentCommandd(CommandEmployeeVM employeeVM, int? WorkPlace, DateTime createDate)
        //{
        //    //
        //    AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
        //    List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
        //                                                                                 w.CompanyId == findUser.CompaniesId).ToList();
        //    CommandEmployeeVM VM = new CommandEmployeeVM()
        //    {
        //        Emplooyees = _context.Emplooyeees.Where(w => w.Status != false && w.IsWorking == false && w.CompanyId == findUser.CompaniesId && w.IsCandidate == false).ToList(),
        //        CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false && c.Emplooyee.IsCandidate == false &&
        //                                                                c.Emplooyee.CompanyId == findUser.CompaniesId && c.Command.Status != false && c.Command.Name == "İşə qəbul").ToList(),
        //        //Commandss = _context.Commands.Where(w => w.Status != false).ToList(),
        //        WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
        //        TaxBreaks = _context.TaxBreaks.ToList(),
        //        DepartmentToCompanies = departments
        //    };
        //    //
        //    if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid
        //        && ModelState["WorkTimeOfTypeId"].ValidationState != ModelValidationState.Invalid
        //        && ModelState["PositionId"].ValidationState != ModelValidationState.Invalid
        //        && ModelState["Salary"].ValidationState != ModelValidationState.Invalid)
        //    {
        //        Emplooyee findEmp = _context.Emplooyeees.Where(w => w.Id == employeeVM.EmplooyeeId && w.Status != false).FirstOrDefault();
        //        if (findEmp == null) NotFound();
        //        Commands findCommand = _context.Commands.Where(w => w.Status != false && w.Name == "İşə qəbul").FirstOrDefault();
        //        var finddPos = _context.Positions.Where(w => w.Id == employeeVM.PositionId).FirstOrDefault();
        //        if (finddPos.Name == "İnsan Resursları üzrə kiçik mütəxəssis" || finddPos.Name == "İnsan Resursları üzrə mütəxəssis")
        //        {
        //            AppUser checkUser = await _userManager.FindByEmailAsync(findEmp.Email);
        //            if (checkUser != null)
        //            {
        //                //check workPlace,
        //                if (WorkPlace == null || WorkPlace == 0)
        //                {
        //                    ViewData["error_WorkPlace"] = "Zəhmət olmasa iş növünü seçin";
        //                    return View(VM);
        //                }
        //                checkUser.EmplooyeeId = employeeVM.EmplooyeeId;
        //                await _userManager.AddToRoleAsync(checkUser, Utility.Roles.Member.ToString());

        //                AppUser findUserr = await _userManager.FindByEmailAsync(User.Identity.Name);
        //                List<DepartmentToCompany> departmentsHr = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
        //                                                                                             w.CompanyId == findUser.CompaniesId).ToList();
        //                CommandEmployeeVM VMHR = new CommandEmployeeVM()
        //                {
        //                    Emplooyees = _context.Emplooyeees.Where(w => w.Status != false && w.IsWorking == false && w.CompanyId == findUser.CompaniesId && w.IsCandidate == false).ToList(),
        //                    CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false && c.Emplooyee.IsCandidate == false &&
        //                                                                            c.Emplooyee.CompanyId == findUser.CompaniesId && c.Command.Status != false && c.Command.Name == "İşə qəbul").ToList(),
        //                    Commandss = _context.Commands.Where(w => w.Status != false).ToList(),
        //                    WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
        //                    TaxBreaks = _context.TaxBreaks.ToList(),
        //                    DepartmentToCompanies = departmentsHr,
        //                };

        //                findEmp.IsWorking = true;
        //                //add Database
        //                findEmp.WorkTimeOfTypeId = employeeVM.WorkTimeOfTypeId;
        //                var baseeIdd = _context.WorkPlaceAdditions.Where(w => w.Name == "Əsas iş yeri").FirstOrDefault().Id;
        //                var addIdd = _context.WorkPlaceAdditions.Where(w => w.Name == "Əlavə iş yeri").FirstOrDefault().Id;
        //                if (WorkPlace == 1)
        //                {
        //                    findEmp.WorkPlaceAdditionId = baseeIdd;
        //                }
        //                else if (WorkPlace == 2)
        //                {
        //                    findEmp.WorkPlaceAdditionId = addIdd;
        //                }

        //                if (employeeVM.TaxBreakId != null)
        //                {
        //                    TaxBreakToEmplooyee newTaxBreakToEmplooyee = new TaxBreakToEmplooyee();
        //                    newTaxBreakToEmplooyee.TaxBreakId = employeeVM.TaxBreakId;
        //                    newTaxBreakToEmplooyee.EmplooyeeId = employeeVM.EmplooyeeId;
        //                }
        //                if (employeeVM.WorkBookAddition.WorkbookNumber != null || employeeVM.WorkBookAddition.ContractNumber != null || employeeVM.WorkBookAddition.SSNNumber != null)
        //                {
        //                    WorkBookAddition newWorkBookAddition = new WorkBookAddition();
        //                    if (employeeVM.WorkBookAddition.WorkbookNumber != null)
        //                    {
        //                        newWorkBookAddition.WorkbookNumber = employeeVM.WorkBookAddition.WorkbookNumber.Trim();
        //                    }
        //                    if (employeeVM.WorkBookAddition.ContractNumber != null)
        //                    {
        //                        newWorkBookAddition.ContractNumber = employeeVM.WorkBookAddition.ContractNumber.Trim();
        //                    }
        //                    if (employeeVM.WorkBookAddition.SSNNumber != null)
        //                    {
        //                        newWorkBookAddition.SSNNumber = employeeVM.WorkBookAddition.SSNNumber.Trim();
        //                    }
        //                }

        //                findEmp.Salary = employeeVM.Salary;
        //                findEmp.PositionsId = employeeVM.PositionId;
        //                CommandsToEmployee commandsToEmployeeHr = new CommandsToEmployee();
        //                commandsToEmployeeHr.EmplooyeeId = employeeVM.EmplooyeeId;//
        //                commandsToEmployeeHr.CommandId = findCommand.Id;
        //                commandsToEmployeeHr.CreatedDate = createDate;
        //                commandsToEmployeeHr.TimeOfExecution = DateTime.Now;
        //                _context.Entry(findEmp).State = EntityState.Modified;
        //                await _context.CommandsToEmployees.AddAsync(commandsToEmployeeHr);
        //                await _context.SaveChangesAsync();
        //                TempData["msg"] = "Added";
        //                return RedirectToAction(nameof(CreateEmpRecruitmentCommand));//Deyisib umumi siyahiya yonlendirersen
        //            }

        //            AppUser findCurrentUser = await _userManager.FindByEmailAsync(User.Identity.Name);
        //            AppUser newUser = new AppUser()
        //            {
        //                Name = findEmp.FirstName,
        //                Surname = findEmp.Lastname,
        //                FatherName = findEmp.FatherName,
        //                UserName = findEmp.Email,
        //                Email = findEmp.Email,
        //                Status = true,
        //                CompaniesId = findCurrentUser.CompaniesId,
        //                EmplooyeeId = findEmp.Id,
        //            };
        //            IdentityResult identityResult = await _userManager.CreateAsync(newUser, "rR@1.");
        //            if (!identityResult.Succeeded)
        //            {
        //                foreach (var error in identityResult.Errors)
        //                {
        //                    ModelState.AddModelError("", error.Description);
        //                }
        //                return View(VM);
        //            }
        //            await _userManager.AddToRoleAsync(newUser, Utility.Roles.HumanResource.ToString());
        //            await _userManager.AddToRoleAsync(newUser, Utility.Roles.Member.ToString());
        //            findEmp.IsWorking = true;
        //        }
        //        else
        //        {
        //            AppUser checkUser = await _userManager.FindByEmailAsync(findEmp.Email);
        //            if (checkUser != null)
        //            {
        //                checkUser.EmplooyeeId = employeeVM.EmplooyeeId;
        //                await _userManager.AddToRoleAsync(checkUser, Utility.Roles.Member.ToString());
        //                findEmp.IsWorking = true;
        //                AppUser findUserr = await _userManager.FindByEmailAsync(User.Identity.Name);
        //                List<DepartmentToCompany> departmentsS = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
        //                w.CompanyId == findUserr.CompaniesId).ToList();
        //                CommandEmployeeVM VMM = new CommandEmployeeVM()
        //                {
        //                    Emplooyees = _context.Emplooyeees.Where(w => w.Status != false && w.IsWorking == false && w.CompanyId == findUserr.CompaniesId && w.IsCandidate == false).ToList(),
        //                    Commandss = _context.Commands.Where(w => w.Status != false).ToList(),
        //                    WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
        //                    TaxBreaks = _context.TaxBreaks.ToList(),
        //                    DepartmentToCompanies = departmentsS,
        //                };
        //            }
        //            AppUser findCurrentUser = await _userManager.FindByEmailAsync(User.Identity.Name);
        //            AppUser newUser = new AppUser()
        //            {
        //                Name = findEmp.FirstName,
        //                Surname = findEmp.Lastname,
        //                FatherName = findEmp.FatherName,
        //                UserName = findEmp.Email,
        //                Email = findEmp.Email,
        //                Status = true,
        //                CompaniesId = findCurrentUser.CompaniesId,
        //                EmplooyeeId = findEmp.Id,
        //            };
        //            //check workPlace,
        //            if (WorkPlace == null || WorkPlace == 0)
        //            {
        //                ViewData["error_WorkPlace"] = "Zəhmət olmasa iş növünü seçin";
        //                return View(VM);
        //            }
        //            if (createDate.Year < 2010)
        //            {
        //                ViewData["error_createDate"] = "Zəhmət olmasa qəbul vaxtını seçin";
        //                return View(VM);
        //            }
        //            IdentityResult identityResult = await _userManager.CreateAsync(newUser, "rR@23.");
        //            if (!identityResult.Succeeded)
        //            {
        //                foreach (var error in identityResult.Errors)
        //                {
        //                    ModelState.AddModelError("", error.Description);
        //                }
        //                return View(VM);
        //            }
        //            await _userManager.AddToRoleAsync(newUser, Utility.Roles.Member.ToString());
        //            findEmp.IsWorking = true;
        //        }
        //        //add Database
        //        findEmp.WorkTimeOfTypeId = employeeVM.WorkTimeOfTypeId;
        //        var baseeId = _context.WorkPlaceAdditions.Where(w => w.Name == "Əsas iş yeri").FirstOrDefault().Id;
        //        var addId = _context.WorkPlaceAdditions.Where(w => w.Name == "Əlavə iş yeri").FirstOrDefault().Id;
        //        if (WorkPlace == 1)
        //        {
        //            findEmp.WorkPlaceAdditionId = baseeId;
        //        }
        //        else if (WorkPlace == 2)
        //        {
        //            findEmp.WorkPlaceAdditionId = addId;
        //        }

        //        if (employeeVM.TaxBreakId != null)
        //        {
        //            TaxBreakToEmplooyee newTaxBreakToEmplooyee = new TaxBreakToEmplooyee();
        //            newTaxBreakToEmplooyee.TaxBreakId = employeeVM.TaxBreakId;
        //            newTaxBreakToEmplooyee.EmplooyeeId = employeeVM.EmplooyeeId;
        //            await _context.TaxBreakToEmplooyees.AddAsync(newTaxBreakToEmplooyee);
        //            await _context.SaveChangesAsync();
        //        }
        //        if (employeeVM.WorkBookAddition.WorkbookNumber != null || employeeVM.WorkBookAddition.ContractNumber != null || employeeVM.WorkBookAddition.SSNNumber != null)
        //        {
        //            WorkBookAddition newWorkBookAddition = new WorkBookAddition();
        //            if (employeeVM.WorkBookAddition.WorkbookNumber != null)
        //            {
        //                newWorkBookAddition.WorkbookNumber = employeeVM.WorkBookAddition.WorkbookNumber.Trim();
        //            }
        //            if (employeeVM.WorkBookAddition.ContractNumber != null)
        //            {
        //                newWorkBookAddition.ContractNumber = employeeVM.WorkBookAddition.ContractNumber.Trim();
        //            }
        //            if (employeeVM.WorkBookAddition.SSNNumber != null)
        //            {
        //                newWorkBookAddition.SSNNumber = employeeVM.WorkBookAddition.SSNNumber.Trim();
        //            }
        //            await _context.WorkBookAdditions.AddAsync(newWorkBookAddition);
        //            await _context.SaveChangesAsync();
        //            findEmp.WorkBookAdditionId = newWorkBookAddition.Id;
        //        }

        //        findEmp.Salary = employeeVM.Salary;
        //        findEmp.PositionsId = employeeVM.PositionId;
        //        CommandsToEmployee commandsToEmployee = new CommandsToEmployee();
        //        commandsToEmployee.EmplooyeeId = employeeVM.EmplooyeeId;//
        //        commandsToEmployee.CommandId = findCommand.Id;
        //        commandsToEmployee.CreatedDate = createDate;
        //        commandsToEmployee.TimeOfExecution = DateTime.Now;
        //        _context.Entry(findEmp).State = EntityState.Modified;
        //        await _context.CommandsToEmployees.AddAsync(commandsToEmployee);
        //        await _context.SaveChangesAsync();
        //        TempData["msg"] = "Added";
        //        return RedirectToAction(nameof(CreateEmpRecruitmentCommand));//Deyisib umumi siyahiya yonlendirersen
        //    }
        //    return View(VM);
        //}

        #endregion
        public async Task<IActionResult> UpdateEmpRecruitmentCommand(int? id)
        {
            if (id == null) NotFound();
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
                                                                                         w.CompanyId == findUser.CompaniesId).ToList();
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                   w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            var taxBreakEmp = _context.TaxBreakToEmplooyees.Where(t => t.Emplooyee.Status != false && t.Emplooyee.IsWorking != false &&
                                                                  t.EmplooyeeId == commandForEmp.EmplooyeeId).FirstOrDefault();

            CommandEmployeeVM commandVM = new CommandEmployeeVM()
            {
                CommandsToEmployee = commandForEmp,
                WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
                TaxBreaks = _context.TaxBreaks.ToList(),
                DepartmentToCompanies = departments,
                TaxBreakToEmplooyee = taxBreakEmp,
                SubDepartments = _context.SubDepartments.Where(s => s.Status != false),
                Positions = _context.Positions.Where(p => p.Status != false),
            };
            return View(commandVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateEmpRecruitmentCommand(CommandEmployeeVM employeeVM, int? id)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
                                                                                         w.CompanyId == findUser.CompaniesId).ToList();
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                   w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            var taxBreakEmp = _context.TaxBreakToEmplooyees.Where(t => t.Emplooyee.Status != false && t.Emplooyee.IsWorking != false &&
                                                                  t.EmplooyeeId == commandForEmp.EmplooyeeId).FirstOrDefault();

            CommandEmployeeVM commandVM = new CommandEmployeeVM()
            {
                CommandsToEmployee = commandForEmp,
                WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
                TaxBreaks = _context.TaxBreaks.ToList(),
                DepartmentToCompanies = departments,
                TaxBreakToEmplooyee = taxBreakEmp,
                SubDepartments = _context.SubDepartments.Where(s => s.Status != false),
                Positions = _context.Positions.Where(p => p.Status != false),
                //CommandInEmpId = commandForEmp.Id
            };

            if (ModelState["CreatedDate"].ValidationState != ModelValidationState.Invalid &&
                ModelState["WorkTimeOfTypeId"].ValidationState != ModelValidationState.Invalid &&
                //ModelState["WorkPlace"].ValidationState != ModelValidationState.Invalid &&
                ModelState["Salary"].ValidationState != ModelValidationState.Invalid &&
                ModelState["PositionId"].ValidationState != ModelValidationState.Invalid)
            {
                var checkCommand = _context.CommandsToEmployees.Where(w => w.Id == id).FirstOrDefault();
                if (checkCommand == null) NotFound();
                checkCommand.Emplooyee.WorkTimeOfTypeId = employeeVM.WorkTimeOfTypeId;
                var baseeId = _context.WorkPlaceAdditions.Where(w => w.Name == "Əsas iş yeri").FirstOrDefault().Id;
                var addId = _context.WorkPlaceAdditions.Where(w => w.Name == "Əlavə iş yeri").FirstOrDefault().Id;
                if (employeeVM.WorkPlace == 1)
                {
                    checkCommand.Emplooyee.WorkPlaceAdditionId = baseeId;
                }
                else if (employeeVM.WorkPlace == 2)
                {
                    checkCommand.Emplooyee.WorkPlaceAdditionId = addId;
                }
                if (employeeVM.TaxBreakId != null)
                {
                    if (taxBreakEmp != null)
                    {
                        taxBreakEmp.TaxBreakId = employeeVM.TaxBreakId;
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        TaxBreakToEmplooyee newTaxBreakToEmplooyee = new TaxBreakToEmplooyee();
                        newTaxBreakToEmplooyee.TaxBreakId = employeeVM.TaxBreakId;
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

                if (employeeVM.WorkBookAddition.WorkbookNumber != null || employeeVM.WorkBookAddition.ContractNumber != null || employeeVM.WorkBookAddition.SSNNumber != null)
                {
                    if (checkCommand.Emplooyee.WorkBookAdditionId != null)
                    {
                        if (employeeVM.WorkBookAddition.WorkbookNumber != null)
                        {
                            checkCommand.Emplooyee.WorkBookAddition.WorkbookNumber = employeeVM.WorkBookAddition.WorkbookNumber.Trim();
                        }
                        else
                        {
                            checkCommand.Emplooyee.WorkBookAddition.WorkbookNumber = null;
                        }
                        if (employeeVM.WorkBookAddition.ContractNumber != null)
                        {
                            checkCommand.Emplooyee.WorkBookAddition.ContractNumber = employeeVM.WorkBookAddition.ContractNumber.Trim();
                        }
                        else
                        {
                            checkCommand.Emplooyee.WorkBookAddition.ContractNumber = null;
                        }
                        if (employeeVM.WorkBookAddition.SSNNumber != null)
                        {
                            checkCommand.Emplooyee.WorkBookAddition.SSNNumber = employeeVM.WorkBookAddition.SSNNumber.Trim();
                        }
                        else
                        {
                            checkCommand.Emplooyee.WorkBookAddition.SSNNumber = null;
                        }
                    }
                    else
                    {
                        WorkBookAddition newWorkBookAddition = new WorkBookAddition();
                        if (employeeVM.WorkBookAddition.WorkbookNumber != null)
                        {
                            newWorkBookAddition.WorkbookNumber = employeeVM.WorkBookAddition.WorkbookNumber.Trim();
                        }
                        if (employeeVM.WorkBookAddition.ContractNumber != null)
                        {
                            newWorkBookAddition.ContractNumber = employeeVM.WorkBookAddition.ContractNumber.Trim();
                        }
                        if (employeeVM.WorkBookAddition.SSNNumber != null)
                        {
                            newWorkBookAddition.SSNNumber = employeeVM.WorkBookAddition.SSNNumber.Trim();
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
                checkCommand.Emplooyee.PositionsId = employeeVM.PositionId;
                checkCommand.Emplooyee.Salary = employeeVM.Salary;
                checkCommand.CreatedDate = employeeVM.CreatedDate;
                checkCommand.TimeOfExecution = DateTime.Now;
                _context.Entry(checkCommand).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                TempData["msg"] = "Added";
                return RedirectToAction(nameof(CreateEmpRecruitmentCommand));
            }

            return View(commandVM);
        }

        public async Task<IActionResult> DetailEmpRecruitmentCommand(int? id)
        {
            if (id == null) return NotFound();
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandsToEmployee commands = await _context.CommandsToEmployees.FindAsync(id);
            CommandEmployeeVM employeeVM = new CommandEmployeeVM()
            {
                CommandsToEmployee = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false &&
                                                                        c.Emplooyee.CompanyId == findUser.CompaniesId && c.Id == id).FirstOrDefault(),
                TaxBreakToEmplooyee = _context.TaxBreakToEmplooyees.Where(t => t.Emplooyee.Status != false && t.Emplooyee.IsWorking != false && t.Emplooyee.CompanyId == findUser.CompaniesId &&
                                                                          t.EmplooyeeId == commands.EmplooyeeId).FirstOrDefault()
            };
            if (employeeVM == null) return NotFound();
            return View(employeeVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEmpRecruitmentCommand(CommandEmployeeVM employeeVM,int? WorkPlace)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
                                                                                         w.CompanyId == findUser.CompaniesId).ToList();
            CommandEmployeeVM VM = new CommandEmployeeVM()
            {
                Emplooyees = _context.Emplooyeees.Where(w => w.Status != false && w.IsWorking == false && w.CompanyId == findUser.CompaniesId && w.IsCandidate == false).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false && c.Emplooyee.IsCandidate == false &&
                                                                        c.Emplooyee.CompanyId == findUser.CompaniesId && c.Command.Status != false && c.Command.Name == "İşə qəbul").ToList(),
                WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
                TaxBreaks = _context.TaxBreaks.ToList(),
                DepartmentToCompanies = departments
            };
            if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid
               && ModelState["WorkTimeOfTypeId"].ValidationState != ModelValidationState.Invalid
               && ModelState["CreatedDate"].ValidationState != ModelValidationState.Invalid
               && ModelState["PositionId"].ValidationState != ModelValidationState.Invalid
               && ModelState["Salary"].ValidationState != ModelValidationState.Invalid)
            {
                Emplooyee findEmp = _context.Emplooyeees.Where(w => w.Id == employeeVM.EmplooyeeId && w.Status != false).FirstOrDefault();
                if (findEmp == null) NotFound();
                Commands findCommand = _context.Commands.Where(w => w.Status != false && w.Name == "İşə qəbul").FirstOrDefault();
                var finddPos = _context.Positions.Where(w => w.Id == employeeVM.PositionId).FirstOrDefault();
                AppUser checkUser = await _userManager.FindByEmailAsync(findEmp.Email);
                if (checkUser!=null)
                {
                    checkUser.EmplooyeeId = employeeVM.EmplooyeeId;
                    await _userManager.AddToRoleAsync(checkUser, Utility.Roles.Member.ToString());
                }
                else
                {
                    AppUser newUser = new AppUser()
                    {
                        Name = findEmp.FirstName,
                        Surname = findEmp.Lastname,
                        FatherName = findEmp.FatherName,
                        UserName = findEmp.Email,
                        Email = findEmp.Email,
                        Status = true,
                        CompaniesId = findUser.CompaniesId,
                        EmplooyeeId = findEmp.Id,
                    };
                    IdentityResult identityResult = await _userManager.CreateAsync(newUser, "rR@23.");
                    if (!identityResult.Succeeded)
                    {
                        foreach (var error in identityResult.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View(VM);
                    }
                    await _userManager.AddToRoleAsync(newUser, Utility.Roles.Member.ToString());
                }
                //check workPlace,
                if (WorkPlace == null || WorkPlace == 0)
                {
                    ViewData["error_WorkPlace"] = "Zəhmət olmasa iş növünü seçin";
                    return View(VM);
                }
                //add Database
                findEmp.IsWorking = true;
                findEmp.WorkTimeOfTypeId = employeeVM.WorkTimeOfTypeId;
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

                if (employeeVM.TaxBreakId != null)
                {
                    TaxBreakToEmplooyee newTaxBreakToEmplooyee = new TaxBreakToEmplooyee();
                    newTaxBreakToEmplooyee.TaxBreakId = employeeVM.TaxBreakId;
                    newTaxBreakToEmplooyee.EmplooyeeId = employeeVM.EmplooyeeId;
                    await _context.TaxBreakToEmplooyees.AddAsync(newTaxBreakToEmplooyee);
                    await _context.SaveChangesAsync();
                }
                if (employeeVM.WorkBookAddition.WorkbookNumber != null || employeeVM.WorkBookAddition.ContractNumber != null || employeeVM.WorkBookAddition.SSNNumber != null)
                {
                    WorkBookAddition newWorkBookAddition = new WorkBookAddition();
                    if (employeeVM.WorkBookAddition.WorkbookNumber != null)
                    {
                        newWorkBookAddition.WorkbookNumber = employeeVM.WorkBookAddition.WorkbookNumber.Trim();
                    }
                    if (employeeVM.WorkBookAddition.ContractNumber != null)
                    {
                        newWorkBookAddition.ContractNumber = employeeVM.WorkBookAddition.ContractNumber.Trim();
                    }
                    if (employeeVM.WorkBookAddition.SSNNumber != null)
                    {
                        newWorkBookAddition.SSNNumber = employeeVM.WorkBookAddition.SSNNumber.Trim();
                    }
                    await _context.WorkBookAdditions.AddAsync(newWorkBookAddition);
                    await _context.SaveChangesAsync();
                    findEmp.WorkBookAdditionId = newWorkBookAddition.Id;
                }

                findEmp.Salary = employeeVM.Salary;
                findEmp.PositionsId = employeeVM.PositionId;
                CommandsToEmployee commandsToEmployee = new CommandsToEmployee();
                commandsToEmployee.EmplooyeeId = employeeVM.EmplooyeeId;//
                commandsToEmployee.CommandId = findCommand.Id;
                commandsToEmployee.CreatedDate = employeeVM.CreatedDate;
                commandsToEmployee.TimeOfExecution = DateTime.Now;
                _context.Entry(findEmp).State = EntityState.Modified;
                await _context.CommandsToEmployees.AddAsync(commandsToEmployee);
                await _context.SaveChangesAsync();
                ViewData["msg"] = "Added";
                return RedirectToAction(nameof(CreateEmpRecruitmentCommand));//Deyisib umumi siyahiya yonlendirersen
            }
                return View(VM);
        }
    }
}
