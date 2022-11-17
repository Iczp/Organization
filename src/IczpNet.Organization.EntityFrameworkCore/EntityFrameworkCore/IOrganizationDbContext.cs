using IczpNet.Organization.Companys;
using IczpNet.Organization.Departments;
using IczpNet.Organization.DepartmentTypes;
using IczpNet.Organization.Employees;
using IczpNet.Organization.Functionals;
using IczpNet.Organization.Positions;
using IczpNet.Organization.PostGrades;
using IczpNet.Organization.PostLevels;
using IczpNet.Organization.PostRanks;
using IczpNet.Organization.PostTypes;
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

    DbSet<Company> Company { get; }

    DbSet<Department> Department { get; }

    DbSet<DepartmentType> DepartmentType { get; }

    DbSet<Position> Position { get; }

    DbSet<Functional> Functional { get; }

    DbSet<Employee> Employee { get; }

    DbSet<PostLevel> PostLevel { get; }

    DbSet<PostGrade> PostGrade { get; }

    DbSet<PostRank> PostRank { get; }

    DbSet<PostType> PostType { get; }





}
