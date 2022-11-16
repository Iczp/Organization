using IczpNet.AbpTrees;
using IczpNet.Organization.Departments.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace IczpNet.Organization.Departments
{
    public interface IDepartmentAppSevice :
        ICrudAppService<
            DepartmentDetailDto,
            DepartmentDto,
            Guid,
            DepartmentGetListInput,
            DepartmentCreateInput,
            DepartmentUpdateInput>
        , ITreeAppService<
            DepartmentInfo,
            DepartmentWithChildsDto,
            DepartmentWithParentDto>
    {
    }
}
