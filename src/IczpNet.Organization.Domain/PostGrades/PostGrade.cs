using IczpNet.Organization.Bases;
using IczpNet.Organization.PostGradePostLevels;
using IczpNet.Organization.PostRanks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IczpNet.Organization.PostGrades
{
    public class PostGrade : BaseEntity
    {
        //[Range(0, 20)]
        public virtual long Value { get; set; }
        public virtual Guid PostRankId { get; set; }

        [ForeignKey(nameof(PostRankId))]
        public virtual PostRank PostRank { get; set; }

        public virtual IEnumerable<PostGradePostLevel> LevelList { get; set; }

    }
}
