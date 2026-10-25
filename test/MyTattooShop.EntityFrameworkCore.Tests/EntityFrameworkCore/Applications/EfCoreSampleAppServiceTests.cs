using MyTattooShop.Samples;
using Xunit;

namespace MyTattooShop.EntityFrameworkCore.Applications;

[Collection(MyTattooShopTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MyTattooShopEntityFrameworkCoreTestModule>
{

}
