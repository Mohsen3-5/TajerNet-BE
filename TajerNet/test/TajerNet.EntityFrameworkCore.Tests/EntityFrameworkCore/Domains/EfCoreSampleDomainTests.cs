using TajerNet.Samples;
using Xunit;

namespace TajerNet.EntityFrameworkCore.Domains;

[Collection(TajerNetTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TajerNetEntityFrameworkCoreTestModule>
{

}
