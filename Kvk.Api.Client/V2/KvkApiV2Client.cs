using Kvk.Api.Client.Core;
using Kvk.Api.Client.Options;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V2;

public class KvkApiV2Client : IKvkApiV2Client
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly KvkOptions _options;

    public KvkApiV2Client(IHttpClientFactory httpClientFactory, IOptions<KvkOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<ZoekResponse?> ZoekenAsync(ZoekRequest request, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(KvkOptions.HttpV2ClientName);
        var url = "zoeken?" + QueryParameterBuilder.ToQueryString(request);
        return await client.GetFromJsonAsync<ZoekResponse>(url, cancellationToken);
    }
}
