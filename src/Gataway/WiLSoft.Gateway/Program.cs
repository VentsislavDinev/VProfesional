﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.StaticFiles;
using Ocelot.Middleware;
using Ocelot.DependencyInjection;

namespace WiLSoft.Gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseKestrel()
             .UseContentRoot(Directory.GetCurrentDirectory())
               .ConfigureAppConfiguration((hostingContext, config) =>
               {
                   config
                       .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                       .AddJsonFile("appsettings.json", true, true)
                       .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true, true)
                       .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
                       .AddEnvironmentVariables();
               })
               .ConfigureServices(s => {
                   s.AddOcelot();
               })
               .ConfigureLogging((hostingContext, logging) =>
               {
                   //add your logging
               })
               .UseIISIntegration()
               .Configure(app =>
               {
                   app.UseOcelot().Wait();
               })
                .UseStartup<Startup>();
    }
}
