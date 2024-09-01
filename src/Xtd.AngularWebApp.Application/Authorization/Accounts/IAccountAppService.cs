using System.Threading.Tasks;
using Abp.Application.Services;
using Xtd.AngularWebApp.Authorization.Accounts.Dto;

namespace Xtd.AngularWebApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
