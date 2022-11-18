using IczpNet.Organization.BaseDtos;
using System;

namespace IczpNet.Organization.PostRanks.Dtos
{
    public class PostRankDto : BaseDto
    {
        public virtual Guid PostTypeId { get; set; }
    }
}
