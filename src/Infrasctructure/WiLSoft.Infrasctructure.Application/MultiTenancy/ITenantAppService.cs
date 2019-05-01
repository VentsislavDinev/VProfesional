using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using WiLSoft.Infrasctructure.Application.MultiTenancy.Dto;

namespace WiLSoft.Infrasctructure.Application.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
