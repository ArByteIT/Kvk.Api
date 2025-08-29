using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Basisprofielen;

public class AdditionalProp2
{
    [JsonPropertyName("href")]
    public string? Href { get; set; }

    [JsonPropertyName("hreflang")]
    public string? Hreflang { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("deprecation")]
    public string? Deprecation { get; set; }

    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("templated")]
    public bool? Templated { get; set; }
}

