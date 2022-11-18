using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.DepartmentTypes;
using IczpNet.Organization.DepartmentTypes.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class DepartmentTypeAppService
        : CrudOrganizationAppService<
            DepartmentType,
            DepartmentTypeDetailDto,
            DepartmentTypeDto,
            Guid,
            DepartmentTypeGetListInput,
            DepartmentTypeCreateInput,
            DepartmentTypeUpdateInput>,
        IDepartmentTypeAppService
    {
        public DepartmentTypeAppService(IRepository<DepartmentType, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<DepartmentType>> CreateFilteredQueryAsync(DepartmentTypeGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                .WhereIf(!input.Keyword.IsNullOrEmpty(), x => x.Name.Contains(input.Keyword) || x.Code.Contains(input.Keyword));
        }
    }
}
