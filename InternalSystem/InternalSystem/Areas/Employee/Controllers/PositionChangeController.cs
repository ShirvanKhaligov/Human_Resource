
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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
namespace InternalSystem.Areas.Employee.Controllers
{

    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss")]
    public class PositionChangeController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        public PositionChangeController(InternalSysDBContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult GetScanPdf(int? empId)
        {
            if (empId == null) return NotFound();

            CommandEmpPositionChVM scanVM = new CommandEmpPositionChVM()
            {
                //Emplooyee = _context.Emplooyeees.Where(w => w.Status != false && w.IsCandidate == false && w.Id == empId).FirstOrDefault(),
                ScanPdfCommands = _context.ScanPdfCommands.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false && w.Emplooyee.IsCandidate == false &&
                  w.CommandsName == "Vəzifə dəy." && w.EmplooyeeId == empId).LastOrDefault()
            };
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetScanCommands.cshtml", scanVM);
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
        public async Task<IActionResult> Create()
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
                                                                                         w.CompanyId == findUser.CompaniesId).ToList();
            CommandEmpPositionChVM employeePosChVM = new CommandEmpPositionChVM()
            {
                Emplooyees = _context.Emplooyeees.Where(w => w.Status != false && w.IsWorking != false && w.CompanyId == findUser.CompaniesId && w.IsCandidate == false).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false && c.Emplooyee.IsCandidate == false &&
                                                                         c.Emplooyee.PositionsId != null && c.Emplooyee.CompanyId == findUser.CompaniesId && c.Command.Status != false && c.Command.Name == "Vəzifə dəy.").ToList(),
                WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
                DepartmentToCompanies = departments,
            };
            return View(employeePosChVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CommandEmpPositionChVM employeeVM, int? WorkPlace)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
                                                                                         w.CompanyId == findUser.CompaniesId).ToList();
            CommandEmpPositionChVM employeePosChVM = new CommandEmpPositionChVM()
            {
                Emplooyees = _context.Emplooyeees.Where(w => w.Status != false && w.IsWorking != false && w.CompanyId == findUser.CompaniesId && w.IsCandidate == false).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false && c.Emplooyee.IsCandidate == false &&
                                                                         c.Emplooyee.PositionsId != null && c.Emplooyee.CompanyId == findUser.CompaniesId && c.Command.Status != false && c.Command.Name == "Vəzifə dəy.").ToList(),
                WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
                DepartmentToCompanies = departments,
            };
            if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid
                && ModelState["WorkTimeOfTypeId"].ValidationState != ModelValidationState.Invalid
                && ModelState["PositionId"].ValidationState != ModelValidationState.Invalid
                && ModelState["Salary"].ValidationState != ModelValidationState.Invalid)
            {
                Emplooyee findEmp = _context.Emplooyeees.Where(w => w.Id == employeeVM.EmplooyeeId && w.Status != false).FirstOrDefault();
                if (findEmp == null) return NotFound();
                Commands findCommand = _context.Commands.Where(w => w.Status != false && w.Name == "Vəzifə dəy.").FirstOrDefault();
                if (findCommand == null) return NotFound();
                var finddPos = _context.Positions.Where(w => w.Id == employeeVM.PositionId).FirstOrDefault();
                AppUser checkUser = await _userManager.FindByEmailAsync(findEmp.Email);
                //check workPlace,
                if (WorkPlace == null || WorkPlace == 0)
                {
                    ViewData["error_WorkPlace"] = "Zəhmət olmasa iş növünü seçin";
                    return View(employeePosChVM);
                }
                //Add CommandToEmp Table
                CommandsToEmployee posChangecommandsToEmp = new CommandsToEmployee();
                posChangecommandsToEmp.EmplooyeeId = employeeVM.EmplooyeeId;
                posChangecommandsToEmp.CommandId = findCommand.Id;
                posChangecommandsToEmp.CreatedDate = employeeVM.CreatedDate;
                posChangecommandsToEmp.TimeOfExecution = DateTime.Now;
                await _context.CommandsToEmployees.AddAsync(posChangecommandsToEmp);
                await _context.SaveChangesAsync();

                //Add History Position Table
                HistoryPositionChange empHistoryPosition = new HistoryPositionChange();
                empHistoryPosition.EmplooyeeId = employeeVM.EmplooyeeId;
                empHistoryPosition.CommandsToEmployeeId = posChangecommandsToEmp.Id;
                empHistoryPosition.PositionId = findEmp.PositionsId;
                empHistoryPosition.WorkPlaceAdditionId = findEmp.WorkPlaceAdditionId;
                empHistoryPosition.WorkTimeOfTypeId = findEmp.WorkTimeOfTypeId;
                empHistoryPosition.Salary = findEmp.Salary;
                await _context.HistoryPositionChanges.AddAsync(empHistoryPosition);
                await _context.SaveChangesAsync();

                //add database
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
                findEmp.WorkTimeOfTypeId = employeeVM.WorkTimeOfTypeId;
                findEmp.Salary = employeeVM.Salary;
                findEmp.PositionsId = employeeVM.PositionId;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(employeePosChVM);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandsToEmployee commands = await _context.CommandsToEmployees.FindAsync(id);
            CommandEmpPositionChVM employeeVM = new CommandEmpPositionChVM()
            {
                CommandsToEmployee = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false &&
                                                                        c.Emplooyee.CompanyId == findUser.CompaniesId && c.Id == id).FirstOrDefault(),
                ScanPdfCommands = _context.ScanPdfCommands.Where(s => s.CommandsName == "Vəzifə dəy." && s.EmplooyeeId == commands.EmplooyeeId).LastOrDefault()
            };
            if (employeeVM == null) return NotFound();
            return View(employeeVM);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) NotFound();
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
                                                                                         w.CompanyId == findUser.CompaniesId).ToList();
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                   w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandEmpPositionChVM commandVM = new CommandEmpPositionChVM()
            {
                CommandsToEmployee = commandForEmp,
                WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
                DepartmentToCompanies = departments,
                SubDepartments = _context.SubDepartments.Where(s => s.Status != false),
                Positions = _context.Positions.Where(p => p.Status != false),
            };
            return View(commandVM);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(CommandEmpPositionChVM employeeVM, int? id)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<DepartmentToCompany> departments = _context.DepartmentToCompanies.Where(w => w.Company.status != false && w.Department.Status != false &&
                                                                                         w.CompanyId == findUser.CompaniesId).ToList();
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                   w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandEmpPositionChVM commandVM = new CommandEmpPositionChVM()
            {
                CommandsToEmployee = commandForEmp,
                WorkTimeOfTypes = _context.WorkTimeOfTypes.ToList(),
                DepartmentToCompanies = departments,
                SubDepartments = _context.SubDepartments.Where(s => s.Status != false),
                Positions = _context.Positions.Where(p => p.Status != false),
            };
            if (ModelState["WorkTimeOfTypeId"].ValidationState != ModelValidationState.Invalid
                && ModelState["PositionId"].ValidationState != ModelValidationState.Invalid
                && ModelState["Salary"].ValidationState != ModelValidationState.Invalid)
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
                checkCommand.Emplooyee.PositionsId = employeeVM.PositionId;
                checkCommand.Emplooyee.Salary = employeeVM.Salary;
                checkCommand.CreatedDate = employeeVM.CreatedDate;
                checkCommand.TimeOfExecution = DateTime.Now;
                _context.Entry(checkCommand).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                TempData["msg"] = "Added";
                return RedirectToAction(nameof(Create));
            }
            return View(commandVM);
        }
    }
}
