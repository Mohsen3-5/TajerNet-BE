using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace TajerNet.Pages;

[Collection(TajerNetTestConsts.CollectionDefinitionName)]
public class Index_Tests : TajerNetWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
