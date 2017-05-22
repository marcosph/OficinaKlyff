using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.Service.Extensions;

namespace Klyff.UI.Site.Identity
{
    // These values are used to setup the identity servcie and should not be changed
    public class IdentityServiceConstants
    {
        // Name of the single identity service tenant
        public const string Tenant = "IdentityService";
        
        // Unique ID of the single identity service tenant
        public const string TenantId = "81E347A2-9996-48E6-B066-9EB3748C8A3F";

        // Default policy for the identity service
        public const string DefaultPolicy = "signinsignup";

        // Identity service version
        public const string Version = "2.0";

        // Identity service token version
        public const string TokenVersion = "1.0";
    }
}
