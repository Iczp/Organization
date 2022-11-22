using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace IczpNet.Organization.Employees
{
    public interface IEmployeeManager : IDomainService
    {
        Task<IQueryable<Employee>> CreateFilteredQueryAsync<T>(T filter) where T : EmployeeFilterInput;

        Task<List<Employee>> GetFilteredPagedResultAsync<T>(T filter, int maxResultCount = 10, int skipCount = 0, string sorting = null) where T : EmployeeFilterInput;

        Task<List<Employee>> GetFilteredPagedResultAsync(IQueryable<Employee> query, int maxResultCount = 10, int skipCount = 0, string sorting = null);

        Task<int> GetFilteredCountAsync<T>(T filter) where T : EmployeeFilterInput;
    }
}
