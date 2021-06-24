using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.DateOfTabel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss")]
    public class AddHolidaysController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public AddHolidaysController(InternalSysDBContext context, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }
        public async Task<IActionResult> Create()
        {
            AppUser currentHr = await _userManager.FindByEmailAsync(User.Identity.Name);
            CalendarVm calendarVm = new CalendarVm()
            {
                //Calendars=_context.Calendars.
                Calendars=_context.Calendars,
            };
            return View(calendarVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(CalendarVm calendarVm)
        {
            //CalendarVm calendarVm = new CalendarVm()
            //{
            //    Ca
            //};
            if (ModelState["CalendarName"].ValidationState!=ModelValidationState.Invalid||
                ModelState["FromDate"].ValidationState!=ModelValidationState.Invalid||
                ModelState["ToDate"].ValidationState != ModelValidationState.Invalid ||
                ModelState["GeneralWorkHour"].ValidationState != ModelValidationState.Invalid ||
                ModelState["NormativeDay"].ValidationState != ModelValidationState.Invalid  
                )
            {
                Calendar newCal = new Calendar();
                newCal.CalendarName = calendarVm.CalendarName;
                newCal.FromDate = calendarVm.FromDate;
                newCal.ToDate = calendarVm.ToDate;
                newCal.NormativeDay = calendarVm.NormativeDay;
                newCal.GeneralWorkHour = calendarVm.GeneralWorkHour;
                await _context.Calendars.AddAsync(newCal);
                await _context.SaveChangesAsync();

            }
            //return View();
            return RedirectToAction(nameof(Create));
        }
       

        public async Task<IActionResult> CreateHolidays()
        {
            AppUser finduser = await _userManager.FindByEmailAsync(User.Identity.Name);
            HolidaysOfcalendarVM holiday = new HolidaysOfcalendarVM()
            {
                Calendars=_context.Calendars,
                HolidayOfCalendars=_context.HolidayOfCalendars
            };
           

                return View(holiday);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateHolidays(HolidaysOfcalendarVM holidaysvm)
        {
            AppUser user = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (ModelState["HolidayName"].ValidationState != ModelValidationState.Invalid ||
               ModelState["HolidayDate"].ValidationState != ModelValidationState.Invalid ||
               ModelState["CalendarId"].ValidationState != ModelValidationState.Invalid
               )
            {
                HolidayOfCalendar holidayOfCalendar = new HolidayOfCalendar();
                holidayOfCalendar.HolidayName = holidaysvm.HolidayName;
                holidayOfCalendar.HolidayDate = holidaysvm.HolidayDate;
                holidayOfCalendar.CalendarId = holidaysvm.CalendarId;
                holidayOfCalendar.UserName = user.UserName;
                await _context.HolidayOfCalendars.AddAsync(holidayOfCalendar);
                await _context.SaveChangesAsync();
            }
            //return View();
            return RedirectToAction(nameof(CreateHolidays));

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
