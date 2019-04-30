using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using WiLSoft.Infrastructure.Core.Configuration;
using WiLSoft.Infrastructure.Core.Web;
using WiLSoft.Infrastructure.Core;
using Microsoft.EntityFrameworkCore.Design;

namespace WiLSoft.Authentatiocation.Models
{
    public class WiLSoftDbContextFactory : IDesignTimeDbContextFactory<AuthDbContext>
    {
        public WiLSoftDbContextFactory()
        {
        }

        public AuthDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AuthDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            IdentityServerDemoDbContextConfigurer.Configure(builder, WiLSoftConsts.ConnectionStringName);

            return new AuthDbContext(builder.Options);
        }
    }
}
