﻿using IczpNet.AbpTrees;
using System;
using Volo.Abp.Domain.Repositories;

namespace IczpNet.Organization.Departments
{
    public class DepartmentManager : TreeManager<Department, Guid>, IDepartmentManager
    {
        public DepartmentManager(IRepository<Department, Guid> repository) : base(repository)
        {
        }
    }
}
