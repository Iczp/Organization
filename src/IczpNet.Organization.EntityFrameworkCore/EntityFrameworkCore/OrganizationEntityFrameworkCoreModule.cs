using IczpNet.AbpCommons.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace IczpNet.Organization.EntityFrameworkCore;

[DependsOn(
    typeof(OrganizationDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
[DependsOn(typeof(AbpCommonsEntityFrameworkCoreModule))]
public class OrganizationEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<OrganizationDbContext>(options =>
        {
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
            /* The main point to change your DBMS.
             * See also IMMigrationsDbContextFactory for EF Core tooling. */
            //options.UseSqlServer();
            options.PreConfigure<OrganizationDbContext>(opts =>
            {
                // 1.安装 Microsoft.EntityFrameworkCore.Proxies 包到你的项目(通常是 EF Core 集成项目)
                // 2.为你的 DbContext 配置 UseLazyLoadingProxies(在 EF Core 项目的模块的 ConfigureServices 方法中). 
                // 3.https://docs.abp.io/zh-Hans/abp/latest/Entity-Framework-Core
                // 启用延时加载
                object value = opts.DbContextOptions.UseLazyLoadingProxies();
            });
        });
    }
}
