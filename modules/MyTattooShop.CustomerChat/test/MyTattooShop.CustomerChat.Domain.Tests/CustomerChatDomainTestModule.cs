using Volo.Abp.Modularity;

namespace MyTattooShop.CustomerChat;

[DependsOn(
    typeof(CustomerChatDomainModule),
    typeof(CustomerChatTestBaseModule)
)]
public class CustomerChatDomainTestModule : AbpModule
{

}
