using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.TikTok;

[DependsOn(
    typeof(TikTokApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class TikTokHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(TikTokApplicationContractsModule).Assembly,
            TikTokRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<TikTokHttpApiClientModule>();
        });

    }
}
