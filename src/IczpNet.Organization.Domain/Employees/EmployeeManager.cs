using IczpNet.AbpCommons;
using IczpNet.AbpCommons.Extensions;
using IczpNet.Organization.Departments;
using IczpNet.Organization.EmployeeFilters;
using IczpNet.Organization.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace IczpNet.Organization.Employees
{
    public class EmployeeManager : DomainService, IEmployeeManager
    {
        protected IDepartmentManager DepartmentManager { get; }
        protected IPositionManager PositionManager { get; }

        protected IReadOnlyRepository<EmployeeFilter> EmployeeFilterReadOnlyRepository { get; }

        protected IReadOnlyRepository<Employee> ReadOnlyRepository { get; }

        public EmployeeManager(
            IReadOnlyRepository<Employee> readOnlyRepository,
            IDepartmentManager departmentManager,
            IPositionManager positionManager,
            IReadOnlyRepository<EmployeeFilter> employeeFilterReadOnlyRepository)
        {
            ReadOnlyRepository = readOnlyRepository;
            DepartmentManager = departmentManager;
            PositionManager = positionManager;
            EmployeeFilterReadOnlyRepository = employeeFilterReadOnlyRepository;
        }


        public async Task<IQueryable<Employee>> CreateFilteredQueryAsync<T>(T filter) where T : EmployeeFilterParameter
        {
            //Department
            IQueryable<Guid> depIdQuery = null;

            if (filter.IsImportChildDepartment && filter.DepartmentIdList.IsAny())
            {
                depIdQuery = (await DepartmentManager.QueryCurrentAndAllChildsAsync(filter.DepartmentIdList)).Select(x => x.Id);
            }

            //Position
            IQueryable<Guid> positionIdQuery = null;

            if (filter.IsImportChildPosition && filter.PostionIdList.IsAny())
            {
                positionIdQuery = (await PositionManager.QueryCurrentAndAllChildsAsync(filter.PostionIdList)).Select(x => x.Id);
            }

            return (await ReadOnlyRepository.GetQueryableAsync())
                .WhereIf(filter.EmployeeTypeIdList.IsAny(), x => filter.EmployeeTypeIdList.Contains(x.EmployeeTypeId.Value))
                .WhereIf(filter.EmployeeStateIdList.IsAny(), x => filter.EmployeeStateIdList.Contains(x.EmployeeStateId.Value))
                .WhereIf(filter.PostGradeIdList.IsAny(), x => filter.PostGradeIdList.Contains(x.PostGradeId.Value))
                //Department
                .WhereIf(!filter.IsImportChildDepartment && filter.DepartmentIdList.IsAny(), x => filter.DepartmentIdList.Contains(x.DepartmentId.Value))
                .WhereIf(filter.IsImportChildDepartment && filter.DepartmentIdList.IsAny(), x => depIdQuery.Contains(x.DepartmentId.Value))
                //Position
                .WhereIf(!filter.IsImportChildPosition && filter.PostionIdList.IsAny(), x => x.PositionList.Any(d => filter.PostionIdList.Contains(d.PositionId)))
                .WhereIf(filter.IsImportChildPosition && filter.PostionIdList.IsAny(), x => x.PositionList.Any(d => positionIdQuery.Contains(d.PositionId)))

                .WhereIf(filter.IsActive.HasValue, x => x.IsActive == filter.IsActive.Value)
                .WhereIf(filter.IsStatic.HasValue, x => x.IsStatic == filter.IsStatic.Value)
                .WhereIf(!filter.Keyword.IsNullOrEmpty(), x => x.Name.Contains(filter.Keyword) || x.Name_Pinyin.Contains(filter.Keyword) || x.Name_Py.Contains(filter.Keyword) || x.Code.Contains(filter.Keyword));
        }

        public async Task<List<Employee>> GetFilteredPagedResultAsync<T>(T filter, int maxResultCount = 10, int skipCount = 0, string sorting = null) where T : EmployeeFilterParameter
        {
            var query = await CreateFilteredQueryAsync(filter);

            var entities = await GetFilteredPagedResultAsync(query, maxResultCount, skipCount, sorting);

            return entities;
        }

        public async Task<List<Employee>> GetFilteredPagedResultAsync(IQueryable<Employee> query, int maxResultCount = 10, int skipCount = 0, string sorting = null)
        {
            if (!sorting.IsNullOrWhiteSpace())
            {
                query = query.OrderBy(sorting);
            }

            query = query.PageBy(skipCount, maxResultCount);

            var entities = await AsyncExecuter.ToListAsync(query);

            return entities;
        }

        public async Task<int> GetFilteredCountAsync<T>(T filter) where T : EmployeeFilterParameter
        {
            var query = await CreateFilteredQueryAsync(filter);

            var totalCount = await AsyncExecuter.CountAsync(query);

            return totalCount;
        }

        public async Task<EmployeeFilter> GetFilterByIdAsync(Guid filterId)
        {
            return Assert.NotNull(await EmployeeFilterReadOnlyRepository.FirstOrDefaultAsync(x => x.Id == filterId), $"no such entity by id:{filterId}");
        }

        public async Task<EmployeeFilter> GetFilterByCodeAsync(string filterCode)
        {
            return Assert.NotNull(await EmployeeFilterReadOnlyRepository.FirstOrDefaultAsync(x => x.Code == filterCode), $"no such entity by code:{filterCode}");
        }
    }
}
