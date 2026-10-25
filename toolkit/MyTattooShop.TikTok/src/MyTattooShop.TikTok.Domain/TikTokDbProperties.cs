namespace MyTattooShop.TikTok;

public static class TikTokDbProperties
{
    public static string DbTablePrefix { get; set; } = "TikTok";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "TikTok";
}
