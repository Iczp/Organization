using Volo.Abp;
using Volo.Abp.MongoDB;

namespace IczpNet.Organization.MongoDB;

public static class OrganizationMongoDbContextExtensions
{
    public static void ConfigureOrganization(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
