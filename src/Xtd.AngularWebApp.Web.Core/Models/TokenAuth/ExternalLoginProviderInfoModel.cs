using Abp.AutoMapper;
using Xtd.AngularWebApp.Authentication.External;

namespace Xtd.AngularWebApp.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
