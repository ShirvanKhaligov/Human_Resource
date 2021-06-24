using InternalSystem.Areas.InternalHR.Models.MailRu;
using InternalSystem.Areas.InternalHR.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InternalSystem.Areas.Employee.Controllers
{
    [Area("Employee")]
    [Authorize(Roles = "Member")]
    public class EmailsController : Controller
    {
        IEmailService EmailService { get; set; }
        public EmailsController(IEmailService emailService)
        {
            EmailService = emailService;


        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            if (EmailService.CheckEmailPassword(Email, Password) /*|| true*/)
            {
                HttpContext.Session.SetString("UserEmail", Email);
                HttpContext.Session.SetString("UserPass", Password);
                return RedirectToAction("EmailMessage");
            }
            return View();
        }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult EmailMessage()
        {
            ViewBag.FromAddresses = HttpContext.Session.GetString("UserEmail");
            return View();
        }

        [HttpPost]
        public IActionResult EmailMessage(string ToAddresses, string Subject, string Content)
        {
            EmailMessage msg = new EmailMessage();
            msg.Content = Content;
            List<EmailAddress> lst = new List<EmailAddress>();
            EmailAddress address = new EmailAddress() { Address = HttpContext.Session.GetString("UserEmail"), Name = " " };
            lst.Add(address);
            msg.FromAddresses = lst;
            msg.Subject = Subject;
            List<EmailAddress> tolst = new List<EmailAddress>();
            EmailAddress to_address = new EmailAddress() { Address = ToAddresses, Name = " " };
            tolst.Add(to_address);
            msg.ToAddresses = tolst;
            EmailService.Send(msg, HttpContext.Session.GetString("UserEmail"), HttpContext.Session.GetString("UserPass"));
            ViewBag.Result = "Your Email is Send Successfully!";
            return View();
        }


        public IActionResult GetEmails()
        {
            var result = EmailService.ReceiveEmail(HttpContext.Session.GetString("UserEmail"), HttpContext.Session.GetString("UserPass"), 1);
            return View(result);
        }

    }
}
