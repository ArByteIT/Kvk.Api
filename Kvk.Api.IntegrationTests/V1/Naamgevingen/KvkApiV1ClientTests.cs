using Kvk.Api.Client.V1.Naamgevingen;

namespace Kvk.Api.IntegrationTests.V1.Naamgevingen;

public class KvkApiV1ClientTests : BaseTests
{
    [Fact]
    public async Task GetNaamgevingenAsync_SearchVestigingsnummer_ReturnsSuccess()
    {
        var request = new NaamgevingenRequest()
        {
            KvkNummer = "69599068",
        };

        var response = await _kvkApiV1Client.GetNaamgevingenAsync(request);

        Assert.NotNull(response);
        Assert.Equal("69599068", response.KvkNummer);
    }
}