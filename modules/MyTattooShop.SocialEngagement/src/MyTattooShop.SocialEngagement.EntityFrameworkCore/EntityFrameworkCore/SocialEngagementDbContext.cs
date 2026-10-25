using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.SocialEngagement.EntityFrameworkCore;

[ConnectionStringName(SocialEngagementDbProperties.ConnectionStringName)]
public class SocialEngagementDbContext : AbpDbContext<SocialEngagementDbContext>, ISocialEngagementDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public SocialEngagementDbContext(DbContextOptions<SocialEngagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureSocialEngagement();
    }
}
