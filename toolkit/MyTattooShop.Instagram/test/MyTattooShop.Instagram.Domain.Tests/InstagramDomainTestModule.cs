using Volo.Abp.Modularity;

namespace MyTattooShop.Instagram;

[DependsOn(
    typeof(InstagramDomainModule),
    typeof(InstagramTestBaseModule)
)]
public class InstagramDomainTestModule : AbpModule
{

}
