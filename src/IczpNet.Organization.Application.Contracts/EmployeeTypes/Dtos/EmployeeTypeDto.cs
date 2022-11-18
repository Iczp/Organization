﻿using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.EmployeeTypes.Dtos
{
    /// <summary>
    /// DepartmentDto
    /// </summary>
    public class EmployeeTypeDto :  IEntityDto<Guid>
    {
        public virtual string Name { get; set; }

        public virtual string Code { get; set; }

        public virtual bool IsStatic { get; set; }

        public virtual bool IsActive { get; set; }

        public Guid Id { get; set; }
    }
}