using IczpNet.Organization.Employees.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.Employees
{
    public interface IEmployeeAppService :
        ICrudAppService<
            EmployeeDetailDto,
            EmployeeDto,
            Guid,
            EmployeeGetListInput,
            EmployeeCreateInput,
            EmployeeUpdateInput>
    {
    }
}
