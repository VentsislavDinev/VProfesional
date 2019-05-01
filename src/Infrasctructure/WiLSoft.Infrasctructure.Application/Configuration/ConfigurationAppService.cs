using Abp.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WiLSoft.Infrasctructure.Application.Configuration.Dto;
using WiLSoft.Infrastructure.Core.Configuration;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Runtime.Session;

namespace WiLSoft.Infrasctructure.Application.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WiLSoftAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
