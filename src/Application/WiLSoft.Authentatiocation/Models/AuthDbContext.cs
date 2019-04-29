using Abp.EntityFrameworkCore;
using Abp.IdentityServer4;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiLSoft.Infrastructure.Core.Authorization.Roles;

namespace WiLSoft.Authentatiocation.Models
{
    public class AuthDbContext : AbpZeroDbContext<Tenant, Role, User, AuthDbContext>,, IAbpPersistedGrantDbContext
    {
        public DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}
