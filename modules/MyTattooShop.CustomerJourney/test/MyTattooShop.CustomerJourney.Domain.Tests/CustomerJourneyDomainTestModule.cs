using Volo.Abp.Modularity;

namespace MyTattooShop.CustomerJourney;

[DependsOn(
    typeof(CustomerJourneyDomainModule),
    typeof(CustomerJourneyTestBaseModule)
)]
public class CustomerJourneyDomainTestModule : AbpModule
{

}
