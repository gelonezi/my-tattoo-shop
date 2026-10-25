using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace MyTattooShop.TikTok;

[DependsOn(
    typeof(TikTokDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class TikTokApplicationContractsModule : AbpModule
{

}
