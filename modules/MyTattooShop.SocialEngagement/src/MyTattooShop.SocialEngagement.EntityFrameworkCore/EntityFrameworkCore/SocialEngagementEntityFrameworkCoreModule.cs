using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyTattooShop.SocialEngagement.EntityFrameworkCore;

[DependsOn(
    typeof(SocialEngagementDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class SocialEngagementEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<SocialEngagementDbContext>(options =>
        {
            options.AddDefaultRepositories<ISocialEngagementDbContext>(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
