using InternalSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class EmailController : Controller
    {
        IEmailService EmailService { get; set; }
        private IConfiguration _configuration;
        public EmailController(IEmailService emailService, IConfiguration configuration)
        {
            EmailService = emailService;
            _configuration = configuration;
        }
        public IActionResult LoginPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPassword(string Password)
        {
            var Email = User.Identity.Name;
            if (EmailService.CheckEmailPassword(Email, Password) /*|| true*/)
            {
                 
                HttpContext.Session.SetString("UserEmail", Email);
                HttpContext.Session.SetString("UserPass", Password);
                return RedirectToAction("Inbox");
            }
            else
            {
                ViewData["EMailPasswordWrong"] = "Şifrəni düzgün daxil edin";
                return View();
            }
            //return View();
        }
        public IActionResult EmailMessage()
        {
            ViewBag.FromAddresses = User.Identity.Name;
            return View();
        }
        [HttpPost]
        public IActionResult EmailMessage(string ToAddresses, string Subject, string Content)
        {
            if (!string.IsNullOrEmpty(ToAddresses))
            {
                EmailMessage msg = new EmailMessage();
                msg.Subject = Subject;
                msg.Content = Content;

                List<EmailAddress> lst = new List<EmailAddress>();
                EmailAddress address = new EmailAddress() { Address = HttpContext.Session.GetString("UserEmail"), Name = " " };
                lst.Add(address);
                msg.FromAddresses = lst;

                List<EmailAddress> tolst = new List<EmailAddress>();
                EmailAddress to_address = new EmailAddress() { Address = ToAddresses, Name = " " };
                tolst.Add(to_address);
                msg.ToAddresses = tolst;
                var rng = new Random();
                var files = Request.Form.Files.Any() ? Request.Form.Files : new FormFileCollection();
                msg.Attachment = files;

                EmailService.Send(msg, HttpContext.Session.GetString("UserEmail"), HttpContext.Session.GetString("UserPass"));
                TempData["ResultSuccess"] = "Müvəffəqiyyətlə göndərildi";
                return RedirectToAction(nameof(Inbox));
            }
            ViewData["NullToAddress"] = "Boş buraxmayın";
            return View();
        }

        //Inbox
        public IActionResult Inbox()
        {
            var inbox = EmailService.ReceiveInbox(HttpContext.Session.GetString("UserEmail"), HttpContext.Session.GetString("UserPass"));
            return View(inbox);
        }

        //Send
        public IActionResult Send()
        {
            var inbox = EmailService.ReceiveSend(HttpContext.Session.GetString("UserEmail"), HttpContext.Session.GetString("UserPass"));
            return View(inbox);
        }

        //Drafts
        public IActionResult Drafts()
        {
            var inbox = EmailService.ReceiveDrafts(HttpContext.Session.GetString("UserEmail"), HttpContext.Session.GetString("UserPass"));
            return View(inbox);
        }

        //Trash
        public IActionResult Trash()
        {
            var inbox = EmailService.ReceiveTrash(HttpContext.Session.GetString("UserEmail"), HttpContext.Session.GetString("UserPass"));
            return View(inbox);
        }

        //Delete Inbox
        [HttpPost]
        public IActionResult DeleteInbox(string Id)
        {
            if (Id == null) return NotFound();
            var delete = EmailService.ReceiveDeleteInbox(HttpContext.Session.GetString("UserEmail"), HttpContext.Session.GetString("UserPass"), Id);
            ViewData["succes_delete_inbox"] = "Müvəffəqiyyətlə silindi";
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetEmailReceiveInbox.cshtml", delete);
        }

        //Delete Send
        [HttpPost]
        public IActionResult DeleteSend(string Id)
        {
            if (Id == null) return NotFound();
            var delete = EmailService.ReceiveDeleteSend(HttpContext.Session.GetString("UserEmail"), HttpContext.Session.GetString("UserPass"), Id);
            ViewData["succes_delete_inbox"] = "Müvəffəqiyyətlə silindi";
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetEmailReceiveSend.cshtml", delete);
        }

        //Delete Drafts
        [HttpPost]
        public IActionResult DeleteDrafts(string Id)
        {
            if (Id == null) return NotFound();
            var delete = EmailService.ReceiveDeleteDrafts(HttpContext.Session.GetString("UserEmail"), HttpContext.Session.GetString("UserPass"), Id);
            ViewData["succes_delete_inbox"] = "Müvəffəqiyyətlə silindi";
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetEmailReceiveDrafts.cshtml", delete);
        }

        //Delete Trash
        [HttpPost]
        public IActionResult DeleteTrash(string Id)
        {
            if (Id == null) return NotFound();
            var delete = EmailService.ReceiveDeleteTrash(HttpContext.Session.GetString("UserEmail"), HttpContext.Session.GetString("UserPass"), Id);
            ViewData["succes_delete_inbox"] = "Müvəffəqiyyətlə silindi";
            return PartialView("~/Areas/Employee/Views/Shared/PartialView/_GetEmailReceiveTrash.cshtml", delete);
        }

        //Detail Inbox
        public IActionResult DetailInbox(string id)
        {
            var result = EmailService.FindEmailMessage(HttpContext.Session.GetString("UserEmail"), HttpContext.Session.GetString("UserPass"), id);
            return View(result);
        }

        //Detail Send
        public IActionResult DetailSend(string id)
        {
            var result = EmailService.FindEmailMessageSend(HttpContext.Session.GetString("UserEmail"), HttpContext.Session.GetString("UserPass"), id);
            return View(result);
        }

    }
}
