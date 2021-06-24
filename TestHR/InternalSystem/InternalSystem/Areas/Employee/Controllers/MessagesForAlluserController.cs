using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss,HumanResource")]

    public class MessagesForAlluserController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public MessagesForAlluserController(UserManager<AppUser> userManager, InternalSysDBContext context,
            IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task <IActionResult> Create()
        {
            AppUser CurrentHr = await _userManager.FindByEmailAsync(User.Identity.Name);
            MessagesForAllVM vm = new MessagesForAllVM()
            {
                Companiess=_context.Companies.Where(xn=>xn.status==true&&xn.Id==CurrentHr.CompaniesId).ToList(),
                TelMes = _context.TelMes.Where(xn => xn.Status == true && xn.IsDelete == true).ToList()
            };
            return View(vm);

        }
        [HttpPost]
        public  IActionResult  Create(TelMe newtelme)
        {
            //if (ModelState["Company"])
            //{

            //}
            return View();
        }
    }
}
