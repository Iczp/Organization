using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.Companys;
using IczpNet.Organization.DepartmentFunctionals;
using IczpNet.Organization.DepartmentPositions;
using IczpNet.Organization.DepartmentTypes;
using IczpNet.Organization.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.Departments
{
    public class Department : BaseTreeEntity<Department>, IMultiTenant
    {
        public virtual Guid? CompanyId { get; set; }

        public virtual Guid? DepartmentTypeId { get; set; }

        [ForeignKey(nameof(CompanyId))]
        public virtual Company Company { get; set; }

        [ForeignKey(nameof(DepartmentTypeId))]
        public virtual DepartmentType DepartmentType { get; set; }

        public virtual IEnumerable<Employee> EmployeeList { get; set; }

        public virtual IEnumerable<DepartmentFunctional> FunctionalList { get; set; }

        public virtual IEnumerable<DepartmentPosition> PositionlList { get; set; }
        
    }
}
