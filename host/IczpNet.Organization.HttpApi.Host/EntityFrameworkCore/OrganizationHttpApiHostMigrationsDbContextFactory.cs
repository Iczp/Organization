using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IczpNet.Organization.EntityFrameworkCore;

public class OrganizationHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<OrganizationHttpApiHostMigrationsDbContext>
{
    public OrganizationHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<OrganizationHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Organization"));

        return new OrganizationHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
