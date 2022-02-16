using Business.Abstract;
using Business.Utilities.MailKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MailManager : IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailManager(IOptions<MailSettings> options)
        {
            _mailSettings = options.Value;
        }

        public bool SendEmail(MailModel mailModel)
        {
            bool isSend;
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
            email.To.Add(MailboxAddress.Parse(mailModel.ToEmail));
            email.Subject = mailModel.Subject;
            email.Body = new TextPart("plain")
            {
                Text =mailModel.Body
            };
            using var smtp = new SmtpClient();
            try
            {
                smtp.Connect(_mailSettings.Host,_mailSettings.Port,true);
                smtp.Authenticate(_mailSettings.Mail,_mailSettings.Password);
                smtp.Send(email);
                isSend = true;
            }
            catch(Exception ex)
            {
                isSend = false;
            }
            finally
            {
                smtp.Disconnect(true);
                smtp.Dispose();
               
            }
            return isSend;
        }
    }
}
