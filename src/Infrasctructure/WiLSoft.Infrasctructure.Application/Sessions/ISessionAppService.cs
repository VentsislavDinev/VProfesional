using Abp.Application.Services;
using System.Threading.Tasks;
using WiLSoft.Infrasctructure.Application.Sessions.Dto;

namespace WiLSoft.Infrasctructure.Application.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
