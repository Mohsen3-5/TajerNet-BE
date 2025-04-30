using TajerNet.Samples;
using Xunit;

namespace TajerNet.EntityFrameworkCore.Applications;

[Collection(TajerNetTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TajerNetEntityFrameworkCoreTestModule>
{

}
