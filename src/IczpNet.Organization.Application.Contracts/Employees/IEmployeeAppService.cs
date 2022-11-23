using IczpNet.Organization.Employees.Dtos;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
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

        Task<PagedResultDto<EmployeeDto>> GetListByFilterIdAsync(Guid filterId, int maxResultCount = 10, int skipCount = 0, string sorting = null);

        Task<PagedResultDto<EmployeeDto>> GetListByFilterCodeAsync(string filterCode, int maxResultCount = 10, int skipCount = 0, string sorting = null);
    }
}
