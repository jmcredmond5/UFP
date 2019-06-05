using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UFPCore.Services.EmailService
{
    public interface IEmailSenderService
    {
        Task<bool> SendEmailAsync(string emailTo, string emailFrom, string emailSubject, string emailBody, string htmlBody);
    }
}
