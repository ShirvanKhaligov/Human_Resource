using InternalSystem.Areas.InternalHR.Models.MailRu;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InternalSystem.Areas.InternalHR.Services
{
    public class EmailService : IEmailService
    {
        private readonly IEmailConfiguration _emailConfiguration;


        public EmailService(IEmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }


		public List<EmailMessage> ReceiveEmail(string Email, string Password, int maxCount = 10)
		{
			using (var emailClient = new Pop3Client())
			{
				emailClient.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, true);

				emailClient.AuthenticationMechanisms.Remove("XOAUTH2");

				//emailClient.Authenticate(_emailConfiguration.PopUsername, _emailConfiguration.PopPassword);
				emailClient.Authenticate(Email, Password);

				List<EmailMessage> emails = new List<EmailMessage>();
				for (int i = 0; i < emailClient.Count && i < maxCount; i++)
				{
					var message = emailClient.GetMessage(i);
					var emailMessage = new EmailMessage
					{
						Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody : message.TextBody,
						Subject = message.Subject
					};
					emailMessage.ToAddresses.AddRange(message.To.Select(x => (MailboxAddress)x).Select(x => new EmailAddress { Address = x.Address, Name = x.Name }));
					emailMessage.FromAddresses.AddRange(message.From.Select(x => (MailboxAddress)x).Select(x => new EmailAddress { Address = x.Address, Name = x.Name }));
					emails.Add(emailMessage);
				}

				return emails;
			}
		}

		public void Send(EmailMessage emailMessage, string Email, string Password)
		{
			var message = new MimeMessage();
			message.To.AddRange(emailMessage.ToAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
			message.From.AddRange(emailMessage.FromAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));

			message.Subject = emailMessage.Subject;
			//We will say we are sending HTML. But there are options for plaintext etc. 
			message.Body = new TextPart(TextFormat.Html)
			{
				Text = emailMessage.Content
			};

			//Be careful that the SmtpClient class is the one from Mailkit not the framework!
			using (var emailClient = new SmtpClient())
			{
				//emailClient.CheckCertificateRevocation = false;

				//The last parameter here is to use SSL (Which you should!)
				emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, true);

				//Remove any OAuth functionality as we won't be using it. 
				emailClient.AuthenticationMechanisms.Remove("XOAUTH2");

				//emailClient.Authenticate(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);
				emailClient.Authenticate(Email, Password);

				emailClient.Send(message);

				emailClient.Disconnect(true);
			}
		}
		public bool CheckEmailPassword(string Email, string Password)
		{

			try
			{
				using (var emailClient = new SmtpClient())
				{
					emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, true);
					emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
					emailClient.Authenticate(Email, Password);
					return true;
				}
			}
			catch (Exception )
			{

				return false;
			}

		}

	}
}
