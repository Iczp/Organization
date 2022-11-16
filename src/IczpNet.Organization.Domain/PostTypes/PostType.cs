using IczpNet.Organization.Bases;
using IczpNet.Organization.PostRanks;
using System.Collections.Generic;

namespace IczpNet.Organization.PostTypes
{
    public class PostType : BaseEntity
    {
        public virtual IEnumerable<PostRank> PostRankList { get; set; }
    }
}
