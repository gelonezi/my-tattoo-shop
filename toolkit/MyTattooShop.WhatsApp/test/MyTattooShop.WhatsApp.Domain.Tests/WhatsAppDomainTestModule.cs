using Volo.Abp.Modularity;

namespace MyTattooShop.WhatsApp;

[DependsOn(
    typeof(WhatsAppDomainModule),
    typeof(WhatsAppTestBaseModule)
)]
public class WhatsAppDomainTestModule : AbpModule
{

}
