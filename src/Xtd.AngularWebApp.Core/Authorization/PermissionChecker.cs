using Abp.Authorization;
using Xtd.AngularWebApp.Authorization.Roles;
using Xtd.AngularWebApp.Authorization.Users;

namespace Xtd.AngularWebApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
