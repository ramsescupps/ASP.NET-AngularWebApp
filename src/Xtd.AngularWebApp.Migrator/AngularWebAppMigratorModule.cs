using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Xtd.AngularWebApp.Configuration;
using Xtd.AngularWebApp.EntityFrameworkCore;
using Xtd.AngularWebApp.Migrator.DependencyInjection;

namespace Xtd.AngularWebApp.Migrator
{
    [DependsOn(typeof(AngularWebAppEntityFrameworkModule))]
    public class AngularWebAppMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AngularWebAppMigratorModule(AngularWebAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AngularWebAppMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AngularWebAppConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AngularWebAppMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
