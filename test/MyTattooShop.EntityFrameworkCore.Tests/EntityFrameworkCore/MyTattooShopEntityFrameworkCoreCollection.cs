using Xunit;

namespace MyTattooShop.EntityFrameworkCore;

[CollectionDefinition(MyTattooShopTestConsts.CollectionDefinitionName)]
public class MyTattooShopEntityFrameworkCoreCollection : ICollectionFixture<MyTattooShopEntityFrameworkCoreFixture>
{

}
