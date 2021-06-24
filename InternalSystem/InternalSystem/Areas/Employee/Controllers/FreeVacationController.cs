using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.Models.FreeVacation;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss")]
    public class FreeVacationController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        public FreeVacationController(InternalSysDBContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }
        public async Task<IActionResult> Create()
        {
            AppUser currentHr = await _userManager.FindByEmailAsync(User.Identity.Name);
            FreeVacationVM freeVacation = new FreeVacationVM()
            {
                FreeVacations = _context.FreeVacations.Where(xn => xn.Emplooyee.CompanyId == currentHr.CompaniesId).ToList(),

                Emplooyees = _context.Emplooyeees.Where(ex => ex.Status == true &&
                  ex.IsWorking == true &&
                  ex.IsCandidate == false &&
                  ex.PositionsId != null &&
                  ex.CompanyId == currentHr.CompaniesId
                ).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(xn => xn.Command.Status == true &&
                xn.Emplooyee.Status == true &&
                xn.Emplooyee.IsWorking == true &&
                xn.Emplooyee.IsCandidate == false &&
                xn.Emplooyee.CompanyId == currentHr.CompaniesId &&
                xn.Command.Name == "Ödənişsiz Məzuniyyət"
                ).Take(400).ToList(),

            };
            return View(freeVacation);
           
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
         
        public async Task<IActionResult> Create(FreeVacationVM freeVacation)
        {
            AppUser hr = await _userManager.FindByEmailAsync(User.Identity.Name);
            FreeVacationVM newvacation = new FreeVacationVM()
            {
                Emplooyees = _context.Emplooyeees.Where(ex => ex.Status == true &&
                   ex.IsWorking == true &&
                   ex.IsCandidate == false &&
                   ex.PositionsId != null &&
                   ex.CompanyId == hr.CompaniesId

                 ).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(xn => xn.Command.Status == true &&
               xn.Emplooyee.Status == true &&
               xn.Emplooyee.IsWorking == true &&
               xn.Emplooyee.IsCandidate == false &&
               xn.Emplooyee.CompanyId == hr.CompaniesId &&
               xn.Command.Name == "Ödənişsiz Məzuniyyət"
                ).Take(400).ToList(),
            };
            if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid ||
                ModelState["FromDate"].ValidationState != ModelValidationState.Invalid ||
                ModelState["ToDate"].ValidationState != ModelValidationState.Invalid)
            {
                Commands findCommand = _context.Commands.Where(c => c.Status != false && c.Name == "Ödənişsiz Məzuniyyət").FirstOrDefault();
                if (findCommand == null)
                {
                    return NotFound();
                }
                Emplooyee findEmp = _context.Emplooyeees.Where(e => e.Status != false
                && e.IsWorking != false
                && e.CompanyId == hr.CompaniesId
                && e.Id == freeVacation.EmplooyeeId).FirstOrDefault();
                if (findEmp == null)
                {
                    return NotFound();
                }
                AppUser FindAspUser = await _userManager.FindByEmailAsync(findEmp.Email);
                CommandsToEmployee cmdtoEmp = new CommandsToEmployee();
                cmdtoEmp.CommandId = findCommand.Id;
                //cmdtoEmp.EmplooyeeId = vacationVM.EmplooyeeId;
                cmdtoEmp.CreatedDate = DateTime.Now;
                FreeVacation FREEvacation = new FreeVacation();
                FREEvacation.EmplooyeeId = freeVacation.EmplooyeeId;
                FREEvacation.Description = freeVacation.Description;
                FREEvacation.FromDate = freeVacation.FromDate;
                FREEvacation.ToDate = freeVacation.ToDate;
                FREEvacation.FreeVacationTypeId = 1;
                FREEvacation.CreaterUser = hr.Emplooyee.Email;
                FREEvacation.ExecTime = DateTime.Now;
                await _context.FreeVacations.AddAsync(FREEvacation);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Create));
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
