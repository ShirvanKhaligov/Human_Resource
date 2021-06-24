using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models;
using InternalSystem.Areas.InternalHR.ViewModels;
using InternalSystem.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InternalSystem.Areas.InternalHR.Controllers
{

    [Area("InternalHR")]
    [Authorize(Roles = "HumanResource,HrDepartmentBoss")]
    public class EmployeeMessageController : Controller
    {
        private readonly InternalSysDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _env;

        public EmployeeMessageController(UserManager<AppUser> userManager, InternalSysDBContext context, IHostingEnvironment env)
        {
            _userManager = userManager;
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.MessageForEmployees.Where(m => m.Status == true).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MessageForEmployeeVM message)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (ModelState["Description"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Zəhmət olmasa boş buraxmayın");
                return View(message);
            }

            MessageForEmployee newMessage = new MessageForEmployee()
            {
                EmplooyeeId = findUser.EmplooyeeId,
                Description = message.Description.Trim(),
                TimeExecution = DateTime.Now,
                Status = true
            };

            if (message.Photo != null)
            {
                if (!message.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil faylını düzgün seçin");
                    return View(message);
                }

                if (!message.Photo.ImageSize(2))
                {
                    ModelState.AddModelError("Photo", "Şəkil faylının ölçüsü 2Mb-dan artıq ola bilməz");
                    return View(message);
                }
                string filenamePhoto = await message.Photo.CopyImage(_env.WebRootPath, "userOtherDocs/messageImgEmp");
                newMessage.Image = filenamePhoto;
            }

            await _context.MessageForEmployees.AddAsync(newMessage);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            MessageForEmployeeVM message = new MessageForEmployeeVM()
            {
                MessageForEmployee = await _context.MessageForEmployees.FindAsync(id)
            };
            if (message == null) return NotFound();
            return View(message);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MessageForEmployeeVM message, int? id)
        {
            AppUser findUser = await _userManager.FindByEmailAsync(User.Identity.Name);
            if (ModelState["MessageForEmployee.Description"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                ModelState.AddModelError("MessageForEmployee.Description", "Zəhmət olmasa boş buraxmayın");
                return View(message);
            }

            MessageForEmployee messageFor = await _context.MessageForEmployees.FindAsync(id);
            messageFor.Description = message.MessageForEmployee.Description.Trim();
            messageFor.EmplooyeeId = findUser.EmplooyeeId;
            messageFor.Status = true;
            messageFor.TimeExecution = DateTime.Now;


            if (message.PhotoUpd != null)
            {
                if (!message.PhotoUpd.IsImage())
                {
                    ModelState.AddModelError("PhotoUpd", "Zəhmət olmasa şəkil faylını düzgün seçin");
                    return View(message);
                }

                if (!message.PhotoUpd.ImageSize(2))
                {
                    ModelState.AddModelError("PhotoUpd", "Şəkil faylının ölçüsü 2Mb-dan artıq ola bilməz");
                    return View(message);
                }
                string filenamePhoto = await message.PhotoUpd.CopyImage(_env.WebRootPath, "userOtherDocs/messageImgEmp");
                if (messageFor.Image != null)
                {
                    Utilities.Utility.DeleteImageFromFolder(_env.WebRootPath, messageFor.Image);
                }
                messageFor.Image = filenamePhoto;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            MessageForEmployeeVM message = new MessageForEmployeeVM()
            {
                MessageForEmployee = await _context.MessageForEmployees.FindAsync(id)
            };
            if (message == null) return NotFound();
            return View(message);
        }
        public async Task<IActionResult> Delete(int? messageId)
        {
            if (messageId == null) return NotFound();
            MessageForEmployee message = await _context.MessageForEmployees.FindAsync(messageId);
            if (message == null) return NotFound();
            message.Status = false;
            await _context.SaveChangesAsync();
            var message2 = _context.MessageForEmployees.Where(m => m.Status == true).ToList();
            return PartialView("~/Areas/InternalHR/Views/Shared/PartialView/_EmployeeMessagePartial.cshtml", message2);
        }
    }
}
