using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MyTattooShop.TikTok;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(TikTokDomainSharedModule)
)]
public class TikTokDomainModule : AbpModule
{

}
