using Kvk.Api.Client.Exceptions;
using Kvk.Api.Client.V1.Vestigingsprofielen;

namespace Kvk.Api.IntegrationTests.V1.Vestigingsprofielen;

public class KvkApiV1ClientTests : BaseTests
{
    [Fact]
    public async Task GetVestigingsprofielenAsync_SearchVestigingsnummer_ReturnsSuccess()
    {
        var request = new VestigingsprofielenRequest()
        {
            Vestigingsnummer = "990000768218",
        };

        var response = await _kvkApiV1Client.GetVestigingsprofielenAsync(request);

        Assert.NotNull(response);
        Assert.Equal("990000768218", response.Vestigingsnummer);
    }
}