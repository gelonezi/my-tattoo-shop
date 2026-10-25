using Volo.Abp.Reflection;

namespace MyTattooShop.SocialEngagement.Permissions;

public class SocialEngagementPermissions
{
    public const string GroupName = "SocialEngagement";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(SocialEngagementPermissions));
    }
}
