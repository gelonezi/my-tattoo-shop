using Volo.Abp.Modularity;

namespace MyTattooShop.SocialEngagement;

[DependsOn(
    typeof(SocialEngagementApplicationModule),
    typeof(SocialEngagementDomainTestModule)
    )]
public class SocialEngagementApplicationTestModule : AbpModule
{

}
