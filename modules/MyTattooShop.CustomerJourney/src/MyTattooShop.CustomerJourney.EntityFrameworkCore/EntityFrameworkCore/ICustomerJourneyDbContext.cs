using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.CustomerJourney.EntityFrameworkCore;

[ConnectionStringName(CustomerJourneyDbProperties.ConnectionStringName)]
public interface ICustomerJourneyDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
