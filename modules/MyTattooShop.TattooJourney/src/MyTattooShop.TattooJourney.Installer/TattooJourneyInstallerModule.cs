using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.TattooJourney;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class TattooJourneyInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<TattooJourneyInstallerModule>();
        });
    }
}
