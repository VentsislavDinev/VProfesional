using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WiLSoft.Authentatiocation.Models
{
    public static class IdentityServerDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AuthDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}
