using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Xtd.AngularWebApp.Configuration;
using Xtd.AngularWebApp.Web;

namespace Xtd.AngularWebApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AngularWebAppDbContextFactory : IDesignTimeDbContextFactory<AngularWebAppDbContext>
    {
        public AngularWebAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AngularWebAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AngularWebAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AngularWebAppConsts.ConnectionStringName));

            return new AngularWebAppDbContext(builder.Options);
        }
    }
}
