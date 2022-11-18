using IczpNet.AbpTrees.Dtos;
using System;

namespace IczpNet.Organization.BaseDtos
{
    public class BaseTreeInputDto: ITreeInput
    {
        public virtual Guid? ParentId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Code { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual double Sorting { get; set; }
    }
}
