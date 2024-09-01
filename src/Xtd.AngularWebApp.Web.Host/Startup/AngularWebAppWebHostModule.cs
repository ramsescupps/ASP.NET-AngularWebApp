using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Xtd.AngularWebApp.Configuration;

namespace Xtd.AngularWebApp.Web.Host.Startup
{
    [DependsOn(
       typeof(AngularWebAppWebCoreModule))]
    public class AngularWebAppWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AngularWebAppWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AngularWebAppWebHostModule).GetAssembly());
        }
    }
}
