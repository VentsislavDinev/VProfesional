using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;
using WiLSoft.Infrastructure.Core;

namespace WiLSoft.WebModule.Core.Controllers
{
    public abstract class WiLSoftAuthControllerBase : AbpController
    {
        protected WiLSoftAuthControllerBase()
        {
            LocalizationSourceName = WiLSoftConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}