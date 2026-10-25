using MyTattooShop.Samples;
using Xunit;

namespace MyTattooShop.EntityFrameworkCore.Domains;

[Collection(MyTattooShopTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MyTattooShopEntityFrameworkCoreTestModule>
{

}
