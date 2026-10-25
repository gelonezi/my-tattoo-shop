namespace MyTattooShop.CustomerJourney;

public static class CustomerJourneyDbProperties
{
    public static string DbTablePrefix { get; set; } = "CustomerJourney";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "CustomerJourney";
}
