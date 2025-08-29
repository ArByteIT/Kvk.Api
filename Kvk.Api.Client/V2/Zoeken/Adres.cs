using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V2.Zoeken;

/// <summary>
/// Represents an address within a search result item.
/// This is specific to the Zoeken API and differs slightly from Vestigingsprofiel.Adres.
/// </summary>
public class Adres
{
    /// <summary>
    /// Gets or sets the domestic address.
    /// </summary>
    [JsonPropertyName("binnenlandsAdres")]
    public BinnenlandsAdres? BinnenlandsAdres { get; set; }

    /// <summary>
    /// Gets or sets the foreign address.
    /// </summary>
    [JsonPropertyName("buitenlandsAdres")]
    public BuitenlandsAdres? BuitenlandsAdres { get; set; }
}
