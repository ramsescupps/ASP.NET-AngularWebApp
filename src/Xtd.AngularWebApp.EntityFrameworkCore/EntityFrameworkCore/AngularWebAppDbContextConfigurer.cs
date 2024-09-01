using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Xtd.AngularWebApp.EntityFrameworkCore
{
    public static class AngularWebAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AngularWebAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AngularWebAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
