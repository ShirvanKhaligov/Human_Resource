using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InternalSystem.Services
{
    public class EmailService: Controller,IEmailService
    {
        private readonly IEmailConfiguration _emailConfiguration;
        private IConfiguration _configuration;

        public EmailService(IEmailConfiguration emailConfiguration,IConfiguration configuration)
        {
            _emailConfiguration = emailConfiguration;
            _configuration = configuration;
        }
        //public bool CheckEmailPassword(string Email, string Password)
        //{
        //    try
        //    {
        //        using (var emailClient = new SmtpClient())
        //        {
        //            emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, true);
        //            emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
        //            emailClient.Authenticate(Email, Password);
        //            return true;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }
        //}
        public bool CheckEmailPassword(string Email, string Password)
        {
            try
            {
                using (var emailClient = new MailKit.Net.Smtp.SmtpClient())
                {
                    emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, true);
                    emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
                    emailClient.Authenticate(Email, Password);
                    //emailClient.Authenticate("resad.gozelov12345@gmail.com", Password);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<EmailMessage> FindEmailMessage(string Email, string Password, string mes)
        {
            using (var emailClient = new ImapClient())
            {
                //emailClient.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, true);
                emailClient.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, SecureSocketOptions.SslOnConnect);
                emailClient.Authenticate(Email, Password);

                emailClient.Inbox.Open(FolderAccess.ReadOnly);
                var uids = emailClient.Inbox.Search(SearchQuery.All).OrderByDescending(a => a.Id).Take(20).ToList();
                //emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
            
                List<EmailMessage> emails = new List<EmailMessage>();
                for (int i = 0; i < uids.Count; i++)
                {
                    var message = emailClient.Inbox.GetMessage(uids[i]);
                    //var message = emailClient.Inbox.GetMessage(i);
                    if (message.MessageId == mes)
                    {
                        try
                        {
                            var emailMessage = new EmailMessage
                            {
                                Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                                Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                                NowDay = message.Date,
                                From = message.From.OfType<MailboxAddress>().Single().Address,
                                MessageId = mes,
                                To = message.To.OfType<MailboxAddress>().Single().Address,
                                Attachments = message.Attachments.OfType<MimePart>().Single().ContentType != null ? message.Attachments.OfType<MimePart>().Single().ContentType : null
                            };
                            emails.Add(emailMessage);
                            return emails;
                        }
                        catch (Exception)
                        {
                            var emailMessage = new EmailMessage
                            {
                                Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                                Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                                NowDay = message.Date,
                                From = message.From.OfType<MailboxAddress>().Single().Address,
                                MessageId = mes,
                                To = message.To.OfType<MailboxAddress>().Single().Address,
                                //Attachments = message.Attachments.OfType<MimePart>().Single().ContentType != null ? message.Attachments.OfType<MimePart>().Single().ContentType : null
                            };
                            emails.Add(emailMessage);
                            return emails;
                        }
                    }
                        
                }
                return emails;
            }
        }

        public void Send(EmailMessage emailMessage, string Email, string Password)
        {
            var message = new MimeMessage();
            message.To.AddRange(emailMessage.ToAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
            message.From.AddRange(emailMessage.FromAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
            BodyBuilder bodyB = new BodyBuilder();
            if (emailMessage.Subject != null)
            {
                message.Subject = emailMessage.Subject;
            }
            else
            {
                message.Subject = "";
            }
            if (emailMessage.Content!=null)
            {
                message.Body = new TextPart(TextFormat.Plain)
                {
                    ContentId = emailMessage.Content
                };
                 bodyB = new BodyBuilder { TextBody = string.Format("{0}", message.Body.ContentId) };
            }
            else
            {
                emailMessage.Content = "";
                bodyB = new BodyBuilder { TextBody = string.Format("{0}", emailMessage.Content) };
            }
            if (emailMessage.Attachment != null && emailMessage.Attachment.Any())
            {
                byte[] fileBytes;
                foreach (var item in emailMessage.Attachment)
                {
                    using (var ms = new System.IO.MemoryStream())
                    {
                        item.CopyTo(ms);
                        fileBytes = ms.ToArray();
                    }
                    bodyB.Attachments.Add(item.FileName, fileBytes, ContentType.Parse(item.ContentType));
                }
            }
            message.Body = bodyB.ToMessageBody();
            using (var emailClient = new MailKit.Net.Smtp.SmtpClient())
            {
                emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, true);
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
                emailClient.Authenticate(Email, Password);

                emailClient.Send(message);

                emailClient.Disconnect(true);
                
            }
        }

        //Receive 2
        //public List<EmailMessage> ReceiveInbox(string Email, string Password)
        //{
        //    using (var client = new ImapClient())
        //    {
        //        using (var cancel = new System.Threading.CancellationTokenSource())
        //        {
        //            client.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort,true, cancel.Token);

        //            client.AuthenticationMechanisms.Remove("XOAUTH");
        //            client.Authenticate(Email, Password);

        //            var inbox = client.Inbox;
        //            inbox.Open(FolderAccess.ReadOnly, cancel.Token);
        //            List<EmailMessage> emails = new List<EmailMessage>();
        //            for (int i = 0; i < inbox.Count; i++)
        //            {
        //                var message = inbox.GetMessage(i, cancel.Token);
        //                var emailMessage = new EmailMessage
        //                {
        //                    Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
        //                    Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
        //                    NowDay = message.Date,
        //                    From = message.From.OfType<MailboxAddress>().Single().Address,
        //                    MessageId = message.MessageId,
        //                    //NotSeenInbox= (int)ViewData["notSeenInbox"]
        //                };
        //                emails.Add(emailMessage);
        //            }
        //            client.Disconnect(true, cancel.Token);
        //            return emails;
        //        }
        //    }
        //}

        //Receive 1
        public List<EmailMessage> ReceiveInbox(string Email, string Password) //Inbox
        {
            using (var client = new ImapClient())
            {
                client.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, SecureSocketOptions.SslOnConnect);

                client.Authenticate(Email, Password);

                client.Inbox.Open(FolderAccess.ReadOnly);
                var uids = client.Inbox.Search(SearchQuery.All).OrderByDescending(a => a.Id).Take(20).ToList();
                //ViewData["notSeenInbox"] = client.Inbox.Search(SearchQuery.NotSeen).Count;
                List<EmailMessage> emails = new List<EmailMessage>();

                //query from sql
                foreach (var uid in uids)
                {
                    var message = client.Inbox.GetMessage(uid);
                    var emailMessage = new EmailMessage
                    {
                        Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                        Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                        NowDay = message.Date,
                        From = message.From.OfType<MailboxAddress>().Single().Address,
                        MessageId = message.MessageId,
                        //NotSeenInbox= (int)ViewData["notSeenInbox"]
                    };
                    emails.Add(emailMessage);
                }

                client.Disconnect(true);
                return emails;
            }
        }

        public List<EmailMessage> ReceiveSend(string Email, string Password) //Send 
        {
            using (var client = new ImapClient())
            {
                client.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, SecureSocketOptions.SslOnConnect);

                client.Authenticate(Email, Password);
                var sentFolder = client.GetFolder(SpecialFolder.Sent);
                sentFolder.Open(FolderAccess.ReadOnly);
                var uids = sentFolder.Search(SearchQuery.All).OrderByDescending(aa => aa.Id).Take(20).ToList();
                List<EmailMessage> emails = new List<EmailMessage>();
                for (int i = 0; i < uids.Count; i++)
                {
                    var message = sentFolder.GetMessage(uids[i]);
                    var emailMessage = new EmailMessage
                    {
                        Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                        Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                        NowDay = message.Date,
                        From = message.From.OfType<MailboxAddress>().Single().Address,
                        To=message.To.OfType<MailboxAddress>().Single().Address,
                        MessageId = message.MessageId
                    };
                    emails.Add(emailMessage);
                }
                //foreach (var uid in sentFolder)
                //{
                //    var message = sentFolder.GetMessage(uid);
                //    var emailMessage = new EmailMessage
                //    {
                //        Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                //        Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                //        NowDay = message.Date,
                //        From = message.From.OfType<MailboxAddress>().Single().Address,
                //    };
                //    //message.WriteTo(string.Format("{0}.eml", uid));
                //    emails.Add(emailMessage);
                //}
                client.Disconnect(true);
                return emails;
            }
        }

        public List<EmailMessage> ReceiveDeleteInbox(string Email, string Password,string id)
        {
            List<EmailMessage> emails = new List<EmailMessage>();
            using (var client = new ImapClient())
            {                
                client.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, SecureSocketOptions.SslOnConnect);
                client.Authenticate(Email, Password);
                client.Inbox.Open(FolderAccess.ReadWrite);
                //var fa = client.Inbox.Search(SearchQuery.HeaderContains("Message-Id", id)).ToList();
                var uids = client.Inbox.Search(SearchQuery.All).OrderByDescending(a => a.Id).Take(20).ToList();

                for (int i = 0; i < uids.Count; i++)
                {
                    var message = client.Inbox.GetMessage(uids[i]);
                    if (message.MessageId == id)
                    {
                        client.Inbox.AddFlags(uids[i], MessageFlags.Deleted, true);
                        client.Inbox.Expunge(uids);
                    }
                    else
                    {
                        var emailMessage = new EmailMessage
                        {
                            Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                            Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                            NowDay = message.Date,
                            From = message.From.OfType<MailboxAddress>().Single().Address,
                        };
                        emails.Add(emailMessage);
                    }
                }
                client.Disconnect(true);
                return emails.OrderByDescending(aa => aa.Id).Take(10).ToList();
            }
        }
        public List<EmailMessage> ReceiveDeleteSend(string Email, string Password, string id)
        {
            List<EmailMessage> emails = new List<EmailMessage>();
            using (var client = new ImapClient())
            {
                client.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, SecureSocketOptions.SslOnConnect);
                client.Authenticate(Email, Password);
                //client.Inbox.Open(FolderAccess.ReadWrite);
                var sentFolder = client.GetFolder(SpecialFolder.Sent);
                sentFolder.Open(FolderAccess.ReadWrite);
                var uids = sentFolder.Search(SearchQuery.All).OrderByDescending(a => a.Id).Take(20).ToList();
                for (int i = 0; i < uids.Count; i++)
                {
                    var message = sentFolder.GetMessage(uids[i]);
                    if (message.MessageId == id)
                    {
                        sentFolder.AddFlags(uids[i], MessageFlags.Deleted, true);
                        sentFolder.Expunge(uids);
                    }
                    else
                    {
                        var emailMessage = new EmailMessage
                        {
                            Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                            Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                            NowDay = message.Date,
                            From = message.From.OfType<MailboxAddress>().Single().Address,
                            To=message.To.OfType<MailboxAddress>().Single().Address
                        };
                        emails.Add(emailMessage);
                    }
                }
                client.Disconnect(true);
                return emails.OrderByDescending(aa => aa.Id).Take(10).ToList();
            }
        }
        public List<EmailMessage> FindEmailMessageSend(string Email, string Password, string mes)
        {
            using (var emailClient = new ImapClient())
            {
                emailClient.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, SecureSocketOptions.SslOnConnect);
                emailClient.Authenticate(Email, Password);
                var sentFolder = emailClient.GetFolder(SpecialFolder.Sent);
                sentFolder.Open(FolderAccess.ReadOnly);
                var uids = sentFolder.Search(SearchQuery.All).OrderByDescending(aa => aa.Id).Take(20).ToList();

                List<EmailMessage> emails = new List<EmailMessage>();
                for (int i = 0; i < uids.Count; i++)
                {
                    var message = sentFolder.GetMessage(uids[i]);
                 
                    if (message.MessageId == mes)
                    {
                        try
                        {
                            var emailMessage = new EmailMessage
                            {
                                Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                                Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                                NowDay = message.Date,
                                From = message.From.OfType<MailboxAddress>().Single().Address,
                                MessageId = mes,
                                To = message.To.OfType<MailboxAddress>().Single().Address,
                                Attachments = message.Attachments.OfType<MimePart>().Single().ContentType != null ? message.Attachments.OfType<MimePart>().Single().ContentType : null
                            };
                            emails.Add(emailMessage);
                            return emails;
                        }
                        catch (Exception)
                        {
                            var emailMessage = new EmailMessage
                            {
                                Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                                Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                                NowDay = message.Date,
                                From = message.From.OfType<MailboxAddress>().Single().Address,
                                MessageId = mes,
                                To = message.To.OfType<MailboxAddress>().Single().Address
                            };
                            emails.Add(emailMessage);
                            return emails;
                        }
                        //var emailMessage = new EmailMessage
                        //{
                        //    Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                        //    Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                        //    NowDay = message.Date,
                        //    From = message.From.OfType<MailboxAddress>().Single().Address,
                        //    MessageId = mes,
                        //    To= message.To.OfType<MailboxAddress>().Single().Address
                            
                        //};
                        //emails.Add(emailMessage);
                        //return emails;
                    }

                }
                return emails;
            }
        }

        public List<EmailMessage> ReceiveTrash(string Email, string Password)//Trash
        {
            using (var client = new ImapClient())
            {
                client.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, SecureSocketOptions.SslOnConnect);

                client.Authenticate(Email, Password);
                var sentFolder = client.GetFolder(SpecialFolder.Trash);
                sentFolder.Open(FolderAccess.ReadOnly);
                var uids = sentFolder.Search(SearchQuery.All).OrderByDescending(aa => aa.Id).Take(20).ToList();
                List<EmailMessage> emails = new List<EmailMessage>();
                for (int i = 0; i < uids.Count; i++)
                {
                    var message = sentFolder.GetMessage(uids[i]);
                    var emailMessage = new EmailMessage
                    {
                        Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                        Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                        NowDay = message.Date,
                        From = message.From.OfType<MailboxAddress>().Single().Address,
                        To = message.To.OfType<MailboxAddress>().Single().Address,
                        MessageId = message.MessageId
                    };
                    emails.Add(emailMessage);
                }
                client.Disconnect(true);
                return emails;
            }
        }

        public List<EmailMessage> ReceiveDeleteTrash(string Email, string Password, string id)
        {
            List<EmailMessage> emails = new List<EmailMessage>();
            using (var client = new ImapClient())
            {
                client.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, SecureSocketOptions.SslOnConnect);
                client.Authenticate(Email, Password);
                //client.Inbox.Open(FolderAccess.ReadWrite);
                var sentFolder = client.GetFolder(SpecialFolder.Trash);
                sentFolder.Open(FolderAccess.ReadWrite);
                var uids = sentFolder.Search(SearchQuery.All).OrderByDescending(a => a.Id).Take(20).ToList();
                for (int i = 0; i < uids.Count; i++)
                {
                    var message = sentFolder.GetMessage(uids[i]);
                    if (message.MessageId == id)
                    {
                        sentFolder.AddFlags(uids[i], MessageFlags.Deleted, true);
                        sentFolder.Expunge(uids);
                    }
                    else
                    {
                        var emailMessage = new EmailMessage
                        {
                            Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                            Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                            NowDay = message.Date,
                            From = message.From.OfType<MailboxAddress>().Single().Address,
                            To = message.To.OfType<MailboxAddress>().Single().Address,
                            MessageId=message.MessageId
                        };
                        emails.Add(emailMessage);
                    }
                }
                client.Disconnect(true);
                return emails.OrderByDescending(aa => aa.Id).Take(10).ToList();
            }
        }

        public List<EmailMessage> ReceiveDrafts(string Email, string Password)
        {
            using (var client = new ImapClient())
            {
                client.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, SecureSocketOptions.SslOnConnect);

                client.Authenticate(Email, Password);
                var sentFolder = client.GetFolder(SpecialFolder.Drafts);
                sentFolder.Open(FolderAccess.ReadOnly);
                var uids = sentFolder.Search(SearchQuery.All).OrderByDescending(aa => aa.Id).Take(20).ToList();
                List<EmailMessage> emails = new List<EmailMessage>();
                for (int i = 0; i < uids.Count; i++)
                {
                    var message = sentFolder.GetMessage(uids[i]);
                    var emailMessage = new EmailMessage
                    {
                        Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                        Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                        NowDay = message.Date,
                        To = message.To.Count!=0? message.To.OfType<MailboxAddress>().Single().Address : "<Dəqiqləşdirilməyib>",
                        MessageId = message.MessageId
                    };
                    emails.Add(emailMessage);
                }
                client.Disconnect(true);
                return emails;
            }
        }

        public List<EmailMessage> ReceiveDeleteDrafts(string Email, string Password, string id)
        {
            List<EmailMessage> emails = new List<EmailMessage>();
            using (var client = new ImapClient())
            {
                client.Connect(_emailConfiguration.PopServer, _emailConfiguration.PopPort, SecureSocketOptions.SslOnConnect);
                client.Authenticate(Email, Password);
                var sentFolder = client.GetFolder(SpecialFolder.Drafts);
                sentFolder.Open(FolderAccess.ReadWrite);
                var uids = sentFolder.Search(SearchQuery.All).OrderByDescending(a => a.Id).Take(20).ToList();
                for (int i = 0; i < uids.Count; i++)
                {
                    var message = sentFolder.GetMessage(uids[i]);
                    if (message.MessageId == id)
                    {
                        sentFolder.AddFlags(uids[i], MessageFlags.Deleted, true);
                        sentFolder.Expunge(uids);
                    }
                    else
                    {
                        var emailMessage = new EmailMessage
                        {
                            Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody ?? "" : message.TextBody ?? "",
                            Subject = message.Subject == "" || message.Subject == null ? "Mövzu: yoxdur" : message.Subject,
                            NowDay = message.Date,
                            To = message.To.Count != 0 ? message.To.OfType<MailboxAddress>().Single().Address : "<Dəqiqləşdirilməyib>",
                        };
                        emails.Add(emailMessage);
                    }
                }
                client.Disconnect(true);
                return emails.OrderByDescending(aa => aa.Id).Take(10).ToList();
            }
        }

    }
}
