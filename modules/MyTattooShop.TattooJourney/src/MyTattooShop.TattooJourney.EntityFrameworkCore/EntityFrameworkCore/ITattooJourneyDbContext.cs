using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.TattooJourney.EntityFrameworkCore;

[ConnectionStringName(TattooJourneyDbProperties.ConnectionStringName)]
public interface ITattooJourneyDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
