using Abp.MultiTenancy;
using System;
using System.Collections.Generic;
using System.Text;
using WiLSoft.Infrastructure.Core.Users;

namespace WiLSoft.Infrastructure.Core.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {

        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
