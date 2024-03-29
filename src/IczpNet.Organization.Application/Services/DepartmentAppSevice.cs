﻿using IczpNet.Organization.Bases;
using IczpNet.Organization.Departments;
using IczpNet.Organization.Departments.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class DepartmentAppService
        : CrudTreeOrganizationAppService<
            Department, 
            Guid,
            DepartmentDetailDto,
            DepartmentDto,
            DepartmentGetListInput,
            DepartmentCreateInput,
            DepartmentUpdateInput,
            DepartmentInfo>,
        IDepartmentAppService
    {
        public DepartmentAppService(IRepository<Department, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<Department>> CreateFilteredQueryAsync(DepartmentGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                //.WhereIf(input.DepartmentTypeId.HasValue, x => x.DepartmentTypeId == input.DepartmentTypeId)
                ;
        }
    }
}
