using Abp.Application.Services;
using System.Threading.Tasks;
using WiLSoft.Infrasctructure.Application.Roles.Dto;

namespace WiLSoft.Infrasctructure.Application.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
