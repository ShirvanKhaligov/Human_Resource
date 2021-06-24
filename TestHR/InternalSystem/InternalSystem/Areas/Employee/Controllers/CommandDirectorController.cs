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
    public class CommandDirectorController : Controller
    {


        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public CommandDirectorController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, InternalSysDBContext context)
        {
            _userManager = userManager;
            _context = context;
            _roleManager = roleManager;
        }



        public IActionResult GetScanPdf(int? empId)
        {
            if (empId == null) return NotFound();

            CommandEmployeeVM scanVM = new CommandEmployeeVM()
            {
                Emplooyee = _context.Emplooyeees.Where(w => w.Status != false && w.IsCandidate == false && w.Id == empId).FirstOrDefault(),
            };
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetScanPdfToEmployee.cshtml", scanVM);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
