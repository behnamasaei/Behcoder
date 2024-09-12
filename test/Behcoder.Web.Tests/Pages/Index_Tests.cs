using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Behcoder.Pages;

[Collection(BehcoderTestConsts.CollectionDefinitionName)]
public class Index_Tests : BehcoderWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
