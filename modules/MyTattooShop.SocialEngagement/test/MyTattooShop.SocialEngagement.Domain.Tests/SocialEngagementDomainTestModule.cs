using Volo.Abp.Modularity;

namespace MyTattooShop.SocialEngagement;

[DependsOn(
    typeof(SocialEngagementDomainModule),
    typeof(SocialEngagementTestBaseModule)
)]
public class SocialEngagementDomainTestModule : AbpModule
{

}
