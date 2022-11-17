using IczpNet.AbpCommons.EntityFrameworkCore;
using IczpNet.Organization.EmployeePositions;
using IczpNet.Organization.PostGradePostLevels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using Volo.Abp;
using System.Reflection;
using System.Linq;
using Volo.Abp.Domain.Entities;
using IczpNet.Organization.DepartmentFunctionals;
using IczpNet.Organization.DepartmentPositions;
using IczpNet.Organization.PositionFunctionals;

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

        builder.Entity<DepartmentFunctional>(b =>
        {
            b.HasKey(x => new { x.DepartmentId, x.FunctionalId });
        });

        builder.Entity<DepartmentPosition>(b =>
        {
            b.HasKey(x => new { x.DepartmentId, x.PositionId });
        });

        builder.Entity<PositionFunctional>(b =>
        {
            b.HasKey(x => new { x.PositionId, x.FunctionalId });
        });
    }

    public static void ConfigEntityKeys(this ModelBuilder builder, Type moduleType, Func<Type, string> getTableName, string dbSchema)
    {
        //string entityNamespace = moduleType.Namespace;
        //foreach (Type t2 in from t in moduleType.Assembly.GetExportedTypes()
        //                    where t.Namespace!.StartsWith(entityNamespace) && !t.IsAbstract && t.GetInterfaces().Any((Type x) => typeof(IEntity).IsAssignableFrom(x))
        //                    select t)
        //{
        //    builder.Entity(t2, delegate (EntityTypeBuilder b)
        //    {
        //        TableAttribute customAttribute = t2.GetCustomAttribute<TableAttribute>();
        //        if (customAttribute != null)
        //        {
        //            b.ToTable(customAttribute.Name, customAttribute.Schema);
        //        }
        //        else
        //        {
        //            b.ToTable(getTableName(t2), dbSchema);
        //        }
        //        b.HasKey(x=> (t2.get))
        //    });
        //}
    }
}
