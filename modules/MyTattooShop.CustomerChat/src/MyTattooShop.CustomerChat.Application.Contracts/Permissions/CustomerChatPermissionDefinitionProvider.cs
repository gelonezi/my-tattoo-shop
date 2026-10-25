using MyTattooShop.CustomerChat.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyTattooShop.CustomerChat.Permissions;

public class CustomerChatPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CustomerChatPermissions.GroupName, L("Permission:CustomerChat"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CustomerChatResource>(name);
    }
}
