using IczpNet.AbpCommons.DataFilters;
using IczpNet.Organization.PostGrades;
using IczpNet.Organization.PostRanks;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace IczpNet.Organization.PostRankPostGrades
{
    public class PostRankPostGrade : FullAuditedAggregateRoot, IName, ICode
    {
        [MaxLength(64)]
        public virtual string Name { get; set; }

        [MaxLength(64)]
        public virtual string Code { get; set; }

        public virtual Guid PostRankId { get; set; }

        public virtual Guid PostGradeId { get; set; }

        [ForeignKey(nameof(PostRankId))]
        public virtual PostRank PostRank { get; set; }

        [ForeignKey(nameof(PostGradeId))]
        public virtual PostGrade PostGrade { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { PostRankId, PostGradeId };
        }

        public PostRankPostGrade(PostRank postRank, PostGrade postGrade)
        {
            PostRank = postRank;
            PostGrade = postGrade;
            Name= postRank.Name + postGrade.Value;
        }
    }
}
