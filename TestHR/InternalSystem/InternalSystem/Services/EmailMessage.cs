using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternalSystem.Services
{
    public class EmailMessage
    {
		public EmailMessage()
		{
			//ToAddresses = new List<EmailAddress>();
			//FromAddresses = new List<EmailAddress>();
		}

        public List<EmailAddress> ToAddresses { get; set; }
        public List<EmailAddress> FromAddresses { get; set; }
        public string Subject { get; set; }
		public string Content { get; set; }
        public DateTimeOffset NowDay { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public MimeKit.InternetAddressList FromIntAddress2 { get; set; }
        public string ProfilImg { get; set; }
        public IFormFileCollection Attachment { get; set; }
        public MimeKit.ContentType Attachments { get; set; }
        public MimeKit.ContentType Attachmentss{ get; set; }
        public string MessageId { get; set; }
        public uint Id { get; set; }
        //public int NotSeenInbox { get; set; }
    }
}
