namespace MyTattooShop.WhatsApp;

public static class WhatsAppDbProperties
{
    public static string DbTablePrefix { get; set; } = "WhatsApp";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "WhatsApp";
}
