using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss")]
    public class ReminderVacation : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public ReminderVacation(InternalSysDBContext context, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }

        public async Task<IActionResult> Update()
        {
            AppUser currentHr = await _userManager.FindByEmailAsync(User.Identity.Name);
            ReminderVacationVM reminderVacationVM = new ReminderVacationVM()
            {
                Emplooyees = _context.Emplooyeees.Where(e => e.Status == true && e.IsWorking == true &&  e.CompanyId == currentHr.CompaniesId&& e.Positions.VacationDayCount!=0&& e.PositionsId!=null).ToList().OrderByDescending(x=>x.Id),
                CommandsToEmployees=_context.CommandsToEmployees.Where(c => c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false && c.Emplooyee.IsCandidate == false &&
                                                                        c.Emplooyee.CompanyId == currentHr.CompaniesId && c.Command.Status != false && c.Command.Name == "İşə qəbul"&&c.CommandId==1&& c.Emplooyee.Positions.VacationDayCount!=0&&c.Emplooyee.Positions!=null).ToList(),
            };
            return View(reminderVacationVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateVacationDay(ReminderVacationVM reminderVacationVM)
        {
            AppUser Hrdep = await _userManager.FindByEmailAsync(User.Identity.Name);
            ReminderVacationVM rmdvction = new ReminderVacationVM()
            {
                Emplooyees = _context.Emplooyeees.Where(employee => employee.Status == true && employee.IsWorking == true && employee.IsCandidate == false && employee.CompanyId == Hrdep.CompaniesId).ToList(),
            };

            return View();
        }
    }
}
