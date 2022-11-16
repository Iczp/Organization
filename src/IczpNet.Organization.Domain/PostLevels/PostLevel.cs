using IczpNet.Organization.Bases;
using IczpNet.Organization.PostGradePostLevels;
using System;
using System.Collections.Generic;

namespace IczpNet.Organization.PostLevels
{
    public class PostLevel : BaseEntity<Guid>
    {
        public virtual bool IsStatic { get; set; }
        //[Range(0, 20)]
        public virtual long Value { get; set; }

        public virtual IEnumerable<PostGradePostLevel> LevelList { get; set; }
    }
}
