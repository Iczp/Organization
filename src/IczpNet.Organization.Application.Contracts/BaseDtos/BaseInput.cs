using IczpNet.AbpCommons.DataFilters;
using System.ComponentModel;

namespace IczpNet.Organization.BaseDtos
{
    public class BaseInput : IName
    {
        [DefaultValue("")]
        public virtual string Name { get; set; }

        [DefaultValue("")]
        public virtual string Code { get; set; }

        [DefaultValue("")]
        public virtual string Description { get; set; }

        [DefaultValue(true)]
        public virtual bool IsActive { get; set; }
    }
}
