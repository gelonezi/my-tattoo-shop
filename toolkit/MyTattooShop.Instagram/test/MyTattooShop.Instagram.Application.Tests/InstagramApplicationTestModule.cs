using Volo.Abp.Modularity;

namespace MyTattooShop.Instagram;

[DependsOn(
    typeof(InstagramApplicationModule),
    typeof(InstagramDomainTestModule)
    )]
public class InstagramApplicationTestModule : AbpModule
{

}
