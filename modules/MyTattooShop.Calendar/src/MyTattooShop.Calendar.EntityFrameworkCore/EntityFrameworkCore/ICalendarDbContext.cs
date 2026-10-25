using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyTattooShop.Calendar.EntityFrameworkCore;

[ConnectionStringName(CalendarDbProperties.ConnectionStringName)]
public interface ICalendarDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
