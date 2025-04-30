using Xunit;

namespace TajerNet.EntityFrameworkCore;

[CollectionDefinition(TajerNetTestConsts.CollectionDefinitionName)]
public class TajerNetEntityFrameworkCoreCollection : ICollectionFixture<TajerNetEntityFrameworkCoreFixture>
{

}
