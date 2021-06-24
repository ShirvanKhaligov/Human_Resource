using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using InternalSystem.Areas.Admin.Models;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss")]
    public class GrossNetController : Controller
    {
        private readonly InternalSysDBContext _context;
        private UserManager<AppUser> _usr;
        public GrossNetController(InternalSysDBContext context,UserManager<AppUser> usr)
        {
            _context=context;
            _usr = usr;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
