using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MyTattooShop.TattooJourney;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(TattooJourneyDomainSharedModule)
)]
public class TattooJourneyDomainModule : AbpModule
{

}
