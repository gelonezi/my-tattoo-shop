using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace MyTattooShop.SocialEngagement;

[DependsOn(
    typeof(SocialEngagementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class SocialEngagementApplicationContractsModule : AbpModule
{

}
