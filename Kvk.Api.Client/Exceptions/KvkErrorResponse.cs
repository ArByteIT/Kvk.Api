using System.Text.Json.Serialization;

namespace Kvk.Api.Client.Exceptions;

public class KvkErrorResponse
{
    [JsonPropertyName("fout")]
    public List<KvkError> Errors { get; set; } = [];
}
