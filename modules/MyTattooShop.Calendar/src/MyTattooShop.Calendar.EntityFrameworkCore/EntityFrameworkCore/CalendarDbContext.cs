using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.Calendar.EntityFrameworkCore;

[ConnectionStringName(CalendarDbProperties.ConnectionStringName)]
public class CalendarDbContext : AbpDbContext<CalendarDbContext>, ICalendarDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public CalendarDbContext(DbContextOptions<CalendarDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureCalendar();
    }
}
