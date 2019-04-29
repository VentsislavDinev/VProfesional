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

namespace WiLSoft.Authentatiocation.Models
{
    public class WiLSoftDbContextFactory : IDbContextFactory<AuthDbContext>
    {
        public WiLSoftDbContextFactory()
        {
        }

        public WiLSoftDbContextFactory Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<AuthDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            IdentityServerDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(WiLSoftConsts.ConnectionStringName));

            return new AuthDbContext(builder.Options);
        }
    }
}
