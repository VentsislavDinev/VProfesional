using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Ocelot;
using Ocelot.Administration;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Consul;
using Ocelot.Cache.CacheManager;
using Ocelot.Provider.Polly;
using Ocelot.Tracing.Butterfly;

namespace WiLSoft.Gateway
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
            .AddJsonFile("ocelot.json")
            .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOcelot()
                .AddConsul()
                .AddConfigStoredInConsul()
                .AddCacheManager(x =>
                {
                    x.WithDictionaryHandle();
                })
                // this comes from Ocelot.Tracing.Butterfly package
                .AddButterfly(option =>
                {
                    //this is the url that the butterfly collector server is running on...
                    option.CollectorUrl = "http://localhost:9618";
                    option.Service = "Ocelot";
                })
                .AddPolly()
                .AddAdministration("/administration", "identity server internal key");
            var authenticationProviderKey = "TestKey";

            services.AddAuthentication()
                .AddJwtBearer(authenticationProviderKey, x =>
                {
                    x.Authority = "test";
                    x.Audience = "test";
                });

            //Action<IdentityServerAuthenticationOptions> options = o =>
            //{
            //    o.Authority = "https://whereyouridentityserverlives.com";
            //    o.ApiName = "api";
            //    o.SupportedTokens = SupportedTokens.Both;
            //    o.ApiSecret = "secret";
            //};

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseOcelot()
                .Wait();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
