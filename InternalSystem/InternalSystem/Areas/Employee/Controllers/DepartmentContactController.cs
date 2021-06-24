using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.Employee.ViewModels;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.Models.Departments;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.Employee.Controllers
{

    [Area("Employee")]
    [Authorize(Roles = "Member")]
    public class DepartmentContactController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        //private readonly SignInManager<AppUser> _signInManager;
        //private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailsender;
        public DepartmentContactController(IEmailSender emailSender, InternalSysDBContext context, UserManager<AppUser> userManager/*, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager*/)
        {

            _context = context;
            _userManager = userManager;
            //_signInManager = signInManager;
            //_roleManager = roleManager;
            _emailsender = emailSender;
        }
        [HttpGet]
        public async Task<IActionResult> SentMessage()
        {
            AppUser findCurrentDepBoss = await _userManager.FindByEmailAsync(User.Identity.Name);
            DepContactVM depContactVM = new DepContactVM()
            {
                //DepartmentBosses = _context.Emplooyeees.Where(w => w.IsWorking != false && w.Status != false && w.Positions.SubDepartment.DepartmentToCompany.MenegerId == w.Id
                //&& w.CompanyId == findCurrentDepBoss.CompaniesId).ToList(),
                DepartmentBoss = _context.DepartmentToCompanies.Where(w => w.Meneger.IsWorking != false && w.Meneger.Status != false && w.MenegerId != null
              && w.CompanyId == findCurrentDepBoss.CompaniesId).ToList(),
            };
            return View(depContactVM);
        }
        [HttpPost]
        public async Task<IActionResult> SentMessage(DepContactVM depContactVM)
        {
            if (ModelState["DepBossId"].ValidationState != ModelValidationState.Invalid
                && ModelState["Subject"].ValidationState != ModelValidationState.Invalid
                && ModelState["Message"].ValidationState != ModelValidationState.Invalid)
            {
                AppUser findCurrentDepBoss = await _userManager.FindByEmailAsync(User.Identity.Name);
                Emplooyee ToEmp = _context.Emplooyeees.Where(w => w.Status != false && w.IsWorking != false && w.Id == depContactVM.DepBossId).FirstOrDefault();
                ContactBetweenDepartmentsSent sentMessage = new ContactBetweenDepartmentsSent
                {
                    From = findCurrentDepBoss.Emplooyee.Email,
                    To = ToEmp.Email,
                    CreatedDate = DateTime.Now,
                    Subject = depContactVM.Subject,
                    Message = depContactVM.Message,
                    Status = true,
                    isRead = false,
                };
                ContactBetweenDepartmentsInbox InboxMessage = new ContactBetweenDepartmentsInbox
                {
                    From = findCurrentDepBoss.Emplooyee.Email,
                    To = ToEmp.Email,
                    CreatedDate = DateTime.Now,
                    Subject = depContactVM.Subject,
                    Message = depContactVM.Message,
                    Status = true,
                    isRead = false,

                };
                await _context.ContactBetweenDepartmentsSent.AddAsync(sentMessage);
                await _context.ContactBetweenDepartmentsInbox.AddAsync(InboxMessage);
                await _context.SaveChangesAsync();
                await _emailsender.SendEmailAsync(ToEmp.Email, depContactVM.Subject,
                    $"Kimdən: " + findCurrentDepBoss.Emplooyee.FirstName + " " + findCurrentDepBoss.Emplooyee.Lastname +
                    $"<br/>Mesaj: " + depContactVM.Message
                    );
            }

            return RedirectToAction(nameof(SentMessage));
        }
        public async Task<IActionResult> SentedMessage()
        {
            AppUser findCurrentDepBoss = await _userManager.FindByEmailAsync(User.Identity.Name);
            IEnumerable<ContactBetweenDepartmentsSent> sendedMessage = _context.ContactBetweenDepartmentsSent.Where(w => w.Status != false && w.From == findCurrentDepBoss.Emplooyee.Email).OrderByDescending(w=>w.CreatedDate).ToList();
            return View(sendedMessage);
        }
        public async Task<IActionResult> Inbox()
        {
            AppUser findCurrentDepBoss = await _userManager.FindByEmailAsync(User.Identity.Name);
            IEnumerable<ContactBetweenDepartmentsInbox> inboxes = _context.ContactBetweenDepartmentsInbox.Where(w => w.Status != false && w.To == findCurrentDepBoss.Emplooyee.Email).OrderByDescending(w => w.CreatedDate).ToList();
            return View(inboxes);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteMsjFromInbox(int msjId)
        {
            AppUser findCurrentDepBoss = await _userManager.FindByEmailAsync(User.Identity.Name);
            ContactBetweenDepartmentsInbox findMsj = _context.ContactBetweenDepartmentsInbox.Where(w => w.Status != false && w.Id == msjId).FirstOrDefault();
            findMsj.Status = false;
            _context.Entry(findMsj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            IEnumerable<ContactBetweenDepartmentsInbox> inboxes = _context.ContactBetweenDepartmentsInbox.Where(w => w.Status != false && w.To == findCurrentDepBoss.Emplooyee.Email).OrderByDescending(w => w.CreatedDate).ToList();
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_inboxMessagePartial.cshtml", inboxes);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteMsjFromSended(int msjId)
        {
            AppUser findCurrentDepBoss = await _userManager.FindByEmailAsync(User.Identity.Name);
            ContactBetweenDepartmentsSent findMsj = _context.ContactBetweenDepartmentsSent.Where(w => w.Status != false && w.Id == msjId).FirstOrDefault();
            findMsj.Status = false;
            _context.Entry(findMsj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            IEnumerable<ContactBetweenDepartmentsSent> sendedMessage = _context.ContactBetweenDepartmentsSent.Where(w => w.Status != false && w.From == findCurrentDepBoss.Emplooyee.Email).OrderByDescending(w => w.CreatedDate).ToList();
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_sendedMessagePartial.cshtml", sendedMessage);
        }
        [HttpGet]
        public async Task<IActionResult> GetSingleInboxMessage(int msjId)
        {
            AppUser findCurrentDepBoss = await _userManager.FindByEmailAsync(User.Identity.Name);
            ContactBetweenDepartmentsInbox findMsj = _context.ContactBetweenDepartmentsInbox.Where(w => w.Status != false && w.Id == msjId).FirstOrDefault();
            findMsj.isRead = true;
            _context.Entry(findMsj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            DepContactVM depContactVM = new DepContactVM()
            {
                Subject = findMsj.Subject,
                Message = findMsj.Message,
                From = findMsj.From,
                Answer = findMsj.Answer,
                Id = findMsj.Id,
            };
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_intoInboxModal.cshtml", depContactVM);
        }
        [HttpPost]
        public async Task<IActionResult> AnswerMessage(int? from, string answer)
        {
            AppUser findCurrentDepBoss = await _userManager.FindByEmailAsync(User.Identity.Name);
            ContactBetweenDepartmentsInbox findMsj = _context.ContactBetweenDepartmentsInbox.Where(w => w.Status != false && w.Id == from).FirstOrDefault();
            findMsj.Answer = answer;
            findMsj.isRead = true;
            _context.Entry(findMsj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            ContactBetweenDepartmentsSent sentMessage = new ContactBetweenDepartmentsSent
            {
                From = findCurrentDepBoss.Email,
                To = findMsj.From,
                CreatedDate = DateTime.Now,
                Subject = findMsj.Subject,
                Message = answer,
                Status = true,
                isRead = false,
            };
            ContactBetweenDepartmentsInbox InboxMessage = new ContactBetweenDepartmentsInbox
            {
                From = findCurrentDepBoss.Emplooyee.Email,
                To = findMsj.From,
                CreatedDate = DateTime.Now,
                Subject = findMsj.Subject,
                Message = answer,
                Status = true,
                isRead = false,
            };
            await _context.ContactBetweenDepartmentsSent.AddAsync(sentMessage);
            await _context.ContactBetweenDepartmentsInbox.AddAsync(InboxMessage);
            await _context.SaveChangesAsync();
            await _emailsender.SendEmailAsync(findMsj.From, "Cavab",
                    $"Kimdən: " + findCurrentDepBoss.Emplooyee.FirstName + " " + findCurrentDepBoss.Emplooyee.Lastname +
                    $"<br/>Cavab: " + answer
                    );
            IEnumerable<ContactBetweenDepartmentsInbox> inboxes = _context.ContactBetweenDepartmentsInbox.Where(w => w.Status != false && w.To == findCurrentDepBoss.Emplooyee.Email).OrderByDescending(w => w.CreatedDate).ToList();
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_inboxMessagePartial.cshtml", inboxes);
        }
        [HttpGet]
        public async Task<IActionResult> loadInbox() {
            AppUser findCurrentDepBoss = await _userManager.FindByEmailAsync(User.Identity.Name);
            IEnumerable<ContactBetweenDepartmentsInbox> inboxes = _context.ContactBetweenDepartmentsInbox.Where(w => w.Status != false && w.To == findCurrentDepBoss.Emplooyee.Email).OrderByDescending(w => w.CreatedDate).ToList();
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_inboxMessagePartial.cshtml", inboxes);
        }
    }
}
