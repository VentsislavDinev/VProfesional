using Abp.IdentityServer4;
using Abp.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WiLSoft.Authentatiocation
{
    [DependsOn(typeof(AbpZeroCoreIdentityServerEntityFrameworkCoreModule))]
    public class AuthenticationModule : AbpModule
    {
    }
}
