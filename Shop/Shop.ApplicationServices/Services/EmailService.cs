using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using Shop.Core.Dto;
using Shop.Core.ServiceInterface;



namespace Shop.ApplicationServices.Services
{
    public class EmailServices : IEmailServices
    {
        public void SendEmail(EmailDtos request)
        {

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("ariha@gmail.com"));
            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = request.Body };

            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, false);

                // Note: only needed if the SMTP server requires authentication
                smtp.Authenticate("ariha1059@gmail.com", "kgjk mnig infv czxv ");
                smtp.Send(email);
                smtp.Disconnect(true);
            }
        }
    }
}