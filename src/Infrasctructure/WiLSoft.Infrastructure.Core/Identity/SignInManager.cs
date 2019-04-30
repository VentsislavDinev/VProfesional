using Abp.Authorization;
using Abp.Configuration;
using Abp.Domain.Uow;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WiLSoft.Infrastructure.Core.Authorization.Roles;
using WiLSoft.Infrastructure.Core.MultiTenancy;
using WiLSoft.Infrastructure.Core.Users;

namespace WiLSoft.Infrastructure.Core.Identity
{
    public class SignInManager : AbpSignInManager<Tenant, Role, User>
    {
        public SignInManager(
            UserManager userManager,
            IHttpContextAccessor contextAccessor,
            UserClaimsPrincipalFactory claimsFactory,
            IOptions<IdentityOptions> optionsAccessor,
            ILogger<SignInManager<User>> logger,
            IUnitOfWorkManager unitOfWorkManager,
            ISettingManager settingManager,
            IAuthenticationSchemeProvider schemes
            ) : base(
                userManager,
                contextAccessor,
                claimsFactory,
                optionsAccessor,
                logger,
                unitOfWorkManager,
                settingManager,
                schemes)
        {
        }
    }
}
