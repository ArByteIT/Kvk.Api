using System.Net;
using System.Text.Json;

namespace Kvk.Api.Client.Exceptions;

/// <summary>
/// https://developers.kvk.nl/nl/documentation#status-codes
/// </summary>
public sealed class KvkApiErrorHandler : DelegatingHandler
{
    private readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var response = await base.SendAsync(request, cancellationToken);
        var content = await response.Content.ReadAsStringAsync(cancellationToken);

        try
        {
            var errorResponse = JsonSerializer.Deserialize<KvkErrorResponse>(content, _jsonSerializerOptions);

            if (errorResponse != null)
            {
                if (errorResponse.Errors != null && errorResponse.Errors.Count != 0)
                {
                    foreach (var error in errorResponse.Errors)
                    {
                        ThrowApiException(error, response.StatusCode);
                    }
                }
            }
        }
        catch (JsonException)
        {
            // Malformed JSON - optionally ignore here, or throw depending on how strict you want to be
            // For now, ignore and let downstream handle invalid JSON
        }

        return response;
    }

    private static void ThrowApiException(KvkError error, HttpStatusCode httpStatusCode)
    {
        throw httpStatusCode switch
        {
            HttpStatusCode.BadRequest => new KvkApiBadRequestException(error.Code, error.Omschrijving),
            HttpStatusCode.NotFound => new KvkApiNotFoundException(error.Code, error.Omschrijving),
            HttpStatusCode.InternalServerError => new KvkApiServerException(error.Code, error.Omschrijving),
            _ => new KvkApiException(error.Code, error.Omschrijving, httpStatusCode),
        };
    }
}
