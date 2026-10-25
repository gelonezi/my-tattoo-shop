using MyTattooShop.SocialEngagement.Localization;
using Volo.Abp.Application.Services;

namespace MyTattooShop.SocialEngagement;

public abstract class SocialEngagementAppService : ApplicationService
{
    protected SocialEngagementAppService()
    {
        LocalizationResource = typeof(SocialEngagementResource);
        ObjectMapperContext = typeof(SocialEngagementApplicationModule);
    }
}
