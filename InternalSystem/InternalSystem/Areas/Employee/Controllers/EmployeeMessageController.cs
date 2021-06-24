using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "Member")]
    public class EmployeeMessageController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;

        public EmployeeMessageController(UserManager<AppUser> userManager, InternalSysDBContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.MessageForEmployees.Where(m => m.Status == true).OrderByDescending(m => m.TimeExecution).ToList());
        }

        public async Task<IActionResult> Detail(int? id)
        {
            AppUser user = await _userManager.FindByEmailAsync(User.Identity.Name);
            MessageForEmployeeVM employeeVM = new MessageForEmployeeVM()
            {
                MessageForEmployee = await _context.MessageForEmployees.FindAsync(id),
                Emplooyee = _context.Emplooyeees.Where(e => e.Email == user.Email && e.Status != false && e.IsWorking != false && e.IsCandidate == false).FirstOrDefault(),
            };
            if (id == null) return NotFound();
            if (employeeVM == null) return NotFound();
            return View(employeeVM);
        }

    }
}
