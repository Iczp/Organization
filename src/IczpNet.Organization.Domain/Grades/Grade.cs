using IczpNet.Organization.Bases;
using System;

namespace IczpNet.Organization.Grades
{
    public class Grade : BaseEntity
    {
        public virtual int Value { get; set; }

        //public virtual Guid PostRankId { get; set; }

        //[ForeignKey(nameof(PostRankId))]
        //public virtual PostRank PostRank { get; set; }
    }
}
