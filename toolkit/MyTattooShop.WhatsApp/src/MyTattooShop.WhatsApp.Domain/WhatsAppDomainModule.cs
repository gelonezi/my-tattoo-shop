using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MyTattooShop.WhatsApp;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(WhatsAppDomainSharedModule)
)]
public class WhatsAppDomainModule : AbpModule
{

}
