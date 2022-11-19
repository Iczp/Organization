using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.Functionals.Dtos
{
    public class FunctionalDto : FunctionalInfo, IEntityDto<Guid>
    {

        public virtual string Description { get; set; }
    }
}
