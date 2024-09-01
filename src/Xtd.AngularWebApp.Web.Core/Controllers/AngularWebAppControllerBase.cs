using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Xtd.AngularWebApp.Controllers
{
    public abstract class AngularWebAppControllerBase: AbpController
    {
        protected AngularWebAppControllerBase()
        {
            LocalizationSourceName = AngularWebAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
