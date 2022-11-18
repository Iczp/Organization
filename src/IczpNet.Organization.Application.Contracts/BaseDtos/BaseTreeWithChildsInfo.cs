using IczpNet.AbpTrees;

namespace IczpNet.Organization.BaseDtos
{
    public class BaseTreeWithChildsDto<T>: TreeWithChildsInfo<T>
    {
        public virtual string Code { get; set; }

        public virtual bool IsStatic { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual double Sorting { get; set; }

        public virtual int ChildsCount { get; set; }
    }
}
