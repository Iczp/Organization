using IczpNet.AbpCommons.DataFilters;
using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.Employees;
using IczpNet.Organization.PostGradePostLevels;
using IczpNet.Organization.PostLevels;
using IczpNet.Organization.PostRanks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IczpNet.Organization.PostGrades
{
    public class PostGrade : BaseEntity<Guid>, IIsStatic
    {
        [MaxLength(64)]
        [Required(ErrorMessage = "[Code]不能为空")]
        public override string Code { get; set; }

        //[Range(0, 20)]
        public virtual long Value { get; set; }

        public virtual Guid PostRankId { get; set; }

        public virtual Guid? PostLevelId { get; set; }

        [ForeignKey(nameof(PostRankId))]
        public virtual PostRank PostRank { get; set; }

        [ForeignKey(nameof(PostLevelId))]
        public virtual PostLevel PostLevel { get; set; }

        public virtual IEnumerable<PostGradePostLevel> LevelList { get; set; }

        public virtual IEnumerable<Employee> EmployeeList { get; private set; } = new List<Employee>();

    }
}
