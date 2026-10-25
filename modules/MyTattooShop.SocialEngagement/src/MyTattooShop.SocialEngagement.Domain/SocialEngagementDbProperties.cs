namespace MyTattooShop.SocialEngagement;

public static class SocialEngagementDbProperties
{
    public static string DbTablePrefix { get; set; } = "SocialEngagement";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "SocialEngagement";
}
