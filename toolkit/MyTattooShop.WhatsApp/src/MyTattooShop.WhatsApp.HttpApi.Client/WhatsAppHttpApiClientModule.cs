using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.WhatsApp;

[DependsOn(
    typeof(WhatsAppApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class WhatsAppHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(WhatsAppApplicationContractsModule).Assembly,
            WhatsAppRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<WhatsAppHttpApiClientModule>();
        });

    }
}
