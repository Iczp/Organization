using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.Employees.Dtos
{
    public class EmployeeDto :  IEntityDto<Guid>
    {
        public Guid Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Code { get; set; }

        public virtual Guid? DepartmentId { get; set; }

        public virtual Guid? EmployeeStateId { get; set; }

        public virtual Guid? EmployeeTypeId { get; set; }

        public virtual Guid? PostGradeId { get; set; }

        public virtual List<Guid> PostionIdList { get; set; }

        public virtual double Sorting { get; set; }

        public virtual bool IsActive { get; set; }
    }
}
