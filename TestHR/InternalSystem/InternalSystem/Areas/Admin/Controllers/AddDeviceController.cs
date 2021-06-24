using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.Devices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class AddDeviceController : Controller
    {
        private readonly InternalSysDBContext _context;
        public AddDeviceController(InternalSysDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.DevicesTypes.Where(d => d.Status != false).Take(5));
        }
        public IActionResult AllDevice()
        {
            return View(_context.DevicesTypes.Where(d => d.Status != false).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DevicesType type)
        {
            if (ModelState["Name"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }
            var devicetype = _context.DevicesTypes.Where(d => d.Name == type.Name && d.Status==true).FirstOrDefault();
            if (devicetype != null)
            {
                ModelState.AddModelError("Name", "Bu adda cihaz artıq mövcuddur");
                return View();
            }
            DevicesType newDevicesType = new DevicesType
            {
                Name = type.Name,
                Status = true
            };
            await _context.DevicesTypes.AddAsync(newDevicesType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AllDevice));
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var deviceTypeDb = await _context.DevicesTypes.FirstOrDefaultAsync(p => p.Id == id);
            if (deviceTypeDb == null) return NotFound();
            return View(deviceTypeDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, DevicesType type)
        {
            DevicesType devicesType = await _context.DevicesTypes.FindAsync(id);
            if (id == null) return NotFound();

            if (ModelState["Name"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            DevicesType checkDevType = _context.DevicesTypes.Where(d => d.Name == type.Name).FirstOrDefault();

            if (checkDevType != null)
            {
                ModelState.AddModelError("Name", "Bu adda cihaz artıq mövcuddur");
                return View();
            }

            devicesType.Name = type.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int? DeviceTypeId)
        {
            if (DeviceTypeId == null) return NotFound();
            DevicesType dpmt = _context.DevicesTypes.Find(DeviceTypeId);
            dpmt.Status = false;
            _context.Entry(dpmt).State = EntityState.Modified;
            _context.SaveChanges();
            var dev = _context.DevicesTypes.Where(d => d.Status != false).OrderByDescending(d => d.Id).ToList();
            return PartialView("~/Areas/Admin/Views/Shared/PartialView/_DeviceTypeDeletePartial.cshtml", dev);

        }

    }
}
