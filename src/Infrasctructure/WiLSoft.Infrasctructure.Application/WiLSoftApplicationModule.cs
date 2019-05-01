using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

using WiLSoft.Infrastructure.Core;
using WiLSoft.Infrastructure.Core.Authorization;

namespace WiLSoft.Infrasctructure.Application
{
    [DependsOn(
       typeof(WiLSoftCoreModule),
       typeof(AbpAutoMapperModule))]
    public class WiLSoftApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WiLSoftAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WiLSoftApplicationModule).GetAssembly());
        }
    }
}
