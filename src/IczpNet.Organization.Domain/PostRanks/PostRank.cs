﻿using IczpNet.Organization.Bases;
using IczpNet.Organization.PostGrades;
using IczpNet.Organization.PostTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IczpNet.Organization.PostRanks
{
    public class PostRank : BaseEntity<Guid>
    {
        public virtual bool IsStatic { get; set; }
        public virtual Guid PostTypeId { get; set; }

        [ForeignKey(nameof(PostTypeId))]
        public virtual PostType PostType { get; set; }

        public virtual IEnumerable<PostGrade> PostGradeList { get; set; }

    }
}
