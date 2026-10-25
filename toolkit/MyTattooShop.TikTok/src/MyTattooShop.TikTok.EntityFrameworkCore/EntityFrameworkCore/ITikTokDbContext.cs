using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.TikTok.EntityFrameworkCore;

[ConnectionStringName(TikTokDbProperties.ConnectionStringName)]
public interface ITikTokDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
