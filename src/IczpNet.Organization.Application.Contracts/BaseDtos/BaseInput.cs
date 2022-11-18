using IczpNet.AbpCommons.DataFilters;

namespace IczpNet.Organization.BaseDtos
{
    public class BaseInput : IName
    {
        public virtual string Name { get; set; }
        public virtual string Code { get; set; }
        public virtual string Description { get; set; }
        public virtual bool IsActive { get; set; }
    }
}
