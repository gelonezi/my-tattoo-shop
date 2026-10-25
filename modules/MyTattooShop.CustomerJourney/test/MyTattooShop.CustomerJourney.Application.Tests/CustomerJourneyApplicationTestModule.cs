using Volo.Abp.Modularity;

namespace MyTattooShop.CustomerJourney;

[DependsOn(
    typeof(CustomerJourneyApplicationModule),
    typeof(CustomerJourneyDomainTestModule)
    )]
public class CustomerJourneyApplicationTestModule : AbpModule
{

}
