using IczpNet.AbpCommons.DataFilters;
using IczpNet.AbpTrees;
using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.BaseDtos
{
    public class BaseTreeGetListInput : PagedAndSortedResultRequestDto, IKeyword, ITreeGetListInput
    {
        [DefaultValue(false)]
        public virtual bool IsEnabledParentId { get; set; }

        [DefaultValue(null)]
        public virtual int? Depth { get; set; }

        [DefaultValue(null)]
        public virtual Guid? ParentId { get; set; }

        [DefaultValue(null)]
        public virtual bool? IsStatic { get; set; }

        [DefaultValue(null)]
        public virtual bool? IsActive { get; set; }

        /// <summary>
        /// 关键字(支持拼音)
        /// </summary>
        [DefaultValue(null)]
        public virtual string Keyword { get; set; }
    }
}
