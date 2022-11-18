using IczpNet.Organization.EmployeeTypes.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.EmployeeTypes
{
    public interface IEmployeeTypeAppService :
        ICrudAppService<
            EmployeeTypeDetailDto,
            EmployeeTypeDto,
            Guid,
            EmployeeTypeGetListInput,
            EmployeeTypeCreateInput,
            EmployeeTypeUpdateInput>
    {
    }
}
