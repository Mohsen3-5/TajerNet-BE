using TajerNet.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace TajerNet.Permissions;

public class TajerNetPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TajerNetPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(TajerNetPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TajerNetResource>(name);
    }
}
