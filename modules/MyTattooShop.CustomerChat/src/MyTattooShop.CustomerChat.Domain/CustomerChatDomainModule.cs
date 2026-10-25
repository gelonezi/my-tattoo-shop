using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MyTattooShop.CustomerChat;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(CustomerChatDomainSharedModule)
)]
public class CustomerChatDomainModule : AbpModule
{

}
