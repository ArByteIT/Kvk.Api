using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V2;

/// <summary>
/// Represents a HATEOAS link.
/// </summary>
public class Link
{
    /// <summary>
    /// Gets or sets the target URL of the link.
    /// </summary>
    [JsonPropertyName("href")]
    public string? Href { get; set; }

    /// <summary>
    /// Gets or sets the language of the target resource.
    /// </summary>
    [JsonPropertyName("hreflang")]
    public string? Hreflang { get; set; }

    /// <summary>
    /// Gets or sets the title of the link.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets the media type of the target resource.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the deprecation warning for the link.
    /// </summary>
    [JsonPropertyName("deprecation")]
    public string? Deprecation { get; set; }

    /// <summary>
    /// Gets or sets the profile URI of the link.
    /// </summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>
    /// Gets or sets the name of the link.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the href is a URI template.
    /// </summary>
    [JsonPropertyName("templated")]
    public bool? Templated { get; set; }

    /// <summary>
    /// Gets or sets the link relation type.
    /// </summary>
    [JsonPropertyName("rel")]
    public string? Rel { get; set; }

    /// <summary>
    /// Gets or sets the HTTP method required to make the related call.
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }
}