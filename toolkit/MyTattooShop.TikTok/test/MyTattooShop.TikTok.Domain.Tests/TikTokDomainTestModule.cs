using Volo.Abp.Modularity;

namespace MyTattooShop.TikTok;

[DependsOn(
    typeof(TikTokDomainModule),
    typeof(TikTokTestBaseModule)
)]
public class TikTokDomainTestModule : AbpModule
{

}
