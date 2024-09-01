using Abp.Application.Services.Dto;

namespace Xtd.AngularWebApp.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

