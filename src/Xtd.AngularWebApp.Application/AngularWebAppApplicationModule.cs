using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Xtd.AngularWebApp.Authorization;

namespace Xtd.AngularWebApp
{
    [DependsOn(
        typeof(AngularWebAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AngularWebAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AngularWebAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AngularWebAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
