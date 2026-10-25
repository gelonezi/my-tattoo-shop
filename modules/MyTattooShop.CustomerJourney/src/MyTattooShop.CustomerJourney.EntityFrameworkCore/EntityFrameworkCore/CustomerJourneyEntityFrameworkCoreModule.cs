using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyTattooShop.CustomerJourney.EntityFrameworkCore;

[DependsOn(
    typeof(CustomerJourneyDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class CustomerJourneyEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<CustomerJourneyDbContext>(options =>
        {
            options.AddDefaultRepositories<ICustomerJourneyDbContext>(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
