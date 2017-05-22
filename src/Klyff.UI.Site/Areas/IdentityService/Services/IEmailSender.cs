using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klyff.UI.Site.Identity.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
