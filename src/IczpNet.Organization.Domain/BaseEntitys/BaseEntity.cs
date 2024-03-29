﻿using IczpNet.AbpCommons;
using IczpNet.AbpCommons.DataFilters;
using IczpNet.AbpCommons.Extensions;
using IczpNet.AbpCommons.PinYin;
using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace IczpNet.Organization.BaseEntitys
{
    public abstract class BaseEntity : FullAuditedAggregateRoot, IMultiTenant, ISorting
    {
        public virtual Guid? TenantId { get; set; }

        public virtual double Sorting { get; set; }
    }
    public abstract class BaseEntity<TKey> : FullAuditedAggregateRoot<TKey>, IMultiTenant, IName, ICode, ISorting, IIsActive, IHasPinyin, IIsStatic
    {
        public virtual Guid? TenantId { get; set; }

        [MaxLength(64)]
        [Required(ErrorMessage = "名称不能为Null")]
        public virtual string Name { get; protected set; }

        [MaxLength(300)]
        public virtual string Name_Py { get; protected set; }

        [MaxLength(300)]
        public virtual string Name_Pinyin { get; protected set; }

        [MaxLength(64)]
        public virtual string Code { get; set; }

        [MaxLength(500)]
        public virtual string Description { get; set; }

        public virtual double Sorting { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual bool IsStatic { get; protected set; }

        public virtual void SetName(string name)
        {
            Assert.NotNull(name, "名称不能为Null");

            Name = name;

            Name_Py = name.ConvertToPY().MaxLength(300);

            Name_Pinyin = name.ConvertToPinyin().MaxLength(300);
        }

        public virtual void SetIsActive(bool isActive) 
        {
            IsActive = isActive;
        }

        public virtual void SetIsStatic(bool isStatic)
        {
            IsStatic = isStatic;
        }
    }
}
