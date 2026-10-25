using MyTattooShop.WhatsApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyTattooShop.WhatsApp.Permissions;

public class WhatsAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(WhatsAppPermissions.GroupName, L("Permission:WhatsApp"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WhatsAppResource>(name);
    }
}
