using MyTattooShop.CustomerJourney.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTattooShop.CustomerJourney;

public abstract class CustomerJourneyController : AbpControllerBase
{
    protected CustomerJourneyController()
    {
        LocalizationResource = typeof(CustomerJourneyResource);
    }
}
