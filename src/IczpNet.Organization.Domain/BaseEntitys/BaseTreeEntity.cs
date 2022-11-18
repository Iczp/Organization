using IczpNet.AbpCommons.DataFilters;
using IczpNet.AbpCommons.Extensions;
using IczpNet.AbpCommons.PinYin;
using IczpNet.AbpTrees;
using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.BaseEntitys
{
    public abstract class BaseTreeEntity<T> : TreeEntity<T>, IMultiTenant, IHasPinyin, IName, ICode, IIsActive//, ISorting
        where T : ITreeEntity
    {
        public virtual Guid? TenantId { get; set; }

        public virtual bool IsActive { get; set; }

        [MaxLength(64)]
        public virtual string Code { get; set; }

        [MaxLength(300)]
        public virtual string Name_Py { get; protected set; }

        [MaxLength(300)]
        public virtual string Name_Pinyin { get; protected set; }

        public override void SetName(string name)
        {
            base.SetName(name);

            Name_Py = name.ConvertToPY().MaxLength(300);

            Name_Pinyin = name.ConvertToPinyin().MaxLength(300);
        }
    }
}
