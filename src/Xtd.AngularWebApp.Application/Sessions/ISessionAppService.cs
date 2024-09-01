using System.Threading.Tasks;
using Abp.Application.Services;
using Xtd.AngularWebApp.Sessions.Dto;

namespace Xtd.AngularWebApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
