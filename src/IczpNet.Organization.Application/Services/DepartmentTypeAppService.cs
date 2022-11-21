using IczpNet.Organization.Bases;
using IczpNet.Organization.DepartmentTypes;
using IczpNet.Organization.DepartmentTypes.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class DepartmentTypeAppService
        : CrudTreeOrganizationAppService<
            DepartmentType,
            DepartmentTypeDetailDto,
            DepartmentTypeDto,
            DepartmentTypeGetListInput,
            DepartmentTypeCreateInput,
            DepartmentTypeUpdateInput,
            DepartmentTypeInfo,
            DepartmentTypeWithChildsDto,
            DepartmentTypeWithParentDto>,
        IDepartmentTypeAppService
    {
        public DepartmentTypeAppService(IRepository<DepartmentType, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<DepartmentType>> CreateFilteredQueryAsync(DepartmentTypeGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                //.WhereIf(input.DepartmentTypeTypeId.HasValue, x => x.DepartmentTypelList == input.DepartmentTypeTypeId)
                ;
        }
    }
}
