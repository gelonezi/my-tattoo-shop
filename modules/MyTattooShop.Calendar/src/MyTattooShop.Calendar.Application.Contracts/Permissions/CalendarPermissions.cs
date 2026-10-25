using Volo.Abp.Reflection;

namespace MyTattooShop.Calendar.Permissions;

public class CalendarPermissions
{
    public const string GroupName = "Calendar";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CalendarPermissions));
    }
}
