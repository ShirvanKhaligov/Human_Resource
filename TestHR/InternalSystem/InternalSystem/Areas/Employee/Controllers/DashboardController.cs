using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.InternalHR.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "Member")]
    public class DashboardController : Controller
    {
        private readonly InternalSysDBContext _context;
        public DashboardController(InternalSysDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Socials);
        }
        public IActionResult IndexSec()
        {
            return View(_context.Socials);
        }

      


    }
}
