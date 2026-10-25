using Volo.Abp.Modularity;

namespace MyTattooShop.TikTok;

[DependsOn(
    typeof(TikTokApplicationModule),
    typeof(TikTokDomainTestModule)
    )]
public class TikTokApplicationTestModule : AbpModule
{

}
