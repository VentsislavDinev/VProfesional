using Abp.Auditing;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WiLSoft.Infrasctructure.Application.Sessions.Dto;
using WiLSoft.Infrasctructure.Application.SignalR;
using WiLSoft.Infrastructure.Core;

namespace WiLSoft.Infrasctructure.Application.Sessions
{
    public class SessionAppService : WiLSoftAppServiceBase, ISessionAppService
    {
        [DisableAuditing]
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
        {
            var output = new GetCurrentLoginInformationsOutput
            {
                Application = new ApplicationInfoDto
                {
                    Version = AppVersionHelper.Version,
                    ReleaseDate = AppVersionHelper.ReleaseDate,
                    Features = new Dictionary<string, bool>
                    {
                        { "SignalR", SignalRFeature.IsAvailable }
                    }
                }
            };

            if (AbpSession.TenantId.HasValue)
            {
                output.Tenant = ObjectMapper.Map<TenantLoginInfoDto>(await GetCurrentTenantAsync());
            }

            if (AbpSession.UserId.HasValue)
            {
                output.User = ObjectMapper.Map<UserLoginInfoDto>(await GetCurrentUserAsync());
            }

            return output;
        }
    }
}
