using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.TikTok.EntityFrameworkCore;

[ConnectionStringName(TikTokDbProperties.ConnectionStringName)]
public class TikTokDbContext : AbpDbContext<TikTokDbContext>, ITikTokDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public TikTokDbContext(DbContextOptions<TikTokDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureTikTok();
    }
}
