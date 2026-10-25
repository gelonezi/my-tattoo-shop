using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.WhatsApp.EntityFrameworkCore;

[ConnectionStringName(WhatsAppDbProperties.ConnectionStringName)]
public interface IWhatsAppDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
