using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.Employees.Dtos
{
    /// <summary>
    /// EmployeeDto
    /// </summary>
    public class EmployeeDto :  IEntityDto<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Code { get; set; }
        public Guid Id { get; set; }
    }
}
