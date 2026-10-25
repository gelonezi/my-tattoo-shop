using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MyTattooShop.CustomerJourney;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(CustomerJourneyDomainSharedModule)
)]
public class CustomerJourneyDomainModule : AbpModule
{

}
