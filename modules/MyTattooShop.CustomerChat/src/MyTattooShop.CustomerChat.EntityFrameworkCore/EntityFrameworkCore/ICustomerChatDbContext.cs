using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.CustomerChat.EntityFrameworkCore;

[ConnectionStringName(CustomerChatDbProperties.ConnectionStringName)]
public interface ICustomerChatDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
