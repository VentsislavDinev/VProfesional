using System.Threading.Tasks;
using WiLSoft.Infrasctructure.Application.Configuration.Dto;

namespace WiLSoft.Infrasctructure.Application.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
