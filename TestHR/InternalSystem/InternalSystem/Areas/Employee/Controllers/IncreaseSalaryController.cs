using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss")]
    public class IncreaseSalaryController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        public IncreaseSalaryController(InternalSysDBContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Create()
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandsSalaryIncrease commandsSalary = new CommandsSalaryIncrease()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.CompanyId == findUser.CompaniesId).ToList(),
                Commands = _context.Commands.Where(c => c.Status != false && c.Name == "Maaş artımı").FirstOrDefault(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Command.Name == "Maaş artımı").ToList()
            };
            return View(commandsSalary);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CommandsSalaryIncrease commandsSalary)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            CommandsSalaryIncrease commandsSalaryVM = new CommandsSalaryIncrease()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.CompanyId == findUser.CompaniesId).ToList(),
                Commands = _context.Commands.Where(c => c.Status != false && c.Name == "Maaş artımı").FirstOrDefault(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Command.Name == "Maaş artımı").ToList()
            };

            if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid ||
                ModelState["CreateDate"].ValidationState != ModelValidationState.Invalid
              || ModelState["Salary"].ValidationState != ModelValidationState.Invalid)
            {
                var findEmp = _context.Emplooyeees.Where(e => e.Id == commandsSalary.EmplooyeeId).FirstOrDefault();
                if (findEmp == null) return NotFound();
                var findCommand = _context.Commands.Where(c => c.Status != false && c.Name == "Maaş artımı").FirstOrDefault();
                if (findCommand == null) return NotFound();

                CommandsToEmployee increaseSalaryToEmployee = new CommandsToEmployee();
                increaseSalaryToEmployee.CommandId = findCommand.Id;
                increaseSalaryToEmployee.EmplooyeeId = commandsSalary.EmplooyeeId;
                increaseSalaryToEmployee.CreatedDate = commandsSalary.CreateDate;
                increaseSalaryToEmployee.TimeOfExecution = DateTime.Now;
                await _context.CommandsToEmployees.AddAsync(increaseSalaryToEmployee);
                await _context.SaveChangesAsync();

                OldSalary oldSalaryEmp = new OldSalary();
                oldSalaryEmp.EmplooyeeId = commandsSalary.EmplooyeeId;
                oldSalaryEmp.CommandsToEmployeeId = increaseSalaryToEmployee.Id;
                oldSalaryEmp.Salary = findEmp.Salary;
                oldSalaryEmp.CreatedDate = commandsSalary.CreateDate;
                oldSalaryEmp.Description = commandsSalary.Commands.Description;
                await _context.OldSalaries.AddAsync(oldSalaryEmp);
                findEmp.Salary = commandsSalary.NewSalary;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(commandsSalaryVM);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) NotFound();
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                 w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandsSalaryIncrease commandsSalary = new CommandsSalaryIncrease()
            {
                CommandsToEmployee = commandForEmp,
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.CompanyId == findUser.CompaniesId).ToList(),
                Commands = _context.Commands.Where(c => c.Status != false && c.Name == "Maaş artımı").FirstOrDefault(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Command.Name == "Maaş artımı").ToList(),
                OldSalary = _context.OldSalaries.Where(c => c.CommandsToEmployeeId == id).FirstOrDefault()
            };
            return View(commandsSalary);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CommandsSalaryIncrease employeeVM, int? id)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            var commandForEmp = _context.CommandsToEmployees.Where(w => w.Emplooyee.Status != false && w.Emplooyee.IsWorking != false &&
                                                                w.Emplooyee.IsCandidate == false && w.Id == id).FirstOrDefault();
            CommandsSalaryIncrease commandsSalary = new CommandsSalaryIncrease()
            {
                CommandsToEmployee = commandForEmp,
                Emplooyees = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.IsCandidate == false && e.CompanyId == findUser.CompaniesId).ToList(),
                Commands = _context.Commands.Where(c => c.Status != false && c.Name == "Maaş artımı").FirstOrDefault(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Command.Status != false && c.Command.Name == "Maaş artımı").ToList(),
                OldSalary = _context.OldSalaries.Where(c => c.CommandsToEmployeeId == id).FirstOrDefault()
            };
            if (ModelState["CreateDate"].ValidationState != ModelValidationState.Invalid
              || ModelState["Salary"].ValidationState != ModelValidationState.Invalid)
            {
                var emp = _context.Emplooyeees.Where(e => e.Status != false && e.IsWorking != false && e.Id == commandForEmp.EmplooyeeId).FirstOrDefault();
                var checkCommand = _context.CommandsToEmployees.Where(w => w.Id == id).FirstOrDefault();
                if (checkCommand == null) NotFound();
                var oldSalary = _context.OldSalaries.Where(c => c.CommandsToEmployeeId == id).FirstOrDefault();
                oldSalary.CreatedDate = employeeVM.CreateDate;
                emp.Salary = employeeVM.NewSalary;
                oldSalary.Description = employeeVM.OldSalary.Description;
                await _context.SaveChangesAsync();
            }
            return View(commandsSalary);
        }
    }
}
