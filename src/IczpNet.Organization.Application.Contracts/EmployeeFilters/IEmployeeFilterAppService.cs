using IczpNet.Organization.EmployeeFilters.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.EmployeeFilters
{
    public interface IEmployeeFilterAppService :
        ICrudAppService<
            EmployeeFilterDetailDto,
            EmployeeFilterDto,
            Guid,
            EmployeeFilterGetListInput,
            EmployeeFilterCreateInput,
            EmployeeFilterUpdateInput>
    {
    }
}
