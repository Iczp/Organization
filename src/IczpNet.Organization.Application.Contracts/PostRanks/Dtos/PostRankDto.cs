using IczpNet.Organization.BaseDtos;
using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.PostRanks.Dtos
{
    public class PostRankDto : BaseDto
    {
        public virtual Guid PostTypeId { get; set; }
    }
}
