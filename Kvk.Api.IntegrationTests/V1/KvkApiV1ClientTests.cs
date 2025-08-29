using Kvk.Api.Client.Exceptions;
using Kvk.Api.Client.V1;
using Sprache;

namespace Kvk.Api.IntegrationTests.V1;

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