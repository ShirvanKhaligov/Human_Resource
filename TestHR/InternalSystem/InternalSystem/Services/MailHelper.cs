using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;

namespace InternalSystem.Services
{
    public class MailHelper
    {
        private IConfiguration _configuration;
        public MailHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public bool Send2(string from, string to, string subject, string content, List<string> attachments)
        {
            try
            {
                var host = _configuration["EmailConfiguration::Host"];
                var port = int.Parse(_configuration["EmailConfiguration::Port"]);
                var username = _configuration["EmailConfiguration::Username"];
                var password = _configuration["EmailConfiguration::Password"];
                var enabled = bool.Parse(_configuration["EmailConfiguration::SMTP"]);
                var smtpClient = new System.Net.Mail.SmtpClient
                {
                    Host = host,
                    Port = port,
                    EnableSsl = enabled,
                    Credentials = new System.Net.NetworkCredential(username, password)
                };
                var mailMessage = new MailMessage(from, to);
                mailMessage.Subject = subject;
                mailMessage.Body = content;
                mailMessage.IsBodyHtml = true;
                if (attachments != null)
                {
                    foreach (var attc in attachments)
                    {
                        mailMessage.Attachments.Add(new Attachment(attc));
                    }
                }
                smtpClient.Send(mailMessage);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
