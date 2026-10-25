using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace MyTattooShop.SocialEngagement;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class SocialEngagementInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<SocialEngagementInstallerModule>();
        });
    }
}
