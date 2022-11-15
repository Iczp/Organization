namespace IczpNet.Organization;

public static class OrganizationDbProperties
{
    public static string DbTablePrefix { get; set; } = "Organization";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Organization";
}
