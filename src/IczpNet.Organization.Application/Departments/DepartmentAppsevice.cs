using IczpNet.AbpTrees;
using IczpNet.Organization.Departments.Dtos;
using System;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Departments
{
    public class DepartmentAppService 
        : TreeAppService<
            Department, 
            DepartmentDetailDto, 
            DepartmentDto, 
            DepartmentGetListInput, 
            DepartmentCreateInput, 
            DepartmentUpdateInput, 
            DepartmentInfo, 
            DepartmentWithChildsDto, 
            DepartmentWithParentDto>, 
        IDepartmentAppSevice
    {
        public DepartmentAppService(IRepository<Department, Guid> repository) : base(repository)
        {
        }
    }
}
