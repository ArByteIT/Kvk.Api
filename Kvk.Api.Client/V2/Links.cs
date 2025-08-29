using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V2;

/// <summary>
/// Represents a collection of HATEOAS links.
/// </summary>
public class Links
{
    // This class is intended to map to a JSON object where keys are link relation types
    // and values are Link objects. Due to the dynamic nature of these keys,
    // it's often better to use a Dictionary<string, Link> directly in the parent model
    // or a custom converter if the structure is fixed but keys are dynamic.
    // For simplicity and common usage, we'll assume a direct mapping for known links
    // and use a Dictionary for additional properties if needed.
    // The OpenAPI spec uses 'additionalProperties', which implies a dictionary.
    // However, some schemas like Naamgeving explicitly define 'self' and 'basisprofiel' links.

    /// <summary>
    /// Gets or sets the 'self' link.
    /// </summary>
    [JsonPropertyName("self")]
    public Link? Self { get; set; }

    /// <summary>
    /// Gets or sets the 'basisprofiel' link.
    /// </summary>
    [JsonPropertyName("basisprofiel")]
    public Link? Basisprofiel { get; set; }

    /// <summary>
    /// Gets or sets the 'vestigingsprofiel' link.
    /// </summary>
    [JsonPropertyName("vestigingsprofiel")]
    public Link? Vestigingsprofiel { get; set; }

    /// <summary>
    /// Gets or sets a dictionary of additional links, where the key is the link relation type.
    /// </summary>
    [JsonExtensionData]
    public Dictionary<string, object>? AdditionalLinks { get; set; }
}
