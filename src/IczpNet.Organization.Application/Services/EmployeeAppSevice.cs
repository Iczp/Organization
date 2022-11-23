using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.EmployeeFilters;
using IczpNet.Organization.Employees;
using IczpNet.Organization.Employees.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
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

        protected IRepository<EmployeeFilter, Guid> EmployeeFilterRepository { get; }

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

        protected virtual async Task<PagedResultDto<EmployeeDto>> GetListByFilterAsync(EmployeeFilterParameter filterParameter, int maxResultCount = 10, int skipCount = 0, string sorting = null)
        {
            var list = await EmployeeManager.GetFilteredPagedResultAsync(filterParameter, maxResultCount, skipCount, sorting);

            var totalCount = await EmployeeManager.GetFilteredCountAsync(filterParameter);

            var items = ObjectMapper.Map<List<Employee>, List<EmployeeDto>>(list);

            return new PagedResultDto<EmployeeDto>(totalCount, items);
        }

        protected virtual async Task<EmployeeFilterParameter> GetFilterParameterAsync(Guid filterId)
        {
            var filter = await EmployeeManager.GetFilterByIdAsync(filterId);

            return filter.GetFilterParameter();
        }

        protected virtual async Task<EmployeeFilterParameter> GetFilterParameterAsync(string filterCode)
        {
            var filter = await EmployeeManager.GetFilterByCodeAsync(filterCode);

            return filter.GetFilterParameter();
        }

        [HttpGet]
        public virtual async Task<PagedResultDto<EmployeeDto>> GetListByFilterIdAsync(Guid filterId, int maxResultCount = 10, int skipCount = 0, string sorting = null)
        {
            var filterParameter = await GetFilterParameterAsync(filterId);

            return await GetListByFilterAsync(filterParameter, maxResultCount, skipCount, sorting);
        }

        [HttpGet]
        public virtual async Task<PagedResultDto<EmployeeDto>> GetListByFilterCodeAsync(string filterCode, int maxResultCount = 10, int skipCount = 0, string sorting = null)
        {
            var filterParameter = await GetFilterParameterAsync(filterCode);

            return await GetListByFilterAsync(filterParameter, maxResultCount, skipCount, sorting);
        }
    }
}
