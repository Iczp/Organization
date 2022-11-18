using IczpNet.AbpTrees;

namespace IczpNet.Organization.Functionals
{
    public class FunctionalInfo : TreeInfo
    {
        public virtual string Code { get; set; }

        public virtual bool IsStatic { get; set; }

        public virtual bool IsActive { get; set; }
    }
}
