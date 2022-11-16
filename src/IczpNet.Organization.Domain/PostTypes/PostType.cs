using IczpNet.Organization.Bases;
using IczpNet.Organization.PostRanks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IczpNet.Organization.PostTypes
{
    public class PostType : BaseEntity
    {
        [MaxLength(64)]
        [Required(ErrorMessage = "[Code]不能为空")]
        public override string Code { get; set; }
        public virtual IEnumerable<PostRank> PostRankList { get; set; }
    }
}
