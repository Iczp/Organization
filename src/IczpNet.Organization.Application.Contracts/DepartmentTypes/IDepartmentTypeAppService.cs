using IczpNet.AbpTrees;
using IczpNet.Organization.DepartmentTypes.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.DepartmentTypes
{
    public interface IDepartmentTypeAppService :
        ICrudAppService<
            DepartmentTypeDetailDto,
            DepartmentTypeDto,
            Guid,
            DepartmentTypeGetListInput,
            DepartmentTypeCreateInput,
            DepartmentTypeUpdateInput>
        ,
        ITreeAppService<DepartmentTypeInfo>
    {
    }
}
