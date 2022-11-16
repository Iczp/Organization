﻿using IczpNet.AbpCommons.EntityFrameworkCore;
using IczpNet.Organization.EmployeePositions;
using IczpNet.Organization.PostGradePostLevels;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace IczpNet.Organization.EntityFrameworkCore;

public static class OrganizationDbContextModelCreatingExtensions
{
    public static void ConfigureOrganization(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(OrganizationDbProperties.DbTablePrefix + "Questions", OrganizationDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.ConfigEntitys<OrganizationDomainModule>(OrganizationDbProperties.DbTablePrefix, OrganizationDbProperties.DbSchema);

        builder.Entity<EmployeePosition>(b =>
        {
            b.HasKey(x => new { x.EmployeeId, x.PositionId });
        });

        builder.Entity<PostGradePostLevel>(b =>
        {
            b.HasKey(x => new { x.PostGradeId, x.PostLevelId });
        });
    }
}
