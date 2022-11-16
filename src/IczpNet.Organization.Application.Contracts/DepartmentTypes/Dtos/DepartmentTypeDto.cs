using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.DepartmentTypes.Dtos
{
    /// <summary>
    /// DepartmentDto
    /// </summary>
    public class DepartmentTypeDto :  IEntityDto<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Code { get; set; }
        public virtual bool IsStatic { get; set; }
        public Guid Id { get; set; }
    }
}
