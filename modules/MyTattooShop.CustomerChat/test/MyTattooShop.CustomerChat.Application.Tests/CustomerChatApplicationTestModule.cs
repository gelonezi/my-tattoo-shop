using Volo.Abp.Modularity;

namespace MyTattooShop.CustomerChat;

[DependsOn(
    typeof(CustomerChatApplicationModule),
    typeof(CustomerChatDomainTestModule)
    )]
public class CustomerChatApplicationTestModule : AbpModule
{

}
