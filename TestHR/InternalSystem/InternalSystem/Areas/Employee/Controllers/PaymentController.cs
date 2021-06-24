using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss")]
    public class PaymentController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        //private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public PaymentController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, InternalSysDBContext context, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _context = context;
            _roleManager = roleManager;


        }




        [HttpGet]
        public async Task<IActionResult> Attendance(DateTime date)
        {
            AppUser CurrentHr = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (date == new DateTime(0001, 01, 01)) { date = DateTime.Now; }
            var nowMonth = DateTime.Now.Month;
            var selectedMonth = date.Month;
             
            var mydays = DateTime.DaysInMonth(date.Year, date.Month);
            var findcurrentday = DateTime.Now.DayOfWeek;
            List<string> mylist = new List<string>();

            //
            //var now = DateTime.Now;
            //var dateTime1 = now.AddBusinessDays(3);
            //var dateTime2 = now.SubtractBusinessDays(5);
            DateTime dates = new DateTime();
            //if (dates.Year == 2021 && dates.Month == 2)
            //{
                for (int i = 1; i <= mydays; i++)
                {
                    var d = new DateTime(date.Year, date.Month, i);
                if (d.DayOfWeek != DayOfWeek.Sunday  /*d.Date.Day!=20&& d.Date.Day!=1&& d.Date.Day!=2&& d.Date.Day != 4*/)
                {

                    mylist.Add($"{i}/{date.Month}/{date.Year}");
                    }

                }
            //}
            //else
            //{
            //    return NotFound();
            //}

           

            //ViewBag.satuday=
            ViewBag.mydates = mylist;
            ViewBag.nowMonth = nowMonth;
            ViewBag.selectedMonth = selectedMonth;
            AttendanceVM data = new AttendanceVM
            {
                //Emplooyees=_context.Emplooyeees.Where(c=>c.IsCandidate==false &&
                //c.IsWorking==true&&
                //c.Status==true&&
                //c.CompanyId==CurrentHr.CompaniesId).ToList(),

                Emplooyees = _context.Emplooyeees.Where(w => w.Status != false &&
            w.IsWorking != false && w.IsCandidate == false && w.CompanyId == CurrentHr.CompaniesId && w.Company.status != false &&
            w.WorkTimeOfTypeId != null &&

            w.Positions.SubDepartment.DepartmentToCompany.Department.Status != false).ToList(),
                CommandsToEmployees = _context.CommandsToEmployees.Where(c => c.Emplooyee.Status != false && c.Emplooyee.IsWorking != false && c.Emplooyee.IsCandidate == false &&
                                                                         c.Emplooyee.CompanyId == CurrentHr.CompaniesId && c.Command.Status != false && c.Command.Name == "İşə qəbul" && c.CommandId == 1 && c.Emplooyee.Positions != null).ToList(),

            };
             var dayofweek = DateTime.Now.DayOfWeek;
            //var sat = dayofweek

            data.Vacations.AddRange(_context.Vacations.ToList());
            data.BusinessTripEmps.AddRange(_context.BusinessTripEmps.ToList());
            data.FreeVacations.AddRange(_context.FreeVacations.ToList());


            return View(data);
        }


        #region ATTENDANCE

        //public async Task<IActionResult> Attendance(DateTime date)
        //{
        //    if (date == new DateTime(0001, 01, 01)) { date = DateTime.Now; }

        //    var nowMonth = DateTime.Now.Month;
        //    var selectedMonth = date.Month;

        //    var mydays = DateTime.DaysInMonth(date.Year, date.Month);

        //    List<string> mylist = new List<string>();

        //    for (int i = 1; i <= mydays; i++)
        //    {
        //        mylist.Add($"{date.Month}/{i}/{date.Year}");
        //    }

        //    ViewBag.mydates = mylist;
        //    ViewBag.nowMonth = nowMonth;
        //    ViewBag.selectedMonth = selectedMonth;

        //    AbsenceViewModel data = new AbsenceViewModel
        //    {

        //        Continuities = await _context.Continuity.Include(c => c.Recruitment).ToListAsync(),

        //        Employees = await _context.Recruitments.Where(r => r.WhenLeft == new DateTime(0001, 01, 01))
        //                                                                 .Distinct().Select(r => r.Employee)
        //                                                                      .Include(e => e.Recruitments)
        //                                                                          .OrderBy(r => r.Firstname)
        //                                                                             .ToListAsync(),
        //        Continuity = new Continuity
        //        {
        //            Date = DateTime.Now
        //        }

        //    };

        //    return View(data);
        //}

        /// 
        /// </summary>
        /// <returns></returns>
        #endregion

        public IActionResult Index()
        {
            return View();
        }
    }

}
