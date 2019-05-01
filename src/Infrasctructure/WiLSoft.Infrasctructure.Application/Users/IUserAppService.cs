
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using WiLSoft.Infrasctructure.Application.Users.Dto;

namespace WiLSoft.Infrasctructure.Application.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);

        Task<ListResultDto<UserListDto>> GetUsers();

        Task CreateUser(CreateUserInput input);
    }
}
