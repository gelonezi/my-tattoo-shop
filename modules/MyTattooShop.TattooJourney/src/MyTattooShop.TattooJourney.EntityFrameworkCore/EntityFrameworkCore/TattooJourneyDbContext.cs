using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.TattooJourney.EntityFrameworkCore;

[ConnectionStringName(TattooJourneyDbProperties.ConnectionStringName)]
public class TattooJourneyDbContext : AbpDbContext<TattooJourneyDbContext>, ITattooJourneyDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public TattooJourneyDbContext(DbContextOptions<TattooJourneyDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureTattooJourney();
    }
}
