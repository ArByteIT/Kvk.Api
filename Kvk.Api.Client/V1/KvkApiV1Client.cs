using Kvk.Api.Client.Core;
using Kvk.Api.Client.Options;
using Kvk.Api.Client.V1.Abonnementen;
using Kvk.Api.Client.V1.Basisprofielen;
using Kvk.Api.Client.V1.Naamgevingen;
using Kvk.Api.Client.V1.Vestigingsprofielen;
using Kvk.Api.Client.V1.Zoeken;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Net.Http.Json;

namespace Kvk.Api.Client.V1;

public class KvkApiV1Client : IKvkApiV1Client
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly HttpClient _httpClient;
    private readonly KvkOptions _options;

    public KvkApiV1Client(IHttpClientFactory httpClientFactory, HttpClient httpClient, IOptions<KvkOptions> options)
    {
        _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _options = options?.Value ?? throw new ArgumentNullException(nameof(options));
    }

    public async Task<AbonnementResponse?> GetAbonnementAsync(AbonnementRequest request, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(KvkOptions.HttpV1ClientName);
        var url = $"abonnementen/{request.AbonnementId}{QueryParameterBuilder.ToQueryString(request)}";
        return await client.GetFromJsonAsync<AbonnementResponse>(url, cancellationToken);
    }

    public async Task<AbonnementenResponse?> GetAbonnementenAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(KvkOptions.HttpV1ClientName);
        var url = "abonnementen";
        return await client.GetFromJsonAsync<AbonnementenResponse>(url, cancellationToken);
    }

    public async Task<AbonnementSignalenResponse?> GetAbonnementSignalenAsync(AbonnementSignalenRequest request, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(KvkOptions.HttpV1ClientName);
        var url = $"abonnementen/{request.AbonnementId}/signalen/{request.SignaalId}{QueryParameterBuilder.ToQueryString(request)}";
        return await client.GetFromJsonAsync<AbonnementSignalenResponse>(url, cancellationToken);
    }

    public async Task<BasisProfielResponse?> GetBasisprofielAsync(BasisProfielRequest request, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(KvkOptions.HttpV1ClientName);
        var url = $"basisprofielen/{request.KvkNummer}{QueryParameterBuilder.ToQueryString(request)}";
        return await client.GetFromJsonAsync<BasisProfielResponse>(url, cancellationToken);
    }

    public async Task<BasisprofielEigenaarResponse?> GetBasisprofielEigenaarAsync(BasisprofielEigenaarRequest request, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(KvkOptions.HttpV1ClientName);
        var url = $"basisprofielen/{request.KvkNummer}/eigenaar{QueryParameterBuilder.ToQueryString(request)}";
        return await client.GetFromJsonAsync<BasisprofielEigenaarResponse>(url, cancellationToken);
    }

    public async Task<BasisprofielHoofdvestigingResponse?> GetBasisprofielHoofdvestigingAsync(BasisprofielHoofdvestigingRequest request, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(KvkOptions.HttpV1ClientName);
        var url = $"basisprofielen/{request.KvkNummer}/hoofdvestiging{QueryParameterBuilder.ToQueryString(request)}";
        return await client.GetFromJsonAsync<BasisprofielHoofdvestigingResponse>(url, cancellationToken);
    }

    public async Task<BasisprofielVestigingenResponse?> GetBasisprofielVestigingenAsync(BasisprofielVestigingenRequest request, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(KvkOptions.HttpV1ClientName);
        var url = $"basisprofielen/{request.KvkNummer}/vestigingen{QueryParameterBuilder.ToQueryString(request)}";
        return await client.GetFromJsonAsync<BasisprofielVestigingenResponse>(url, cancellationToken);
    }

    public async Task<NaamgevingenResponse?> GetNaamgevingenAsync(NaamgevingenRequest request, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(KvkOptions.HttpV1ClientName);
        var url = $"naamgevingen/kvknummer/{request.KvkNummer}{QueryParameterBuilder.ToQueryString(request)}";
        return await client.GetFromJsonAsync<NaamgevingenResponse>(url, cancellationToken);
    }

    public async Task<VestigingsprofielenResponse?> GetVestigingsprofielenAsync(VestigingsprofielenRequest request, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(KvkOptions.HttpV1ClientName);
        var url = $"vestigingsprofielen/{request.Vestigingsnummer}{QueryParameterBuilder.ToQueryString(request)}";
        return await client.GetFromJsonAsync<VestigingsprofielenResponse>(url, cancellationToken);
    }

    public async Task<ZoekResponse?> ZoekenAsync(ZoekRequest request, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(KvkOptions.HttpV1ClientName);
        var url = $"zoeken{QueryParameterBuilder.ToQueryString(request)}";
        return await client.GetFromJsonAsync<ZoekResponse>(url, cancellationToken);
    }
}
