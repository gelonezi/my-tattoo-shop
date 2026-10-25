using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyTattooShop.TikTok.EntityFrameworkCore;

[DependsOn(
    typeof(TikTokDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class TikTokEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<TikTokDbContext>(options =>
        {
            options.AddDefaultRepositories<ITikTokDbContext>(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
