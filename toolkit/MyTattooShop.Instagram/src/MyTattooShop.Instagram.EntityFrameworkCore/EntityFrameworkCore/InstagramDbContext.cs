using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.Instagram.EntityFrameworkCore;

[ConnectionStringName(InstagramDbProperties.ConnectionStringName)]
public class InstagramDbContext : AbpDbContext<InstagramDbContext>, IInstagramDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public InstagramDbContext(DbContextOptions<InstagramDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureInstagram();
    }
}
