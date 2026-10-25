using MyTattooShop.Instagram.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyTattooShop.Instagram.Permissions;

public class InstagramPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(InstagramPermissions.GroupName, L("Permission:Instagram"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<InstagramResource>(name);
    }
}
