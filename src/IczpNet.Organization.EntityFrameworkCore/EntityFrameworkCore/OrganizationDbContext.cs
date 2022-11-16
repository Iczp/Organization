using IczpNet.Organization.Departments;
using IczpNet.Organization.DepartmentTypes;
using IczpNet.Organization.Employees;
using IczpNet.Organization.Positions;
using IczpNet.Organization.PostGrades;
using IczpNet.Organization.PostRanks;
using IczpNet.Organization.PostTypes;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace IczpNet.Organization.EntityFrameworkCore;

[ConnectionStringName(OrganizationDbProperties.ConnectionStringName)]
public class OrganizationDbContext : AbpDbContext<OrganizationDbContext>, IOrganizationDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public virtual DbSet<Department> Department { get; }
    public virtual DbSet<DepartmentType> DepartmentType { get; }
    public virtual DbSet<Position> Position { get; }
    public virtual DbSet<Employee> Employee { get; }
    public virtual DbSet<PostGrade> PostGrade { get; }
    public virtual DbSet<PostRank> PostRank { get; }
    public virtual DbSet<PostType> PostType { get; }

    public OrganizationDbContext(DbContextOptions<OrganizationDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureOrganization();
    }
}
