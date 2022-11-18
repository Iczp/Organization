using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.PostTypes.Dtos
{
    public class PostTypeDto :  IEntityDto<Guid>
    {
        public virtual string Name { get; set; }

        public virtual string Code { get; set; }

        public virtual bool IsStatic { get; set; }

        public virtual bool IsActive { get; set; }

        public Guid Id { get; set; }
    }
}
