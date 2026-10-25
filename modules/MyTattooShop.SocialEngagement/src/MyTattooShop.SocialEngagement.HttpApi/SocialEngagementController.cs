using MyTattooShop.SocialEngagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTattooShop.SocialEngagement;

public abstract class SocialEngagementController : AbpControllerBase
{
    protected SocialEngagementController()
    {
        LocalizationResource = typeof(SocialEngagementResource);
    }
}
