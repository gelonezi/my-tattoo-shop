using MyTattooShop.CustomerJourney.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyTattooShop.CustomerJourney.Permissions;

public class CustomerJourneyPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CustomerJourneyPermissions.GroupName, L("Permission:CustomerJourney"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CustomerJourneyResource>(name);
    }
}
