using IczpNet.Organization.Bases;
using IczpNet.Organization.Employees;
using IczpNet.Organization.Employees.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class EmployeeAppService
        : CrudOrganizationAppService<
            Employee,
            EmployeeDetailDto,
            EmployeeDto,
            Guid,
            EmployeeGetListInput,
            EmployeeCreateInput,
            EmployeeUpdateInput>,
        IEmployeeAppService
    {
        public EmployeeAppService(IRepository<Employee, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<Employee>> CreateFilteredQueryAsync(EmployeeGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                .WhereIf(!input.Keyword.IsNullOrEmpty(), x => x.Name.Contains(input.Keyword) || x.Code.Contains(input.Keyword));
        }
    }
}
