using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.TikTok;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class TikTokInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<TikTokInstallerModule>();
        });
    }
}
