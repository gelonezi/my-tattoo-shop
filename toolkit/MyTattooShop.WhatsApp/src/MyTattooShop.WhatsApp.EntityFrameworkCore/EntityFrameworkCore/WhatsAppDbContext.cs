using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.WhatsApp.EntityFrameworkCore;

[ConnectionStringName(WhatsAppDbProperties.ConnectionStringName)]
public class WhatsAppDbContext : AbpDbContext<WhatsAppDbContext>, IWhatsAppDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public WhatsAppDbContext(DbContextOptions<WhatsAppDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureWhatsApp();
    }
}
