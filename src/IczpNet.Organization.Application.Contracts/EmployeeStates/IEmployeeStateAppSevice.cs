using IczpNet.Organization.EmployeeStates.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.EmployeeStates
{
    public interface IEmployeeStateAppService :
        ICrudAppService<
            EmployeeStateDetailDto,
            EmployeeStateDto,
            Guid,
            EmployeeStateGetListInput,
            EmployeeStateCreateInput,
            EmployeeStateUpdateInput>
    {
    }
}
