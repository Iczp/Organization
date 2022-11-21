using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.PostGradePostLevels;
using IczpNet.Organization.PostGrades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace IczpNet.Organization.PostLevels
{
    public class PostLevel : BaseEntity<Guid>
    {
        //[Range(0, 20)]
        public virtual long Value { get; set; }

        [NotMapped]
        public virtual int PostGradeCount => PostGradeList.Count();

        public virtual IEnumerable<PostGrade> PostGradeList { get; set; } = new List<PostGrade>();

        public virtual IEnumerable<PostGradePostLevel> PostGradePostLevelList { get; set; }
    }
}
