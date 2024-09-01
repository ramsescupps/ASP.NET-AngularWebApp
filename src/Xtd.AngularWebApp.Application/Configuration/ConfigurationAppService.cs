using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Xtd.AngularWebApp.Configuration.Dto;

namespace Xtd.AngularWebApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AngularWebAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
