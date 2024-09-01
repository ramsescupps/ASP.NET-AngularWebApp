using Abp.MultiTenancy;
using Xtd.AngularWebApp.Authorization.Users;

namespace Xtd.AngularWebApp.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
