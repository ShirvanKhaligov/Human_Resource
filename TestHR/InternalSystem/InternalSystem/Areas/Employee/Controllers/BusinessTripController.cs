using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.BusinessTrip;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "HrDepartmentBoss")]
    public class BusinessTripController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;
        public BusinessTripController(InternalSysDBContext context, UserManager<AppUser> userManager, IHostingEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }
        public async Task<IActionResult> Create()
        {
            AppUser currentHR = await _userManager.FindByEmailAsync(User.Identity.Name);
            BusinessTripVM businessTripVM = new BusinessTripVM()
            {
                Emplooyees = _context.Emplooyeees.Where(d => d.Status == true && d.IsCandidate == false && d.IsWorking == true && d.PositionsId != null && d.CompanyId == currentHR.CompaniesId).ToList(),
                Districs = _context.Districs.Where(c => c.DistricName != null).OrderBy(c=>c.DistricName).ToList(),
                BusinessTripEmps=_context.BusinessTripEmps.Where(cx=>cx.Isdeleted==false).ToList()


            };
            return View(businessTripVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BusinessTripVM tripVM)
        {
            AppUser currenHr = await _userManager.FindByEmailAsync(User.Identity.Name);
            BusinessTripVM businessTripVM = new BusinessTripVM()
            {
                Emplooyees = _context.Emplooyeees.Where(d => d.Status == true
                && d.IsCandidate == false
                && d.IsWorking == true && d.PositionsId != null && d.CompanyId == currenHr.CompaniesId).ToList(),
                Districs = _context.Districs.Where(c => c.DistricName != null).ToList(),
            };

            if (ModelState["EmplooyeeId"].ValidationState != ModelValidationState.Invalid ||
                ModelState["FromDate"].ValidationState != ModelValidationState.Invalid ||
                ModelState["ToDate"].ValidationState != ModelValidationState.Invalid ||
                ModelState["Commet"].ValidationState != ModelValidationState.Invalid ||
                ModelState["PartnorName"].ValidationState != ModelValidationState.Invalid)
            {
                Emplooyee findEmp = _context.Emplooyeees.Where(e => e.Status != false
                && e.IsWorking != false
                && e.CompanyId == currenHr.CompaniesId
                && e.Id == tripVM.EmplooyeeId).FirstOrDefault();
                if (findEmp == null)
                {
                    return NotFound();
                }
                AppUser FindAspUser = await _userManager.FindByEmailAsync(findEmp.Email);
                //Distric distric = new Distric();

                BusinessTripEmp businessTripEmp = new BusinessTripEmp();
                businessTripEmp.EmplooyeeId = tripVM.EmplooyeeId;
                businessTripEmp.FromDate = tripVM.FromDate;
                businessTripEmp.ToDate = tripVM.ToDate;
                businessTripEmp.DistricId = tripVM.DistricId;
                businessTripEmp.Commet = tripVM.Commet;
                businessTripEmp.PartnorName = tripVM.PartnorName;
                businessTripEmp.CreaterUser = currenHr.Email;
                businessTripEmp.Isdeleted = false;
                businessTripEmp.Exectime = DateTime.Now;
                await _context.BusinessTripEmps.AddAsync(businessTripEmp);
                await _context.SaveChangesAsync();

            }


            return RedirectToAction(nameof(Create));

        }
       
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            BusinessTripEmp tripEmp = _context.BusinessTripEmps.FirstOrDefault(x => x.Id == id);
            if (tripEmp==null)
            {
                return NotFound();
            }
            return View(tripEmp);
        }


        [ActionName("Delete")]
        [HttpPost]
        public async Task<IActionResult> DeleteTripbus(int? id)
        {
            if (id == null) { return NotFound(); }
            BusinessTripEmp tripEmp = _context.BusinessTripEmps.FirstOrDefault(x => x.Id == id);
            if (tripEmp == null) { return NotFound(); }
            tripEmp.Isdeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create));
        }
        public IActionResult Index(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            BusinessTripEmp busitrip = _context.BusinessTripEmps.FirstOrDefault(x => x.Id == id);
            if (busitrip == null)
            {
                return NotFound();
            }

            return View(busitrip);
        }
    }
}
