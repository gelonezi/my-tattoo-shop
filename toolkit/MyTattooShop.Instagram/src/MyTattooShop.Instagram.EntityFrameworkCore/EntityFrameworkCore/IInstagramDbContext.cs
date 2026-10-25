using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.Instagram.EntityFrameworkCore;

[ConnectionStringName(InstagramDbProperties.ConnectionStringName)]
public interface IInstagramDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
