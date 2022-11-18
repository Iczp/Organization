using IczpNet.AbpCommons.DataFilters;
using IczpNet.AbpTrees.Dtos;
using System.ComponentModel;

namespace IczpNet.Organization.BaseDtos
{
    public class BaseTreeGetListInput : TreeGetListInput, IKeyword, ITreeGetListInput
    {
        [DefaultValue(null)]
        public virtual bool? IsStatic { get; set; }

        [DefaultValue(null)]
        public virtual bool? IsActive { get; set; }
    }
}
