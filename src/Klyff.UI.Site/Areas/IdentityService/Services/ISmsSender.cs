using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klyff.UI.Site.Identity.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
