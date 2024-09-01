using System.Threading.Tasks;
using Xtd.AngularWebApp.Configuration.Dto;

namespace Xtd.AngularWebApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
