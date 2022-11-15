using IczpNet.Organization.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace IczpNet.Organization.Permissions;

public class OrganizationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OrganizationPermissions.GroupName, L("Permission:Organization"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OrganizationResource>(name);
    }
}
