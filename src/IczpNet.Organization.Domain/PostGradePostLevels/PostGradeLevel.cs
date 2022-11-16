﻿using IczpNet.Organization.PostGrades;
using IczpNet.Organization.PostLevels;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace IczpNet.Organization.PostGradePostLevels
{
    public class PostGradePostLevel : FullAuditedAggregateRoot
    {
        public virtual Guid PostLevelId { get; set; }

        public virtual Guid PostGradeId { get; set; }

        [ForeignKey(nameof(PostLevelId))]
        public virtual PostLevel PostLevel { get; set; }

        [ForeignKey(nameof(PostGradeId))]
        public virtual PostGrade PostGrade { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { PostLevelId, PostGradeId };
        }

        protected PostGradePostLevel() { }

        public PostGradePostLevel(PostGrade postGrade, PostLevel postLevel)
        {
            PostGrade = postGrade;
            PostLevel = postLevel;
        }
    }
}
