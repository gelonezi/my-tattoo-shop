using MyTattooShop.Calendar.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyTattooShop.Calendar.Permissions;

public class CalendarPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CalendarPermissions.GroupName, L("Permission:Calendar"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CalendarResource>(name);
    }
}
