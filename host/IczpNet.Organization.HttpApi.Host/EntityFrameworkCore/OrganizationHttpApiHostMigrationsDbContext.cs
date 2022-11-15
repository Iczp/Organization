using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace IczpNet.Organization.EntityFrameworkCore;

public class OrganizationHttpApiHostMigrationsDbContext : AbpDbContext<OrganizationHttpApiHostMigrationsDbContext>
{
    public OrganizationHttpApiHostMigrationsDbContext(DbContextOptions<OrganizationHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureOrganization();
    }
}
