using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.Instagram;

[DependsOn(
    typeof(InstagramApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class InstagramHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(InstagramApplicationContractsModule).Assembly,
            InstagramRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<InstagramHttpApiClientModule>();
        });

    }
}
