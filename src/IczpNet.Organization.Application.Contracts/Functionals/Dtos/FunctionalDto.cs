using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.Functionals.Dtos
{
    public class FunctionalDto : FunctionalInfo, IEntityDto<Guid>
    {

        /// <summary>
        /// 排序（越大越前面） DESC
        /// </summary>
        public virtual long Sorting { get; set; }
        /// <summary>
        /// 说明
        /// </summary>

        public virtual string Description { get; set; }
    }
}
