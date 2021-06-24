using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.Devices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "DeviceResponsible")]
    public class EmployeeDeviceController : Controller
    {

        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        public EmployeeDeviceController(UserManager<AppUser> userManager, InternalSysDBContext context)
        {
            _userManager = userManager;
            _context = context;
        }



        public async Task<IActionResult> GetDeviceType(int? id)
        {
            if (id == null) return NotFound();
            AppUser currentAccountant = await _userManager.FindByEmailAsync(User.Identity.Name);
            //EmployeeDeviceVm deviceVM = new EmployeeDeviceVm
            //{
            //    DeviceToEmployees = _context.DeviceToEmployees.Where(d => d.Emplooyee.IsWorking != false && d.Emplooyee.Status != false && d.Device.DevicesType.Status != false && d.Emplooyee.CompanyId == currentAccountant.CompaniesId).ToList(),
            //    Emplooyees = _context.Emplooyeees.Where(e => e.IsWorking != false && e.Status != false && e.IsCandidate == false && e.CompanyId == currentAccountant.CompaniesId).ToList(),
            //    DevicesTypes = _context.DevicesTypes.Where(d => d.Status != false).ToList(),
            //};
            EmployeeDeviceVm deviceVM = new EmployeeDeviceVm();
            if (id == 1)
            {
                return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetNotebookDevicePartial.cshtml", deviceVM);
            }
            if (id == 2)
            {
                return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetMonitorDevicePartial.cshtml", deviceVM);
            }
            if (id == 3)
            {
                return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetMobPhoneDevicePartial.cshtml", deviceVM);
            }
            if (id == 4)
            {
                return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetMobPhoneNumberDevicePartial.cshtml", deviceVM);
            }
            if (id == 5)
            {
                return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetMouseDevicePartial.cshtml", deviceVM);
            }
            if (id == 6)
            {
                return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetPadDevicePartial.cshtml", deviceVM);
            }
            if (id == 8)
            {
                return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetIPPhoneDevicePartial.cshtml", deviceVM);
            }
            if (id == 9)
            {
                return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetHeadPhoneDevicePartial.cshtml", deviceVM);
            }
            if (id == 12)
            {
                return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetKeyboardDevicePartial.cshtml", deviceVM);
            }
            if (id == 11)
            {
                return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetMkrFlashDevicePartial.cshtml", deviceVM);
            }

            return View();
        }
        //menasiz taskdi ne ish gorecek .orda deyilirki bir kalkulyator servisi yazmalisan.+ - * / .bunu api ile yazmalisan.Interfeys sistemi ile.hemde loglamalidi.meselen
        //ne vaxt ne is goruldu.ele bil postman ile yoxlayacaq  bes onu kim tehvil verdi sen ya cavid.rabiteye?heri ikimizdenoldu bes axri
        //demeli postman ile yoxlaycaq .meselen + emeliyyati.orda add adinda metod yazirsan.api ile.json qaytairi.hemcininde - * /. daha sonra postman ile bunlari yoxlayanda 
        //200 qaytarmalidi.om momentde loglamalidi.bu vaxtda + metodu ise dusdu.saat necede.200 qayitdi yoxsa 400.bele bir seydi.istesen githubdan yukleyib baxaq baxaqda sozdu
        // birdeki bu behnam deyirki  tasklari trelloya qeyd ele ne qalib


        //public async IEnumerable<DeviceToEmployee> DistinctBy
        //public async Task<IActionResult> Create()
        //{
        //    AppUser currentAccountant = await _userManager.FindByEmailAsync(User.Identity.Name);


        //    var sp = _context.DeviceToEmployees.FromSql("EXECUTE  dbo.selectdiscdevices @companyId={0}", 1).ToList();

        //    EmployeeDeviceVm deviceVM = new EmployeeDeviceVm
        //    {
        //        DeviceToEmployeesList = _context.DeviceToEmployees.Where(d => d.Emplooyee.IsWorking != false && d.Emplooyee.Status != false && d.Device.DevicesType.Status != false && d.Emplooyee.CompanyId == currentAccountant.CompaniesId).GroupBy(g => g.EmplooyeeId).Select(x => x.FirstOrDefault()).ToList(),
        //        Emplooyees = _context.Emplooyeees.Where(e => e.IsWorking != false && e.Status != false && e.IsCandidate == false && e.CompanyId == currentAccountant.CompaniesId).ToList(),
        //        DevicesTypes = _context.DevicesTypes.Where(d => d.Status != false).ToList(),
        //        AdditionalEquipments = _context.AdditionalEquipments.ToList()

        //    };
        //    return View(deviceVM);

        //}



        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(EmployeeDeviceVm employeeDevice)
        //{
        //    AppUser currentAccountant = await _userManager.FindByEmailAsync(User.Identity.Name);
        //    EmployeeDeviceVm deviceVM = new EmployeeDeviceVm
        //    {
        //        DeviceToEmployees = _context.DeviceToEmployees.Where(d => d.Emplooyee.IsWorking != false && d.Emplooyee.Status != false && d.Device.DevicesType.Status != false && d.Emplooyee.CompanyId == currentAccountant.CompaniesId).ToList(),
        //        Emplooyees = _context.Emplooyeees.Where(e => e.IsWorking != false && e.Status != false && e.IsCandidate == false && e.CompanyId == currentAccountant.CompaniesId).ToList(),
        //        DevicesTypes = _context.DevicesTypes.Where(d => d.Status != false).ToList(),
        //    };

        //    if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid ||
        //        ModelState["DeviceTypeId"].ValidationState != ModelValidationState.Invalid ||
        //        ModelState["Device.Name"].ValidationState != ModelValidationState.Invalid ||
        //        ModelState["Device.GivingTime"].ValidationState != ModelValidationState.Invalid
        //        )
        //    {
        //        Device newwDevice = new Device
        //        {
        //            //Name = employeeDevice.Device.Name.Trim(),
        //            //Status = true,
        //            //GivingTime = employeeDevice.Device.GivingTime,
        //            //DevicesTypeId = employeeDevice.DeviceTypeId,
        //            //TimeOfExecution = DateTime.Now,
        //            //Parametr=employeeDevice.Device.Parametr,
        //            //SeriaNumber=employeeDevice.Device.SeriaNumber,

        //            //MouseCount=employeeDevice.Device.MouseCount,

        //            //HeadPhoneCount=employeeDevice.Device.HeadPhoneCount,
        //            //IpPhoneNumber=employeeDevice.Device.IpPhoneNumber
        //        };
        //        await _context.Devices.AddAsync(newwDevice);
        //        await _context.SaveChangesAsync();

        //        DeviceToEmployee newDeviceToEmployee = new DeviceToEmployee
        //        {
        //            DeviceId = newwDevice.Id,
        //            EmplooyeeId = employeeDevice.EmplooyeeId
        //        };
        //        await _context.DeviceToEmployees.AddAsync(newDeviceToEmployee);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Create));
        //    }
        //    return View(deviceVM);
        //}

        public async Task<IActionResult> Create()
        {
            AppUser currentAccountant = await _userManager.FindByEmailAsync(User.Identity.Name);
            //var sp = _context.DeviceToEmployees.FromSql("EXECUTE  dbo.selectdiscdevices @companyId={0}", currentAccountant.CompaniesId).ToList();
            EmployeeDeviceVm deviceVM = new EmployeeDeviceVm
            {
                //DeviceToEmployeesList = _context.DeviceToEmployees.Where(d => d.Emplooyee.IsWorking != false && d.Emplooyee.Status != false && d.Device.DevicesType.Status != false && d.Emplooyee.CompanyId == currentAccountant.CompaniesId).GroupBy(g => g.EmplooyeeId).Select(x => x.FirstOrDefault()).ToList(),
                DeviceToEmployees = _context.DeviceToEmployees.Where(d => d.Emplooyee.IsWorking != false && d.Emplooyee.Status != false && d.Device.DevicesType.Status != false && d.Emplooyee.CompanyId == currentAccountant.CompaniesId).Include(a=>a.Device).GroupBy(g => g.EmplooyeeId).Select(x => x.FirstOrDefault()).ToList(),
                Emplooyees = _context.Emplooyeees.Where(e => e.IsWorking != false && e.Status != false && e.IsCandidate == false && e.CompanyId == currentAccountant.CompaniesId).ToList(),
                DevicesTypes = _context.DevicesTypes.Where(d => d.Status != false).ToList(),
            };
            return View(deviceVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeDeviceVm employeeDevice)
        {
            AppUser currentAccountant = await _userManager.FindByEmailAsync(User.Identity.Name);
            EmployeeDeviceVm deviceVM = new EmployeeDeviceVm
            {
                DeviceToEmployees = _context.DeviceToEmployees.Where(d => d.Emplooyee.IsWorking != false && d.Emplooyee.Status != false && d.Device.DevicesType.Status != false && d.Emplooyee.CompanyId == currentAccountant.CompaniesId).Include(a=>a.Device).GroupBy(g => g.EmplooyeeId).Select(x => x.FirstOrDefault()).ToList(),
                Emplooyees = _context.Emplooyeees.Where(e => e.IsWorking != false && e.Status != false && e.IsCandidate == false && e.CompanyId == currentAccountant.CompaniesId).ToList(),
                DevicesTypes = _context.DevicesTypes.Where(d => d.Status != false).ToList(),
            };
            if (employeeDevice.Device.GivingTime == null)
            {
                ModelState.AddModelError("Device.GivingTime", "Zəhmət olmasa vaxtı qeyd edin");
                return View(deviceVM);
            }
            if (ModelState["EmplooyeeId"].ValidationState == ModelValidationState.Invalid ||
                ModelState["DeviceTypeId"].ValidationState == ModelValidationState.Invalid
                )
            {
                return View(deviceVM);
            }
            if (employeeDevice.DeviceTypeId == 1)
            {
                if (employeeDevice.Device.InventorCode == null ||
                   employeeDevice.Device.Parametr == null ||
                   employeeDevice.Device.SerialNumber == null
                )
                {
                    ViewData["DeviceNotebook"] = "Zəhmət olmasa notebook məlumalarını qeyd edin";
                    return View(deviceVM);
                }
                Device newNotebook = new Device
                {
                    InventorCode = employeeDevice.Device.InventorCode.Trim(),
                    Parametr = employeeDevice.Device.Parametr.Trim(),
                    SerialNumber = employeeDevice.Device.SerialNumber.Trim(),
                    Status = true,
                    GivingTime = employeeDevice.Device.GivingTime,
                    DevicesTypeId = employeeDevice.DeviceTypeId,
                    TimeOfExecution = DateTime.Now
                };
                await _context.Devices.AddAsync(newNotebook);
                await _context.SaveChangesAsync();

                DeviceToEmployee newDeviceToEmployee = new DeviceToEmployee
                {
                    DeviceId = newNotebook.Id,
                    EmplooyeeId = employeeDevice.EmplooyeeId
                };
                await _context.DeviceToEmployees.AddAsync(newDeviceToEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            if (employeeDevice.DeviceTypeId == 2)
            {
                if (employeeDevice.Device.InventorCode == null ||
                   employeeDevice.Device.Parametr == null ||
                   employeeDevice.Device.SerialNumber == null
                )
                {
                    ViewData["DeviceMonitor"] = "Zəhmət olmasa monitor məlumalarını qeyd edin";
                    return View(deviceVM);
                }
                Device newMonitor = new Device
                {
                    InventorCode = employeeDevice.Device.InventorCode.Trim(),
                    Parametr = employeeDevice.Device.Parametr.Trim(),
                    SerialNumber = employeeDevice.Device.SerialNumber.Trim(),
                    Status = true,
                    GivingTime = employeeDevice.Device.GivingTime,
                    DevicesTypeId = employeeDevice.DeviceTypeId,
                    TimeOfExecution = DateTime.Now
                };
                await _context.Devices.AddAsync(newMonitor);
                await _context.SaveChangesAsync();

                DeviceToEmployee newDeviceToEmployee = new DeviceToEmployee
                {
                    DeviceId = newMonitor.Id,
                    EmplooyeeId = employeeDevice.EmplooyeeId
                };
                await _context.DeviceToEmployees.AddAsync(newDeviceToEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            if (employeeDevice.DeviceTypeId == 3)
            {
                if (employeeDevice.Device.Parametr == null
                )
                {
                    ViewData["DevicePhone"] = "Zəhmət olmasa mobil telefon məlumalarını qeyd edin";
                    return View(deviceVM);
                }
                Device newMonitor = new Device
                {
                    Parametr = employeeDevice.Device.Parametr.Trim(),
                    Status = true,
                    GivingTime = employeeDevice.Device.GivingTime,
                    DevicesTypeId = employeeDevice.DeviceTypeId,
                    TimeOfExecution = DateTime.Now
                };
                await _context.Devices.AddAsync(newMonitor);
                await _context.SaveChangesAsync();

                DeviceToEmployee newDeviceToEmployee = new DeviceToEmployee
                {
                    DeviceId = newMonitor.Id,
                    EmplooyeeId = employeeDevice.EmplooyeeId
                };
                await _context.DeviceToEmployees.AddAsync(newDeviceToEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            if (employeeDevice.DeviceTypeId == 4)
            {
                if (employeeDevice.Device.PhoneNumber == null)
                {
                    ViewData["DevicePhoneNumber"] = "Zəhmət olmasa mobil nömrəni qeyd edin";
                    return View(deviceVM);
                }
                Device newMonitor = new Device
                {
                    PhoneNumber = employeeDevice.Device.PhoneNumber.Trim(),
                    Status = true,
                    GivingTime = employeeDevice.Device.GivingTime,
                    DevicesTypeId = employeeDevice.DeviceTypeId,
                    TimeOfExecution = DateTime.Now
                };
                await _context.Devices.AddAsync(newMonitor);
                await _context.SaveChangesAsync();

                DeviceToEmployee newDeviceToEmployee = new DeviceToEmployee
                {
                    DeviceId = newMonitor.Id,
                    EmplooyeeId = employeeDevice.EmplooyeeId
                };
                await _context.DeviceToEmployees.AddAsync(newDeviceToEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            if (employeeDevice.DeviceTypeId == 5)
            {
                if (employeeDevice.Device.Count == null)
                {
                    ViewData["DeviceMouse"] = "Zəhmət olmasa mouse sayını qeyd edin";
                    return View(deviceVM);
                }
                Device newMonitor = new Device
                {
                    Count = employeeDevice.Device.Count,
                    Status = true,
                    GivingTime = employeeDevice.Device.GivingTime,
                    DevicesTypeId = employeeDevice.DeviceTypeId,
                    TimeOfExecution = DateTime.Now
                };
                await _context.Devices.AddAsync(newMonitor);
                await _context.SaveChangesAsync();

                DeviceToEmployee newDeviceToEmployee = new DeviceToEmployee
                {
                    DeviceId = newMonitor.Id,
                    EmplooyeeId = employeeDevice.EmplooyeeId
                };
                await _context.DeviceToEmployees.AddAsync(newDeviceToEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));

            }
            if (employeeDevice.DeviceTypeId == 6)
            {
                if (employeeDevice.Device.Count == null)
                {
                    ViewData["DevicePad"] = "Zəhmət olmasa pad sayını qeyd edin";
                    return View(deviceVM);
                }
                Device newMonitor = new Device
                {
                    Count = employeeDevice.Device.Count,
                    Status = true,
                    GivingTime = employeeDevice.Device.GivingTime,
                    DevicesTypeId = employeeDevice.DeviceTypeId,
                    TimeOfExecution = DateTime.Now
                };
                await _context.Devices.AddAsync(newMonitor);
                await _context.SaveChangesAsync();

                DeviceToEmployee newDeviceToEmployee = new DeviceToEmployee
                {
                    DeviceId = newMonitor.Id,
                    EmplooyeeId = employeeDevice.EmplooyeeId
                };
                await _context.DeviceToEmployees.AddAsync(newDeviceToEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));

            }
            if (employeeDevice.DeviceTypeId == 8)
            {
                if (employeeDevice.Device.InternalPhoneNumber == null ||
                    employeeDevice.Device.Count == null)
                {
                    ViewData["DeviceIPPhone"] = "Zəhmət olmasa IP telefonu qeyd edin";
                    return View(deviceVM);
                }
                Device newMonitor = new Device
                {
                    InternalPhoneNumber = employeeDevice.Device.InternalPhoneNumber,
                    Count = employeeDevice.Device.Count,
                    Status = true,
                    GivingTime = employeeDevice.Device.GivingTime,
                    DevicesTypeId = employeeDevice.DeviceTypeId,
                    TimeOfExecution = DateTime.Now
                };
                await _context.Devices.AddAsync(newMonitor);
                await _context.SaveChangesAsync();

                DeviceToEmployee newDeviceToEmployee = new DeviceToEmployee
                {
                    DeviceId = newMonitor.Id,
                    EmplooyeeId = employeeDevice.EmplooyeeId
                };
                await _context.DeviceToEmployees.AddAsync(newDeviceToEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));

            }
            if (employeeDevice.DeviceTypeId == 9)
            {
                if (employeeDevice.Device.Count == null)
                {
                    ViewData["DeviceHeadPhone"] = "Zəhmət olmasa qulaqlıq sayını qeyd edin";
                    return View(deviceVM);
                }
                Device newMonitor = new Device
                {
                    Count = employeeDevice.Device.Count,
                    Status = true,
                    GivingTime = employeeDevice.Device.GivingTime,
                    DevicesTypeId = employeeDevice.DeviceTypeId,
                    TimeOfExecution = DateTime.Now
                };
                await _context.Devices.AddAsync(newMonitor);
                await _context.SaveChangesAsync();

                DeviceToEmployee newDeviceToEmployee = new DeviceToEmployee
                {
                    DeviceId = newMonitor.Id,
                    EmplooyeeId = employeeDevice.EmplooyeeId
                };
                await _context.DeviceToEmployees.AddAsync(newDeviceToEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));

            }
            if (employeeDevice.DeviceTypeId == 10)
            {
                if (employeeDevice.Device.Count == null)
                {
                    ViewData["DeviceKeyboard"] = "Zəhmət olmasa klaviatura sayını qeyd edin";
                    return View(deviceVM);
                }
                Device newMonitor = new Device
                {
                    Count = employeeDevice.Device.Count,
                    Status = true,
                    GivingTime = employeeDevice.Device.GivingTime,
                    DevicesTypeId = employeeDevice.DeviceTypeId,
                    TimeOfExecution = DateTime.Now
                };
                await _context.Devices.AddAsync(newMonitor);
                await _context.SaveChangesAsync();

                DeviceToEmployee newDeviceToEmployee = new DeviceToEmployee
                {
                    DeviceId = newMonitor.Id,
                    EmplooyeeId = employeeDevice.EmplooyeeId
                };
                await _context.DeviceToEmployees.AddAsync(newDeviceToEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));

            }
            if (employeeDevice.DeviceTypeId == 11)
            {
                if (employeeDevice.Device.Count == null)
                {
                    ViewData["DeviceMkrFlash"] = "Zəhmət olmasa flash kart sayını qeyd edin";
                    return View(deviceVM);
                }
                Device newMonitor = new Device
                {
                    Parametr = employeeDevice.Device.Parametr.Trim(),
                    Count = employeeDevice.Device.Count,
                    Status = true,
                    GivingTime = employeeDevice.Device.GivingTime,
                    DevicesTypeId = employeeDevice.DeviceTypeId,
                    TimeOfExecution = DateTime.Now
                };
                await _context.Devices.AddAsync(newMonitor);
                await _context.SaveChangesAsync();

                DeviceToEmployee newDeviceToEmployee = new DeviceToEmployee
                {
                    DeviceId = newMonitor.Id,
                    EmplooyeeId = employeeDevice.EmplooyeeId
                };
                await _context.DeviceToEmployees.AddAsync(newDeviceToEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));

            }
            return View(deviceVM);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            AppUser currentAccountant = await _userManager.FindByEmailAsync(User.Identity.Name);
            //var editEmpDevice = await _context.DeviceToEmployees.FindAsync(id);

            EmployeeDeviceVm deviceVm = new EmployeeDeviceVm()
            {
                DeviceToEmployee = await _context.DeviceToEmployees.FindAsync(id),
                DevicesTypes = _context.DevicesTypes.ToList()
            };
            if (deviceVm == null) return NotFound();
            return View(deviceVm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, EmployeeDeviceVm deviceVm)
        {
            if (id == null) return NotFound();
            EmployeeDeviceVm deviceVM = new EmployeeDeviceVm()
            {
                DeviceToEmployee = await _context.DeviceToEmployees.FindAsync(id),
                DevicesTypes = _context.DevicesTypes.ToList()
            };
            if (ModelState["DeviceTypeId"].ValidationState != ModelValidationState.Invalid)
            {
                if (deviceVm.Device.GivingTime == null)
                {
                    return View(deviceVM);
                }
                deviceVM.DeviceToEmployee.Device.GivingTime = deviceVm.Device.GivingTime;
                if (deviceVm.DeviceTypeId == 1 || deviceVm.DeviceTypeId == 2)
                {
                    if (deviceVm.DeviceToEmployee.Device.InventorCode == null ||
                        deviceVm.DeviceToEmployee.Device.Parametr == null ||
                        deviceVm.DeviceToEmployee.Device.SerialNumber == null
                        )
                    {
                        ViewData["DeviceNotebook"] = "Zəhmət olmasa notebook məlumalarını qeyd edin";
                        return View(deviceVM);
                    }
                    deviceVM.DeviceToEmployee.Device.InventorCode = deviceVm.DeviceToEmployee.Device.InventorCode.Trim();
                    deviceVM.DeviceToEmployee.Device.Parametr = deviceVm.DeviceToEmployee.Device.Parametr.Trim();
                    deviceVM.DeviceToEmployee.Device.SerialNumber = deviceVm.DeviceToEmployee.Device.SerialNumber.Trim();
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Detail", new { id = deviceVM.DeviceToEmployee.EmplooyeeId });
                }
                if (deviceVm.DeviceTypeId == 3)
                {
                    if (deviceVm.DeviceToEmployee.Device.Parametr == null
                )
                    {
                        ViewData["DevicePhone"] = "Zəhmət olmasa mobil telefon məlumalarını qeyd edin";
                        return View(deviceVM);
                    }
                    deviceVM.DeviceToEmployee.Device.Parametr = deviceVm.DeviceToEmployee.Device.Parametr.Trim();
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Detail", new { id = deviceVM.DeviceToEmployee.EmplooyeeId });
                }
                if (deviceVm.DeviceTypeId == 4)
                {
                    if (deviceVm.DeviceToEmployee.Device.PhoneNumber == null)
                    {
                        ViewData["DevicePhoneNumber"] = "Zəhmət olmasa mobil nömrəni qeyd edin";
                        return View(deviceVM);
                    }
                    deviceVM.DeviceToEmployee.Device.PhoneNumber = deviceVm.DeviceToEmployee.Device.PhoneNumber.Trim();
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Detail", new { id = deviceVM.DeviceToEmployee.EmplooyeeId });
                }
                if (deviceVm.DeviceTypeId == 5)
                {
                    if (deviceVM.DeviceToEmployee.Device.Count == null)
                    {
                        ViewData["DeviceMouse"] = "Zəhmət olmasa mouse sayını qeyd edin";
                        return View(deviceVM);
                    }
                    deviceVM.DeviceToEmployee.Device.Count = deviceVm.DeviceToEmployee.Device.Count;
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Detail", new { id = deviceVM.DeviceToEmployee.EmplooyeeId });
                }
                if (deviceVm.DeviceTypeId == 6)
                {
                    if (deviceVM.DeviceToEmployee.Device.Count == null)
                    {
                        ViewData["DevicePad"] = "Zəhmət olmasa pad sayını qeyd edin";
                        return View(deviceVM);
                    }
                    deviceVM.DeviceToEmployee.Device.Count = deviceVm.DeviceToEmployee.Device.Count;
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Detail", new { id = deviceVM.DeviceToEmployee.EmplooyeeId });
                }
                if (deviceVm.DeviceTypeId == 8)
                {
                    if (deviceVM.DeviceToEmployee.Device.InternalPhoneNumber == null ||
                        deviceVM.DeviceToEmployee.Device.Count == null)
                    {
                        ViewData["DeviceIPPhone"] = "Zəhmət olmasa IP telefonu qeyd edin";
                        return View(deviceVM);
                    }
                    deviceVM.DeviceToEmployee.Device.InternalPhoneNumber = deviceVm.DeviceToEmployee.Device.InternalPhoneNumber.Trim();
                    deviceVM.DeviceToEmployee.Device.Count = deviceVm.DeviceToEmployee.Device.Count;
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Detail", new { id = deviceVM.DeviceToEmployee.EmplooyeeId });
                }
                if (deviceVm.DeviceTypeId == 9)
                {
                    if (deviceVM.DeviceToEmployee.Device.Count == null)
                    {
                        ViewData["DeviceHeadPhone"] = "Zəhmət olmasa qulaqlıq sayını qeyd edin";
                        return View(deviceVM);
                    }
                    deviceVM.DeviceToEmployee.Device.Count = deviceVm.DeviceToEmployee.Device.Count;
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Detail", new { id = deviceVM.DeviceToEmployee.EmplooyeeId });
                }
                if (deviceVm.DeviceTypeId == 10)
                {
                    if (deviceVM.DeviceToEmployee.Device.Count == null)
                    {
                        ViewData["DeviceKeyboard"] = "Zəhmət olmasa klaviatura sayını qeyd edin";
                        return View(deviceVM);
                    }
                    deviceVM.DeviceToEmployee.Device.Count = deviceVm.DeviceToEmployee.Device.Count;
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Detail", new { id = deviceVM.DeviceToEmployee.EmplooyeeId });
                }
                if (deviceVm.DeviceTypeId == 11)
                {
                    if (deviceVM.DeviceToEmployee.Device.Count == null)
                    {
                        ViewData["DeviceMkrFlash"] = "Zəhmət olmasa flash kart sayını qeyd edin";
                        return View(deviceVM);
                    }
                    deviceVM.DeviceToEmployee.Device.Count = deviceVm.DeviceToEmployee.Device.Count;
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Detail", new { id = deviceVM.DeviceToEmployee.EmplooyeeId });
                }

                return View(deviceVM);
            }
            return View(deviceVM);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? DeviceId, DateTime returnD, string reason,int EmpId)
        {
            if (DeviceId == null) return NotFound();
            DeviceToEmployee deviceToEmp = _context.DeviceToEmployees.Where(d=>d.DeviceId==DeviceId).FirstOrDefault();
            if (deviceToEmp == null) return NotFound();
            if (returnD.Year < 2000)
            {
                ViewData["error_time_device"] = "Zəhmət olmasa vaxtı qeyd edin";
                return View();
            }
            if (reason == null)
            {
                ViewData["error_reason_device"] = "Zəhmət olmasa səbəbi qeyd edin";
                return View();
            }
            deviceToEmp.Device.Status = false;
            deviceToEmp.Device.ReturnDate = returnD;
            deviceToEmp.Device.Reason = reason;
            _context.Entry(deviceToEmp).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            AppUser currentDeviceRespon = await _userManager.FindByEmailAsync(User.Identity.Name);
            EmployeeDeviceVm vM = new EmployeeDeviceVm
            {
                DeviceToEmployees = _context.DeviceToEmployees.Where(d => d.Emplooyee.Status != false && d.Emplooyee.CompanyId==currentDeviceRespon.CompaniesId && d.EmplooyeeId==EmpId && d.Emplooyee.IsWorking != false && d.Emplooyee.IsCandidate == false && d.Device.DevicesType.Status != false),
                //Emplooyees = _context.Emplooyeees.Where(e => e.IsWorking != false && e.Status != false && e.CompanyId == currentDeviceRespon.CompaniesId).ToList(),
                DevicesTypes = _context.DevicesTypes.Where(d => d.Status != false).ToList(),

            };
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_EmployeeDeviceDeletePartial.cshtml", vM);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            AppUser currentAccountant = await _userManager.FindByEmailAsync(User.Identity.Name);
            EmployeeDeviceVm detailDeviceVm = new EmployeeDeviceVm()
            {
                DeviceToEmployees = _context.DeviceToEmployees.Where(c => c.Emplooyee.IsCandidate == false
                 && c.Emplooyee.Status == true
                 //&& c.Device.DevicesType.Status == true
                 && c.Emplooyee.CompanyId == currentAccountant.CompaniesId
                 //&& c.Id == id
                 && c.EmplooyeeId == id).Include(a=>a.Device.DevicesType).ToList(),
                DeviceToEmployeesStatusFalse = _context.DeviceToEmployees.Where(c => c.Emplooyee.IsCandidate == false
                   && c.Emplooyee.Status == true
                   && c.Device.Status == false
                   && c.Emplooyee.CompanyId == currentAccountant.CompaniesId
                   && c.EmplooyeeId == id).Include(a => a.Device).Include(b => b.Device.DevicesType).ToList()
            };
            return View(detailDeviceVm);
        }

    }
}
