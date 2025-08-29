using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V2;

/// <summary>
/// Represents a foreign address.
/// </summary>
public class BuitenlandsAdres
{
    /// <summary>
    /// Gets or sets the type of address (e.g., "bezoekadres", "postadres").
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the combined street and house number.
    /// </summary>
    [JsonPropertyName("straatHuisnummer")]
    public string? StraatHuisnummer { get; set; }

    /// <summary>
    /// Gets or sets the combined postcode and city.
    /// </summary>
    [JsonPropertyName("postcodeWoonplaats")]
    public string? PostcodeWoonplaats { get; set; }

    /// <summary>
    /// Gets or sets the name of the country where the address is located.
    /// </summary>
    [JsonPropertyName("land")]
    public string? Land { get; set; }
}
