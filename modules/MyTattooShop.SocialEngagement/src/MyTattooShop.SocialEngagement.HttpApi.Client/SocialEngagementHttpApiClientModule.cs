using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.SocialEngagement;

[DependsOn(
    typeof(SocialEngagementApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class SocialEngagementHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(SocialEngagementApplicationContractsModule).Assembly,
            SocialEngagementRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SocialEngagementHttpApiClientModule>();
        });

    }
}
