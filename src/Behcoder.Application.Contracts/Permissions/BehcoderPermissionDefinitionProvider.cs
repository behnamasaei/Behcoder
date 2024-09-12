using Behcoder.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Behcoder.Permissions;

public class BehcoderPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BehcoderPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(BehcoderPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BehcoderResource>(name);
    }
}
