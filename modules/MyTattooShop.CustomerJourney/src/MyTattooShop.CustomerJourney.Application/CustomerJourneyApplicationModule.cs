using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Mapperly;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace MyTattooShop.CustomerJourney;

[DependsOn(
    typeof(CustomerJourneyDomainModule),
    typeof(CustomerJourneyApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpMapperlyModule)
    )]
public class CustomerJourneyApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMapperlyObjectMapper<CustomerJourneyApplicationModule>();
    }
}
