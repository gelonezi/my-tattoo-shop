using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace MyTattooShop.TattooJourney;

[DependsOn(
    typeof(TattooJourneyDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class TattooJourneyApplicationContractsModule : AbpModule
{

}
