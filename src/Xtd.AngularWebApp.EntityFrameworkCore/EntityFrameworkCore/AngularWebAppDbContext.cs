using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Xtd.AngularWebApp.Authorization.Roles;
using Xtd.AngularWebApp.Authorization.Users;
using Xtd.AngularWebApp.MultiTenancy;

namespace Xtd.AngularWebApp.EntityFrameworkCore
{
    public class AngularWebAppDbContext : AbpZeroDbContext<Tenant, Role, User, AngularWebAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AngularWebAppDbContext(DbContextOptions<AngularWebAppDbContext> options)
            : base(options)
        {
        }
    }
}
