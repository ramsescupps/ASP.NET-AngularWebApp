using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Xtd.AngularWebApp.MultiTenancy.Dto;

namespace Xtd.AngularWebApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

