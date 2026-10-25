namespace MyTattooShop.TattooJourney;

public static class TattooJourneyDbProperties
{
    public static string DbTablePrefix { get; set; } = "TattooJourney";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "TattooJourney";
}
