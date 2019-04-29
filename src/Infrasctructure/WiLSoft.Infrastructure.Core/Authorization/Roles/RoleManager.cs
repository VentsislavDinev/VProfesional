using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Organizations;
using Abp.Runtime.Caching;
using Abp.Zero.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using WiLSoft.Infrastructure.Core.Users;

namespace WiLSoft.Infrastructure.Core.Authorization.Roles
{
    public class RoleManager : AbpRoleManager<Role, User>
    {
        public RoleManager(
            RoleStore store,
            IPermissionManager permissionManager,
            IRoleManagementConfig roleManagementConfig,
            ICacheManager cacheManager,
            IUnitOfWorkManager unitOfWorkManager,
            IRepository<OrganizationUnit, long> organizationUnit,
            IRepository<OrganizationUnitRole, long> organizationUnitRole)
            : base(
                store,
                permissionManager,
                roleManagementConfig,
                cacheManager,
                unitOfWorkManager,
                organizationUnit,
                organizationUnitRole)
        {
        }
    }
}
