using Volo.Abp.Modularity;

namespace MyTattooShop.WhatsApp;

[DependsOn(
    typeof(WhatsAppApplicationModule),
    typeof(WhatsAppDomainTestModule)
    )]
public class WhatsAppApplicationTestModule : AbpModule
{

}
