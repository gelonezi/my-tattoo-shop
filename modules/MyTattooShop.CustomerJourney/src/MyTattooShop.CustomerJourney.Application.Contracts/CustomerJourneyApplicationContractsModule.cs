using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace MyTattooShop.CustomerJourney;

[DependsOn(
    typeof(CustomerJourneyDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class CustomerJourneyApplicationContractsModule : AbpModule
{

}
