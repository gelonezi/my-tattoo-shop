using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyTattooShop.TattooJourney.EntityFrameworkCore;

[DependsOn(
    typeof(TattooJourneyDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class TattooJourneyEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<TattooJourneyDbContext>(options =>
        {
            options.AddDefaultRepositories<ITattooJourneyDbContext>(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
