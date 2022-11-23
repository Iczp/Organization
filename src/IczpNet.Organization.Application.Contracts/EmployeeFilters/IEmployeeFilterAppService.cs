using IczpNet.Organization.EmployeeFilters.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        Task<DateTime> UpdateFilteredResultAsync(List<Guid> filterIdList);

        Task<DateTime> UpdateAllFilteredResultAsync();
    }
}
