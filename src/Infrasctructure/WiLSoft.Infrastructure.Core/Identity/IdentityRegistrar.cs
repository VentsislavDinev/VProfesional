using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

using WiLSoft.Infrastructure.Core.Authorization;
using WiLSoft.Infrastructure.Core.Authorization.Roles;
using WiLSoft.Infrastructure.Core.Editions;
using WiLSoft.Infrastructure.Core.MultiTenancy;
using WiLSoft.Infrastructure.Core.Users;

namespace WiLSoft.Infrastructure.Core.Identity
{
    public static class IdentityRegistrar
    {
        public static void Register(IServiceCollection services)
        {
            services.AddLogging();

            services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddDefaultTokenProviders();
        }
    }
}
