using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace MyTattooShop.TattooJourney.Samples;

[Area(TattooJourneyRemoteServiceConsts.ModuleName)]
[RemoteService(Name = TattooJourneyRemoteServiceConsts.RemoteServiceName)]
[Route("api/tattoo-journey/example")]
public class ExampleController : TattooJourneyController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public ExampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}
