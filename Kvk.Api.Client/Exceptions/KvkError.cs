using System.Text.Json.Serialization;

namespace Kvk.Api.Client.Exceptions;

public class KvkError
{
    [JsonPropertyName("code")]
    public string Code { get; set; } = string.Empty;
    [JsonPropertyName("omschrijving")]
    public string Omschrijving { get; set; } = string.Empty;
}