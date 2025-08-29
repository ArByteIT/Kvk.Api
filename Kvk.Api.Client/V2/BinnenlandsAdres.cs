using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V2;

/// <summary>
/// Represents a domestic address.
/// </summary>
public class BinnenlandsAdres
{
    /// <summary>
    /// Gets or sets the type of address (e.g., "bezoekadres", "postadres").
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the street name.
    /// </summary>
    [JsonPropertyName("straatnaam")]
    public string? Straatnaam { get; set; }

    /// <summary>
    /// Gets or sets the house number.
    /// </summary>
    [JsonPropertyName("huisnummer")]
    public int? Huisnummer { get; set; }

    /// <summary>
    /// Gets or sets the house letter.
    /// </summary>
    [JsonPropertyName("huisletter")]
    public string? Huisletter { get; set; }

    /// <summary>
    /// Gets or sets the post office box number. Only shown if it is a post address.
    /// </summary>
    [JsonPropertyName("postbusnummer")]
    public int? Postbusnummer { get; set; }

    /// <summary>
    /// Gets or sets the postcode.
    /// </summary>
    [JsonPropertyName("postcode")]
    public string? Postcode { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    [JsonPropertyName("plaats")]
    public string? Plaats { get; set; }
}
