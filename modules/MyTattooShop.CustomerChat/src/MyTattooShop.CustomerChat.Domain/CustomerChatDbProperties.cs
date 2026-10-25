namespace MyTattooShop.CustomerChat;

public static class CustomerChatDbProperties
{
    public static string DbTablePrefix { get; set; } = "CustomerChat";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "CustomerChat";
}
