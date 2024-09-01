using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Xtd.AngularWebApp.Authorization;
using Xtd.AngularWebApp.Authorization.Roles;
using Xtd.AngularWebApp.Authorization.Users;
using Xtd.AngularWebApp.Editions;
using Xtd.AngularWebApp.MultiTenancy;

namespace Xtd.AngularWebApp.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
