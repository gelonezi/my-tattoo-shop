using MyTattooShop.TattooJourney.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTattooShop.TattooJourney;

public abstract class TattooJourneyController : AbpControllerBase
{
    protected TattooJourneyController()
    {
        LocalizationResource = typeof(TattooJourneyResource);
    }
}
