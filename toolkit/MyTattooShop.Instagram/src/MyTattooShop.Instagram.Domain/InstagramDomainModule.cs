using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MyTattooShop.Instagram;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(InstagramDomainSharedModule)
)]
public class InstagramDomainModule : AbpModule
{

}
