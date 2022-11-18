using IczpNet.AbpTrees;

namespace IczpNet.Organization.BaseInfos
{
    public class BaseTreeInfo : TreeInfo
    {
        public virtual string Code { get; set; }

        public virtual double Sorting { get; set; }

        public virtual bool IsStatic { get; set; }

        public virtual bool IsActive { get; set; }
    }
}
