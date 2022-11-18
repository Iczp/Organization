using IczpNet.Organization.Bases;
using IczpNet.Organization.Departments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.Companys
{
    public class Company : BaseTreeEntity<Company>, IMultiTenant
    {

        [MaxLength(40)]
        public virtual string CreditCode { get; set; }

        [MaxLength(40)]
        public virtual string LealPerson { get; set; }

        public virtual DateTime? RegistrationDate { get; set; }

        public virtual DateTime? FoundDate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public virtual decimal RegisteredCapital { get; set; }

        public virtual DateTime? BusinessLicenseStartDate { get; set; }

        public virtual DateTime? BusinessLicenseEndDate { get; set; }

        [MaxLength(40)]
        public virtual string InvoiceTitle { get; set; }

        [MaxLength(40)]
        public virtual string TaxNo { get; set; }

        [MaxLength(20)]
        public virtual string Phone { get; set; }

        [MaxLength(200)]
        public virtual string Address { get; set; }

        public virtual IEnumerable<Department> DepartmentList{ get; set; }
}
}
