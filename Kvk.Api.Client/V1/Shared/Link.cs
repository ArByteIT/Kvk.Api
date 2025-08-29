using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Shared;

public class Link
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("href")]
    public string? Href { get; set; }

    [JsonPropertyName("rel")]
    public string? Rel { get; set; }

    [JsonPropertyName("method")]
    public string? Method { get; set; }
}
