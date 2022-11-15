using Volo.Abp.Reflection;

namespace IczpNet.Organization.Permissions;

public class OrganizationPermissions
{
    public const string GroupName = "Organization";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(OrganizationPermissions));
    }
}
