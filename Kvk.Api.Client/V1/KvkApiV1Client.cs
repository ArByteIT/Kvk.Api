using Kvk.Api.Client.Core;
using Kvk.Api.Client.Options;
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

    public async Task<ZoekResponse?> ZoekenAsync(ZoekRequest request, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(KvkOptions.HttpV2ClientName);
        var url = "zoeken?" + QueryParameterBuilder.ToQueryString(request);
        return await client.GetFromJsonAsync<ZoekResponse>(url, cancellationToken);
    }

    public void GetBasisProfielAsync(string kvkNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void GetBasisProfielEigenaarAsync(string kvkNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void GetBasisProfielHoofdvestigingAsync(string kvkNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void GetBasisProfielVestigingenAsync(string kvkNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void GetVestigingsprofielAsync(string vestigingsnummer, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void GetNaamgevingAsync(string kvkNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void GetAbonnementenAsync(string kvkNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
    public void GetAbonnementAsync(string kvkNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
    public void GetAbonnementSignaalAsync(string kvkNumber, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
