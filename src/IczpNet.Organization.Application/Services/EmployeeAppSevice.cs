using IczpNet.Organization.BaseEntitys;
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


        protected IEmployeeManager EmployeeManager { get; }

        public EmployeeAppService(
            IRepository<Employee, Guid> repository,
            IEmployeeManager employeeManager) : base(repository)
        {
            EmployeeManager = employeeManager;
        }

        protected override Task<IQueryable<Employee>> CreateFilteredQueryAsync(EmployeeGetListInput input)
        {
            return EmployeeManager.CreateFilteredQueryAsync(input);
        }
    }
}
