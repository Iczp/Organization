﻿using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.PostLevels.Dtos
{
    public class PostLevelDto :  IEntityDto<Guid>
    {
        public virtual string Name { get; set; }

        public virtual string Code { get; set; }

        public virtual bool IsStatic { get; set; }

        public virtual bool IsActive { get; set; }
        //[Range(0, 20)]
        public virtual long Value { get; set; }

        public Guid Id { get; set; }
    }
}