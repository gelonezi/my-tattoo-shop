using MyTattooShop.SocialEngagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyTattooShop.SocialEngagement.Permissions;

public class SocialEngagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SocialEngagementPermissions.GroupName, L("Permission:SocialEngagement"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SocialEngagementResource>(name);
    }
}
