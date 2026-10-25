using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.SocialEngagement.EntityFrameworkCore;

[ConnectionStringName(SocialEngagementDbProperties.ConnectionStringName)]
public interface ISocialEngagementDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
