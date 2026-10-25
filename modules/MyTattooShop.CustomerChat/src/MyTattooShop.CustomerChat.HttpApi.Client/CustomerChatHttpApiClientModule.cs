using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.CustomerChat;

[DependsOn(
    typeof(CustomerChatApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class CustomerChatHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(CustomerChatApplicationContractsModule).Assembly,
            CustomerChatRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CustomerChatHttpApiClientModule>();
        });

    }
}
