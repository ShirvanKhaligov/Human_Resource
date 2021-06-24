using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.Devices;
using InternalSystem.Areas.InternalHR.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.InternalHR.Controllers
{
    [Area("InternalHR")]
    [Authorize(Roles = "HumanResource,HrDepartmentBoss")]
    public class EmployeeDeviceController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        public EmployeeDeviceController(UserManager<AppUser> userManager,InternalSysDBContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            
            AppUser appUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            EmployeeDeviceVm vM = new EmployeeDeviceVm
            {
                DeviceToEmployees=_context.DeviceToEmployees.Where(d=>d.Emplooyee.Status!=false && d.Emplooyee.IsWorking!=false&&d.Device.DevicesType.Status!=false && d.Device.Status != false&&d.Emplooyee.CompanyId==appUser.CompaniesId).Take(50),
                Emplooyees = _context.Emplooyeees.Where(e => e.IsWorking != false && e.Status != false).ToList(),
                DevicesTypes=_context.DevicesTypes.Where(d=>d.Status!=false).ToList(),
                Positions = _context.Positions.Where(p => p.Status != false)
            };
            return View(vM);
        }

        public IActionResult AllEmpDevice()
        {
           
            EmployeeDeviceVm vM = new EmployeeDeviceVm
            {
                DeviceToEmployees = _context.DeviceToEmployees.Where(d => d.Emplooyee.IsWorking != false && d.Device.DevicesType.Status != false),
                Emplooyees = _context.Emplooyeees.Where(e => e.IsWorking != false && e.Status != false).ToList(),
                DevicesTypes = _context.DevicesTypes.Where(d => d.Status != false).ToList(),
                Positions = _context.Positions.Where(p => p.Status != false)

            };
            return View(vM);
        }

        public async Task<IActionResult> Create()
        {
            AppUser currentHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            
            EmployeeDeviceVm vM = new EmployeeDeviceVm
            {
                DeviceToEmployees = _context.DeviceToEmployees.Where(d => d.Emplooyee.IsWorking != false && d.Device.DevicesType.Status != false && d.Device.Status != false),
                Emplooyees = _context.Emplooyeees.Where(e => e.IsWorking != false && e.Status != false&&e.CompanyId== currentHR.CompaniesId).ToList(),
                DevicesTypes = _context.DevicesTypes.Where(d => d.Status != false).ToList(),
            };
            return View(vM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeDeviceVm vm,int? employe, int? devType)
        {
            AppUser currentHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            EmployeeDeviceVm vM = new EmployeeDeviceVm
            {
                DeviceToEmployees = _context.DeviceToEmployees.Where(d => d.Emplooyee.IsWorking != false && d.Device.DevicesType.Status != false && d.Device.Status != false),
                Emplooyees = _context.Emplooyeees.Where(e => e.IsWorking != false && e.Status != false && e.CompanyId == currentHR.CompaniesId).ToList(),
                DevicesTypes = _context.DevicesTypes.Where(d => d.Status != false).ToList(),
            };
       
            if (employe == 0 || employe == null)
            {
                ViewData["error_empId"] = "Zəhmət olmasa işçini daxil edin";
                return View(vM);
            }
            if (devType == 0 || devType == null)
            {
                ViewData["error_devId"] = "Zəhmət olmasa qurğunu daxil edin";
                return View(vM);
            }
            if (ModelState["Device.Name"].ValidationState == ModelValidationState.Invalid)
            {
                return View(vM);
            }
            if (vm.GivingTime.Year < 2000)
            {
                ViewData["error_date"] = "Zəhmət olmasa xananı boş buraxmayın";
                return View(vM);
            }
            //var checkDb = _context.DeviceToEmployees.Where(d => d.Device.Name == vm.Device.Name&&d.Device.Status!=false).FirstOrDefault();
            //if (checkDb!=null)
            //{
            //    ViewData["error_exist"] = "Bu adda artıq qurğu mövcuddur";
            //    return View(vM);
            //}
            Device newwDevice = new Device
            {
                //Name = vm.Device.Name.Trim(),
                GivingTime = vm.GivingTime,
                DevicesTypeId = devType,
                Status=true,
            };
            await _context.Devices.AddAsync(newwDevice);
            await _context.SaveChangesAsync();
            DeviceToEmployee newDeviceToEmployee = new DeviceToEmployee
            {
                DeviceId = newwDevice.Id,
                EmplooyeeId = employe
            };
            await _context.DeviceToEmployees.AddAsync(newDeviceToEmployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            

            if (Id == null) return NotFound();
            var devEmpDb = await _context.DeviceToEmployees.FindAsync(Id);
            if (devEmpDb == null) return NotFound();
            AppUser currentHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            EmployeeDeviceVm vM = new EmployeeDeviceVm
            {
                DeviceToEmployee = _context.DeviceToEmployees.Where(d => d.Emplooyee.IsWorking != false &&d.Id==Id).FirstOrDefault(),
                Emplooyees = _context.Emplooyeees.Where(e => e.IsWorking != false && e.Status != false && e.CompanyId == currentHR.CompaniesId).ToList(),
                DevicesTypes = _context.DevicesTypes.Where(d => d.Status != false).ToList(),
            };
            return View(vM);
        }

        //[HttpPost]
        //public async Task<IActionResult> Edit(EmployeeDeviceVm vm, int? devType,int? id)
        //{
        //    if (id == null) return NotFound();
        //    var db = await _context.DeviceToEmployees.FindAsync(id);
        //    if (db == null) return NotFound();
        //    AppUser currentHR = await _userManager.FindByEmailAsync(User.Identity.Name);
        //    EmployeeDeviceVm vM = new EmployeeDeviceVm
        //    {
        //        DeviceToEmployee = _context.DeviceToEmployees.Where(d => d.Emplooyee.IsWorking != false &&
        //                                                              d.Id == id).FirstOrDefault(),
        //        Emplooyees = _context.Emplooyeees.Where(e => e.IsWorking != false && e.Status != false && e.CompanyId == currentHR.CompaniesId).ToList(),
        //        DevicesTypes = _context.DevicesTypes.Where(d => d.Status != false).ToList(),
        //    };

        //    if (devType == 0 || devType == null)
        //    {
        //        ViewData["error_devId"] = "Zəhmət olmasa qurğunu daxil edin";
        //        return View(vM);
        //    }
        //    if (ModelState["DeviceToEmployee.Device.Name"].ValidationState == ModelValidationState.Invalid)
        //    {
        //        return View(vM);
        //    }
        //    //var a = db.Device.GivingTime;
        //    //if (vm.GivingTime.Year < 2000)
        //    //{
        //    //    var checkDb = _context.DeviceToEmployees.Where(d => d.EmplooyeeId == db.Emplooyee.Id && d.Device.GivingTime == vm.GivingTime && d.Device.DevicesTypeId == devType || d.Device.Name == vm.DeviceToEmployee.Device.Name).FirstOrDefault();
        //    //    if (checkDb != null)
        //    //    {
        //    //        ViewData["error_check"] = "Bu adda artıq qurğu var.Zəhmət olmasa yenidən daxil edin";
        //    //        return View(vM);
        //    //    }
        //    //   // db.Device.Name = vm.DeviceToEmployee.Device.Name.Trim();
        //    //    db.Device.GivingTime = a;
        //    //    db.Device.DevicesTypeId = devType;
        //    //    await _context.SaveChangesAsync();
        //    //    return RedirectToAction(nameof(Index));
        //    //}
        //    //else
        //    //{
        //    //    var checkDb = _context.DeviceToEmployees.Where(d => d.EmplooyeeId == db.Emplooyee.Id && d.Device.GivingTime == vm.GivingTime && d.Device.DevicesTypeId == devType && d.Device.Name == vm.DeviceToEmployee.Device.Name).FirstOrDefault();
        //    //    if (checkDb != null)
        //    //    {
        //    //        ViewData["error_check"] = "Bu adda artıq qurğu var.Zəhmət olmasa yenidən daxil edin";
        //    //        return View(vM);
        //    //    }
        //    //   // db.Device.Name = vm.DeviceToEmployee.Device.Name.Trim();
        //    //    db.Device.GivingTime = vm.GivingTime;
        //    //    db.Device.DevicesTypeId = devType;
        //    //    await _context.SaveChangesAsync();
        //    //    return RedirectToAction(nameof(Index));
        //    //}
        //}

        [HttpPost]
        public async Task<IActionResult> Delete(int? DeviceId)
        {
            DeviceToEmployee deviceTo = _context.DeviceToEmployees.Find(DeviceId);
            deviceTo.Device.Status = false;
            deviceTo.Device.ReturnDate = DateTime.Now;
            _context.Entry(deviceTo).State = EntityState.Modified;
            _context.SaveChanges();
            AppUser currentHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            EmployeeDeviceVm vM = new EmployeeDeviceVm
            {
                DeviceToEmployees = _context.DeviceToEmployees.Where(d => d.Emplooyee.IsWorking != false && d.Device.DevicesType.Status != false),
                Emplooyees = _context.Emplooyeees.Where(e => e.IsWorking != false && e.Status != false && e.CompanyId == currentHR.CompaniesId).ToList(),
                DevicesTypes = _context.DevicesTypes.Where(d => d.Status != false).ToList(),
                Positions = _context.Positions.Where(p => p.Status != false)

            };
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_EmployeeDeviceDeletePartial.cshtml", vM);
        }

    }
}
