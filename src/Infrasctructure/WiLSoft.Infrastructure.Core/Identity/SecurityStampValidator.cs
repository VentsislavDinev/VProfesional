using Abp.Authorization;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using WiLSoft.Infrastructure.Core.Authorization.Roles;
using WiLSoft.Infrastructure.Core.MultiTenancy;
using WiLSoft.Infrastructure.Core.Users;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;

namespace WiLSoft.Infrastructure.Core.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options, 
            AbpSignInManager<Tenant, Role, User> signInManager,
            ISystemClock systemClock)
            : base(options, signInManager, systemClock)
        {
        }
    }
}
