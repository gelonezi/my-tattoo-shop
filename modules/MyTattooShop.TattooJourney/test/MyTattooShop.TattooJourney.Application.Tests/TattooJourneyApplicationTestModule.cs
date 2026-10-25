using Volo.Abp.Modularity;

namespace MyTattooShop.TattooJourney;

[DependsOn(
    typeof(TattooJourneyApplicationModule),
    typeof(TattooJourneyDomainTestModule)
    )]
public class TattooJourneyApplicationTestModule : AbpModule
{

}
