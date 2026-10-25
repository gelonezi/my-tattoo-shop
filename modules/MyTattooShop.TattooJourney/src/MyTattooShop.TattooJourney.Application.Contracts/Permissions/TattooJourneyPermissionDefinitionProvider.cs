using MyTattooShop.TattooJourney.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyTattooShop.TattooJourney.Permissions;

public class TattooJourneyPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TattooJourneyPermissions.GroupName, L("Permission:TattooJourney"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TattooJourneyResource>(name);
    }
}
