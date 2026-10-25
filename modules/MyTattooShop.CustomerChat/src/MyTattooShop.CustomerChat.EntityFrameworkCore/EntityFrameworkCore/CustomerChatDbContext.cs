using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.CustomerChat.EntityFrameworkCore;

[ConnectionStringName(CustomerChatDbProperties.ConnectionStringName)]
public class CustomerChatDbContext : AbpDbContext<CustomerChatDbContext>, ICustomerChatDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public CustomerChatDbContext(DbContextOptions<CustomerChatDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureCustomerChat();
    }
}
