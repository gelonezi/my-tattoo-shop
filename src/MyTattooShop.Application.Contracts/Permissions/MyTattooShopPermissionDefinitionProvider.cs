using MyTattooShop.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace MyTattooShop.Permissions;

public class MyTattooShopPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MyTattooShopPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(MyTattooShopPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MyTattooShopResource>(name);
    }
}
