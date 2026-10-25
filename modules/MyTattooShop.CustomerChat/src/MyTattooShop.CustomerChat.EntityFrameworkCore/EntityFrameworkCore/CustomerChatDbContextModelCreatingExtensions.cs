using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace MyTattooShop.CustomerChat.EntityFrameworkCore;

public static class CustomerChatDbContextModelCreatingExtensions
{
    public static void ConfigureCustomerChat(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(CustomerChatDbProperties.DbTablePrefix + "Questions", CustomerChatDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
    }
}
