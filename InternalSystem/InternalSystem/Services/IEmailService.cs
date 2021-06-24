using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Services
{
    public interface IEmailService
    {
        void Send(EmailMessage emailMessage, string Email, string Password);
        //List<EmailMessage> ReceiveEmail(string Email, string Password, int maxCount = 10);
        //bool CheckEmailPassword(string Email, string Password);
        bool CheckEmailPassword(string Email, string Password);
        List<EmailMessage> FindEmailMessage(string Email, string Password, string mes);
        List<EmailMessage> FindEmailMessageSend(string Email, string Password, string mes);
        List<EmailMessage> ReceiveInbox(string Email, string Password);
        List<EmailMessage> ReceiveSend(string Email, string Password);
        List<EmailMessage> ReceiveDeleteInbox(string Email, string Pasword,string id);
        List<EmailMessage> ReceiveDeleteSend(string Email, string Pasword, string id);
        List<EmailMessage> ReceiveTrash(string Email, string Pasword);
        List<EmailMessage> ReceiveDeleteTrash(string Email, string Pasword, string id);
        List<EmailMessage> ReceiveDrafts(string Email, string Pasword);
        List<EmailMessage> ReceiveDeleteDrafts(string Email, string Pasword, string id);
    }
}
