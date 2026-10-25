using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MyTattooShop.SocialEngagement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(SocialEngagementDomainSharedModule)
)]
public class SocialEngagementDomainModule : AbpModule
{

}
