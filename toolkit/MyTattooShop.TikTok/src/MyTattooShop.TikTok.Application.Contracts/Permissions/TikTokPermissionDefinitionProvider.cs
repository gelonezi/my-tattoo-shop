using MyTattooShop.TikTok.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyTattooShop.TikTok.Permissions;

public class TikTokPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TikTokPermissions.GroupName, L("Permission:TikTok"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TikTokResource>(name);
    }
}
