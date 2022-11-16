using IczpNet.Organization.Departments;
using IczpNet.Organization.DepartmentTypes;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace IczpNet.Organization.EntityFrameworkCore;

[ConnectionStringName(OrganizationDbProperties.ConnectionStringName)]
public interface IOrganizationDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
    DbSet<Department> Department { get; }
    DbSet<DepartmentType> DepartmentType { get; }
}
