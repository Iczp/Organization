﻿using IczpNet.Organization.Bases;
using IczpNet.Organization.Grades;
using IczpNet.Organization.PostTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IczpNet.Organization.PostRanks
{
    public class PostRank : BaseEntity
    {

        public virtual Guid PostTypeId { get; set; }

        [ForeignKey(nameof(PostTypeId))]
        public virtual PostType PostType { get; set; }

        //public virtual IEnumerable<Level> LevelList { get; set; }

    }
}
