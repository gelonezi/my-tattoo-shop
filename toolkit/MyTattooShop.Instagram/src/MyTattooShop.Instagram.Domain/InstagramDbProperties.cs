namespace MyTattooShop.Instagram;

public static class InstagramDbProperties
{
    public static string DbTablePrefix { get; set; } = "Instagram";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Instagram";
}
