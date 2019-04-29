using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Organizations;
using WiLSoft.Infrastructure.Core.Authorization.Roles;

namespace WiLSoft.Infrastructure.Core.Users
{
    public class UserStore : AbpUserStore<Role, User>
    {
        public UserStore(
            IRepository<User, long> userRepository,
            IRepository<UserLogin, long> userLoginRepository,
            IRepository<UserRole, long> userRoleRepository,
            IRepository<Role> roleRepository,
            IRepository<UserPermissionSetting, long> userPermissionSettingRepository,
            IUnitOfWorkManager unitOfWorkManager,
            IRepository<UserClaim, long> userClaimStore,
            IRepository<UserOrganizationUnit, long> organizationUnit,
            IRepository<OrganizationUnitRole, long> organizationUnitRole)
            : base(
              userRepository,
              userLoginRepository,
              userRoleRepository,
              roleRepository,
              userPermissionSettingRepository,
              unitOfWorkManager,
              userClaimStore,
              organizationUnit,
              organizationUnitRole)
        {
        }
    }
}
