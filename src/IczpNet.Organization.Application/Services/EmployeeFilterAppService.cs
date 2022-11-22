using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.EmployeeFilters;
using IczpNet.Organization.EmployeeFilters.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class EmployeeFilterAppService
        : CrudOrganizationAppService<
            EmployeeFilter,
            EmployeeFilterDetailDto,
            EmployeeFilterDto,
            Guid,
            EmployeeFilterGetListInput,
            EmployeeFilterCreateInput,
            EmployeeFilterUpdateInput>,
        IEmployeeFilterAppService
    {
        public EmployeeFilterAppService(IRepository<EmployeeFilter, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<EmployeeFilter>> CreateFilteredQueryAsync(EmployeeFilterGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                .WhereIf(!input.Keyword.IsNullOrEmpty(), x => x.Name.Contains(input.Keyword) || x.Code.Contains(input.Keyword));
        }
    }
}
