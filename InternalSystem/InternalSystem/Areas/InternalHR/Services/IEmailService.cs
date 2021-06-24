using InternalSystem.Areas.InternalHR.Models.MailRu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Areas.InternalHR.Services
{
    public interface IEmailService
    {
        void Send(EmailMessage emailMessage, string Email, string Password);
        List<EmailMessage> ReceiveEmail(string Email, string Password, int maxCount = 10);
        bool CheckEmailPassword(string Email, string Password);

    }
}
