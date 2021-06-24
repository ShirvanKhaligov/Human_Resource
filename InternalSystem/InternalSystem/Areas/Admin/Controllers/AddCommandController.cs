using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.Commands;
using InternalSystem.Areas.InternalHR.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class AddCommandController : Controller
    {
        private readonly InternalSysDBContext _context;
        public AddCommandController(InternalSysDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            AllModelVM allModelVM = new AllModelVM()
            {
                Commands = _context.Commands.Where(c => c.Status != false).OrderByDescending(c => c.Id).Take(5)
            };
            return View(allModelVM);
        }

        public IActionResult AllComand()
        {
            AllModelVM allModelVM = new AllModelVM()
            {
                Commands = _context.Commands.Where(c => c.Status != false).OrderByDescending(c => c.Id)
            };
            return View(allModelVM);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Commands command)
        {
            if (ModelState["Name"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Title"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Description"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            Commands commandd = _context.Commands.Where(c => c.Name == command.Name && c.Status != false).FirstOrDefault();
            if (commandd != null)
            {
                ViewData["error_exist"] = "Bu adda əmr artıq mövcuddur";
                return View();
            }

            command.Status = true;
            await _context.Commands.AddAsync(command);
            await _context.SaveChangesAsync();
            TempData["success_message"] = "Yeni əmr uğurla əlavə olundu";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Commands command = await _context.Commands.FindAsync(id);
            if (command == null) return NotFound();
            return View(command);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Commands cmd)
        {
            Commands cmddb = await _context.Commands.FindAsync(id);

            if (cmddb == null)
            {

                return RedirectToAction(nameof(Index));

            }

            if (ModelState["Name"].ValidationState == ModelValidationState.Invalid)
            {
                ViewData["error_null"] = "Xananı boş buraxmayın";
                return View();
            }

            Commands commandd = _context.Commands.Where(c => c.Name == cmd.Name && c.Status != false).FirstOrDefault();
            if (commandd != null)
            {
                ViewData["error_exist"] = "Bu adda əmr artıq mövcuddur";
                return View();
            }
            cmddb.Name = cmd.Name;
            cmddb.Title = cmd.Title;
            cmddb.Description = cmd.Description;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int? ComandId)
        {
            Commands cmd = _context.Commands.Find(ComandId);
            cmd.Status = false;
            _context.Entry(cmd).State = EntityState.Modified;
            _context.SaveChanges();
            AllModelVM allModelVM = new AllModelVM()
            {
                Commands = _context.Commands.Where(w => w.Status != false).ToList().OrderByDescending(w => w.Name)
            };
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_CommanPartial.cshtml", allModelVM);
        }

    }
}
