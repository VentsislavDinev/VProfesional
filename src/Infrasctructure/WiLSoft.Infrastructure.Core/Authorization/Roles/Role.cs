using Abp.Authorization.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using WiLSoft.Infrastructure.Core.Users;

namespace WiLSoft.Infrastructure.Core.Authorization.Roles
{
    public class Role : AbpRole<User>
    {
        //Can add application specific role properties here
       

        public Role()
        {

        }

        public Role(int? tenantId, string displayName)
            : base(tenantId, displayName)
        {

        }

        public Role(int? tenantId, string name, string displayName)
            : base(tenantId, name, displayName)
        {

        }
    }
}
