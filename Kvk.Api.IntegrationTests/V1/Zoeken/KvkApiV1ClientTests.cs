using Kvk.Api.Client.Exceptions;
using Kvk.Api.Client.V1.Zoeken;

namespace Kvk.Api.IntegrationTests.V1.Zoeken;

public class KvkApiV1ClientTests : BaseTests
{
    public KvkApiV1ClientTests() : base()
    {
    }

    [Fact]
    public async Task SearchAsync_SearchKvkNumber_ReturnsSuccess()
    {
        var request = new ZoekRequest()
        {
            KvkNummer = "69599076",
        };

        var response = await _kvkApiV1Client.ZoekenAsync(request);

        Assert.NotNull(response);
        Assert.NotNull(response.Resultaten);

        foreach (var result in response.Resultaten)
        {
            Assert.Equal("69599076", result.KvkNummer);
        }
    }

    [Fact]
    public async Task SearchAsync_SearchKvkNumber_ReturnsNotFound()
    {
        var request = new ZoekRequest()
        {
            KvkNummer = "97401862",
        };

        // Should throw KvkApiNotFoundException
        await Assert.ThrowsAsync<KvkApiNotFoundException>(() => _kvkApiV1Client.ZoekenAsync(request));
    }

    [Fact]
    public async Task SearchAsync_SearchKvkNumber_ReturnsBadRequest()
    {
        var request = new ZoekRequest()
        {
            KvkNummer = "1234567",
        };

        // Should throw KvkApiNotFoundException
        await Assert.ThrowsAsync<KvkApiBadRequestException>(() => _kvkApiV1Client.ZoekenAsync(request));
    }
}