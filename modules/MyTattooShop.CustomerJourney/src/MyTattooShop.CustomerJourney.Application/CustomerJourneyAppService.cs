using MyTattooShop.CustomerJourney.Localization;
using Volo.Abp.Application.Services;

namespace MyTattooShop.CustomerJourney;

public abstract class CustomerJourneyAppService : ApplicationService
{
    protected CustomerJourneyAppService()
    {
        LocalizationResource = typeof(CustomerJourneyResource);
        ObjectMapperContext = typeof(CustomerJourneyApplicationModule);
    }
}
