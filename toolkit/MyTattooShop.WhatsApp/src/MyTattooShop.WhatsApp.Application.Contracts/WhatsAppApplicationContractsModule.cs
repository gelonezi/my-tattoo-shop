using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace MyTattooShop.WhatsApp;

[DependsOn(
    typeof(WhatsAppDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class WhatsAppApplicationContractsModule : AbpModule
{

}
