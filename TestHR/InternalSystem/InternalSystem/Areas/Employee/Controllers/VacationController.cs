using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.Models.Vacation;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Commands;
using Microsoft.AspNetCore.Authorization;
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
    public class VacationController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        public VacationController(InternalSysDBContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        
     
        public async Task<IActionResult> Create()
        {
            AppUser currentBosHr = await _userManager.FindByEmailAsync(User.Identity.Name);
            VacationVM vacationVM = new VacationVM()
            {
                
                Vacations =_context.Vacations.Where(d=>d.Emplooyee.CompanyId==currentBosHr.CompaniesId).ToList(),
                Emplooyees = _context.Emplooyeees.Where(ex => ex.Status == true &&
                  ex.IsWorking == true &&
                  ex.IsCandidate == false &&
                  ex.PositionsId != null &&
                  ex.CompanyId == currentBosHr.CompaniesId
                  //&&
                  //ex.IsInVacation == false
                ).ToList(),
                
                CommandsToEmployees = _context.CommandsToEmployees.Where(xn => xn.Command.Status == true &&
                xn.Emplooyee.Status == true &&
                xn.Emplooyee.IsWorking == true &&
                xn.Emplooyee.IsCandidate == false &&
                //xn.Emplooyee.IsInVacation == false &&
                xn.Emplooyee.CompanyId == currentBosHr.CompaniesId &&
                xn.Command.Name == "Məzuniyyət"
                ).Take(400).ToList(),

            };
            return View(vacationVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VacationVM vacationVM)
        {
            AppUser FindCurrentHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            VacationVM newvacation = new VacationVM()
            {
                Emplooyees = _context.Emplooyeees.Where(ex => ex.Status == true &&
                   ex.IsWorking == true &&
                   ex.IsCandidate == false &&
                   ex.PositionsId != null &&
                   ex.CompanyId == FindCurrentHR.CompaniesId
                   //&&
                   //ex.IsInVacation == false
                ).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(xn => xn.Command.Status == true &&
               xn.Emplooyee.Status == true &&
               xn.Emplooyee.IsWorking == true &&
               xn.Emplooyee.IsCandidate == false &&
               //xn.Emplooyee.IsInVacation == false &&
               xn.Emplooyee.CompanyId == FindCurrentHR.CompaniesId &&
               xn.Command.Name == "Məzuniyyət"
                ).Take(400).ToList(),
            };
            if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid ||
                ModelState["FromDate"].ValidationState != ModelValidationState.Invalid ||
                ModelState["ToDate"].ValidationState != ModelValidationState.Invalid)
            {
                Commands findCommand = _context.Commands.Where(c => c.Status != false && c.Name == "Məzuniyyət").FirstOrDefault();
                if (findCommand == null)
                {
                    return NotFound();
                }
                Emplooyee findEmp = _context.Emplooyeees.Where(e => e.Status != false
                && e.IsWorking != false
                && e.CompanyId == FindCurrentHR.CompaniesId
                && e.Id == vacationVM.EmplooyeeId).FirstOrDefault();
                if (findEmp==null)
                {
                    return NotFound();
                }
                AppUser FindAspUser = await _userManager.FindByEmailAsync(findEmp.Email);
                CommandsToEmployee cmdtoEmp = new CommandsToEmployee();
                cmdtoEmp.CommandId = findCommand.Id;
                //cmdtoEmp.EmplooyeeId = vacationVM.EmplooyeeId;
                cmdtoEmp.CreatedDate = DateTime.Now;
                Vacation vacation = new Vacation();
                vacation.EmplooyeeId = vacationVM.EmplooyeeId;
                vacation.Description = vacationVM.Description;
                vacation.FromDate = vacationVM.FromDate;
                vacation.ToDate = vacationVM.ToDate;
                vacation.VacationTypeId = 1;
                await _context.Vacations.AddAsync(vacation);
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
