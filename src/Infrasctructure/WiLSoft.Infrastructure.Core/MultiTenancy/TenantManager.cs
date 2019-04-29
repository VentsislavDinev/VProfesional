using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using System;
using System.Collections.Generic;
using System.Text;
using WiLSoft.Infrastructure.Core.Editions;
using WiLSoft.Infrastructure.Core.Users;

namespace WiLSoft.Infrastructure.Core.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository,
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository,
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            )
            : base(
                tenantRepository,
                tenantFeatureRepository,
                editionManager,
                featureValueStore
            )
        {
        }
    }
}
