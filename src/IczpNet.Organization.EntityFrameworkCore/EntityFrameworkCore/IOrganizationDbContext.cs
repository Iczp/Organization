using IczpNet.Organization.Companys;
using IczpNet.Organization.CompanyTypes;
using IczpNet.Organization.Departments;
using IczpNet.Organization.DepartmentTypes;
using IczpNet.Organization.EmployeeFilters;
using IczpNet.Organization.Employees;
using IczpNet.Organization.EmployeeStates;
using IczpNet.Organization.EmployeeTypes;
using IczpNet.Organization.Functionals;
using IczpNet.Organization.Positions;
using IczpNet.Organization.PositionTypes;
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

    DbSet<CompanyType> CompanyType { get; }

    DbSet<Department> Department { get; }

    DbSet<DepartmentType> DepartmentType { get; }

    DbSet<Position> Position { get; }

    DbSet<PositionType> PositionType { get; }

    DbSet<Functional> Functional { get; }

    DbSet<Employee> Employee { get; }

    DbSet<EmployeeFilter> EmployeeFilter { get; }

    DbSet<EmployeeState> EmployeeState { get; }

    DbSet<EmployeeType> EmployeeType { get; }

    DbSet<PostLevel> PostLevel { get; }

    DbSet<PostGrade> PostGrade { get; }

    DbSet<PostRank> PostRank { get; }

    DbSet<PostType> PostType { get; }





}
