using Kvk.Api.Client.V1.Abonnementen;

namespace Kvk.Api.IntegrationTests.V1.Abonnementen;

public class KvkApiV1ClientTests : BaseTests
{
    [Fact]
    public async Task GetAbonnementenAsync_ReturnsSuccess()
    {
        var response = await _kvkApiV1Client.GetAbonnementenAsync();

        Assert.NotNull(response);
        Assert.NotNull(response.Abonnementen);
    }

    [Fact]
    public async Task GetAbonnementAsync_SearchAbonnementId_ReturnsSuccess()
    {
        var request = new AbonnementRequest()
        {
            AbonnementId = "1365acf9-0b63-3ed4-9e68-a8c37425080b",
        };

        var response = await _kvkApiV1Client.GetAbonnementAsync(request);

        Assert.NotNull(response);
        Assert.NotNull(response.Signalen);
    }

    [Fact]
    public async Task GetAbonnementSignalenAsync_SearchAbonnementIdSignaalId_ReturnsSuccess()
    {
        var request = new AbonnementSignalenRequest()
        {
            AbonnementId = "1365acf9-0b63-3ed4-9e68-a8c37425080b",
            SignaalId = "a816c1f6-51b8-4c92-b8b3-44fce6410e8b",
        };

        var response = await _kvkApiV1Client.GetAbonnementSignalenAsync(request);

        Assert.NotNull(response);
        Assert.NotNull(response.Signaal);
    }
}