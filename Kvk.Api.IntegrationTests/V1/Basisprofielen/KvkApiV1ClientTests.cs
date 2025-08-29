using Kvk.Api.Client.V1.Basisprofielen;

namespace Kvk.Api.IntegrationTests.V1.Basisprofielen;

public class KvkApiV1ClientTests : BaseTests
{
    [Fact]
    public async Task GetBasisprofielAsync_SearchKvkNumber_ReturnsSuccess()
    {
        var request = new BasisProfielRequest()
        {
            KvkNummer = "69599076",
        };

        var response = await _kvkApiV1Client.GetBasisprofielAsync(request);

        Assert.NotNull(response);
        Assert.Equal("69599076", response.KvkNummer);
    }

    [Fact]
    public async Task GetBasisprofielEigenaarAsync_SearchKvkNumber_ReturnsSuccess()
    {
        var request = new BasisprofielEigenaarRequest()
        {
            KvkNummer = "69599076",
        };

        var response = await _kvkApiV1Client.GetBasisprofielEigenaarAsync(request);

        Assert.NotNull(response);
    }

    [Fact]
    public async Task GetBasisprofielHoofdvestigingAsync_SearchKvkNumber_ReturnsSuccess()
    {
        var request = new BasisprofielHoofdvestigingRequest()
        {
            KvkNummer = "69599076",
        };

        var response = await _kvkApiV1Client.GetBasisprofielHoofdvestigingAsync(request);

        Assert.NotNull(response);
        Assert.Equal("69599076", response.KvkNummer);
    }

    [Fact]
    public async Task GetBasisprofielVestigingenAsync_SearchKvkNumber_ReturnsSuccess()
    {
        var request = new BasisprofielVestigingenRequest()
        {
            KvkNummer = "69599076",
        };

        var response = await _kvkApiV1Client.GetBasisprofielVestigingenAsync(request);

        Assert.NotNull(response);
        Assert.Equal("69599076", response.KvkNummer);
    }
}