using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiLSoft.Infrastructure.Core.Editions;
using WiLSoft.Infrastructure.Core.MultiTenancy;

namespace WiLSoft.Authentatiocation.Models.Seed.Tenants
{
    public class DefaultTenantBuilder
    {
        private readonly AuthDbContext _context;

        public DefaultTenantBuilder(AuthDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultTenant();
        }

        private void CreateDefaultTenant()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                defaultTenant = new Tenant(Tenant.DefaultTenantName, Tenant.DefaultTenantName);

                var defaultEdition = _context.Editions.FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
                if (defaultEdition != null)
                {
                    defaultTenant.EditionId = defaultEdition.Id;
                }

                _context.Tenants.Add(defaultTenant);
                _context.SaveChanges();
            }
        }
    }
}
