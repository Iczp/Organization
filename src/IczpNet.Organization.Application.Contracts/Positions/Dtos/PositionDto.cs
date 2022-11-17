﻿using IczpNet.Organization.Positions;
using System;
using Volo.Abp.Application.Dtos;

namespace IczpNet.Organization.Positions.Dtos
{
    /// <summary>
    /// PositionDto
    /// </summary>
    public class PositionDto : PositionInfo, IEntityDto<Guid>
    {

        /// <summary>
        /// 排序（越大越前面） DESC
        /// </summary>
        public virtual long Sorting { get; set; }
        /// <summary>
        /// 说明
        /// </summary>

        public virtual string Description { get; set; }
    }
}