using IczpNet.AbpTrees;
using System;

namespace IczpNet.Organization.BaseDtos
{
    public class BaseTreeWithParentDto<T> : TreeWithParentInfo<T, Guid>
    {
        public virtual string Code { get; set; }

        public virtual bool IsStatic { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual double Sorting { get; set; }
    }
}
