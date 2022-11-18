﻿using IczpNet.Organization.Bases;
using IczpNet.Organization.EmployeeTypes;
using IczpNet.Organization.EmployeeTypes.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Services
{
    public class EmployeeTypeAppService
        : CrudOrganizationAppService<
            EmployeeType,
            EmployeeTypeDetailDto,
            EmployeeTypeDto,
            Guid,
            EmployeeTypeGetListInput,
            EmployeeTypeCreateInput,
            EmployeeTypeUpdateInput>,
        IEmployeeTypeAppService
    {
        public EmployeeTypeAppService(IRepository<EmployeeType, Guid> repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<EmployeeType>> CreateFilteredQueryAsync(EmployeeTypeGetListInput input)
        {
            return (await base.CreateFilteredQueryAsync(input))
                .WhereIf(!input.Keyword.IsNullOrEmpty(), x => x.Name.Contains(input.Keyword) || x.Code.Contains(input.Keyword));
        }
    }
}