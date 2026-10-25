using Volo.Abp.Modularity;

namespace MyTattooShop.TattooJourney;

[DependsOn(
    typeof(TattooJourneyDomainModule),
    typeof(TattooJourneyTestBaseModule)
)]
public class TattooJourneyDomainTestModule : AbpModule
{

}
