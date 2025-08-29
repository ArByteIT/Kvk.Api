using Kvk.Api.Client.Exceptions;
using Kvk.Api.Client.V2;

namespace Kvk.Api.IntegrationTests.V2;

public class KvkApiV2ClientTests : BaseTests
{
    public KvkApiV2ClientTests() : base()
    {
    }

    [Fact]
    public async Task SearchAsync_SearchKvkNumber_ReturnsSuccess()
    {
        var request = new ZoekRequest()
        {
            KvkNummer = "69599084",
        };

        var response = await _kvkApiV2Client.ZoekenAsync(request);

        Assert.NotNull(response);
        Assert.NotNull(response.Resultaten);

        foreach (var result in response.Resultaten)
        {
            Assert.Equal("69599084", result.KvkNummer);
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
        await Assert.ThrowsAsync<KvkApiNotFoundException>(() => _kvkApiV2Client.ZoekenAsync(request));
    }

    [Fact]
    public async Task SearchAsync_SearchKvkNumber_ReturnsBadRequest()
    {
        var request = new ZoekRequest()
        {
            KvkNummer = "1234567",
        };

        // Should throw KvkApiNotFoundException
        await Assert.ThrowsAsync<KvkApiBadRequestException>(() => _kvkApiV2Client.ZoekenAsync(request));
    }
}
