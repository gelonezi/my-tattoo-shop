using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyTattooShop.Instagram.EntityFrameworkCore;

[DependsOn(
    typeof(InstagramDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class InstagramEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<InstagramDbContext>(options =>
        {
            options.AddDefaultRepositories<IInstagramDbContext>(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
