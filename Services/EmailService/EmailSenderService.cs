using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UFPCore.Configuration;

namespace UFPCore.Services.EmailService
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly IOptions<SmtpConfiguration> _emailServiceConfiguration;

        public EmailSenderService(IOptions<SmtpConfiguration> emailServiceConfiguration)
        {
            _emailServiceConfiguration = emailServiceConfiguration;
        }

        public async Task<bool> SendEmailAsync(string emailTo, 
            string emailFrom, 
            string emailSubject, 
            string emailBody,
            string htmlBody = "")
        {
            if (emailFrom == "")
                emailFrom = _emailServiceConfiguration.Value.EmailAddress;
            try
            {
                MimeMessage message = new MimeMessage();

                message.To.Add(new MailboxAddress(emailTo));
                message.From.Add(new MailboxAddress(emailFrom));
                message.Subject = emailSubject;

                var builder = new BodyBuilder();
                builder.TextBody = emailBody;
                builder.HtmlBody = htmlBody;
                message.Body = builder.ToMessageBody();

                //using
                var client = new SmtpClient
                {
                    ServerCertificateValidationCallback = (s, c, h, e) => true
                };

                await client.ConnectAsync(
                    _emailServiceConfiguration.Value.Server,
                    _emailServiceConfiguration.Value.Port,
                    false);

                client.Authenticate(
                    _emailServiceConfiguration.Value.EmailAddress,
                    _emailServiceConfiguration.Value.Password
                    );

                client.Send(message);

                client.Disconnect(true);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
