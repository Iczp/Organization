using IczpNet.Organization.Bases;
using IczpNet.Organization.PostRankPostGrades;
using System.Collections.Generic;

namespace IczpNet.Organization.PostGrades
{
    public class PostGrade : BaseEntity
    {
        //[Range(0, 20)]
        public virtual long Value { get; set; }

        public virtual IEnumerable<PostRankPostGrade> PostRankList { get; set; }
        
    }
}
