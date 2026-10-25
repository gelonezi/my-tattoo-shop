using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyTattooShop.Calendar.EntityFrameworkCore;

[DependsOn(
    typeof(CalendarDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class CalendarEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<CalendarDbContext>(options =>
        {
            options.AddDefaultRepositories<ICalendarDbContext>(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
