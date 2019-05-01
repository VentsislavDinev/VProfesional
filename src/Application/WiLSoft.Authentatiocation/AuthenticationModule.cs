using Abp.Application.Services;
using Abp.IdentityServer4;
using Abp.Modules;
using Abp.Zero.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using WiLSoft.Infrasctructure.Application;
using WiLSoft.Infrastructure.Core;
using WiLSoft.WebModule.Core.Configuration;

namespace WiLSoft.Authentatiocation
{
    [DependsOn(
        typeof(AbpZeroCoreIdentityServerEntityFrameworkCoreModule),
        typeof(WiLSoftCoreModule), 
        typeof(WiLSoftApplicationModule)

    )]
    //[DependsOn(
    //    typeof(AbpWebSignalRModule),
    //    typeof(AbpHangfireModule),
    //    typeof(AbpWebMvcModule))]
    public class AuthenticationModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AuthenticationModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());


            //Enable database based localization
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            //Configure navigation/menu
            // Configuration.Navigation.Providers.Add<InterceptionDemoNavigationProvider>();

            //Configure Hangfire
            //Configuration.BackgroundJobs.UseHangfire(configuration =>
            //{
            //    configuration.GlobalConfiguration.UseSqlServerStorage("Default");
            //});
           

            //  Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));

        }


        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            //AreaRegistration.RegisterAllAreas();
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
