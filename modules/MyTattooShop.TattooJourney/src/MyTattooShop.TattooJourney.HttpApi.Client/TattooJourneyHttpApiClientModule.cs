using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.TattooJourney;

[DependsOn(
    typeof(TattooJourneyApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class TattooJourneyHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(TattooJourneyApplicationContractsModule).Assembly,
            TattooJourneyRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<TattooJourneyHttpApiClientModule>();
        });

    }
}
