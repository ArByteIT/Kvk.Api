using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V2;

/// <summary>
/// Represents a single item in the KVK search result.
/// </summary>
public class Resultaat
{
    /// <summary>
    /// Nederlands Kamer van Koophandel nummer that consists of 8 digits.
    /// </summary>
    [JsonPropertyName("kvkNummer")]
    public string? KvkNummer { get; set; }

    /// <summary>
    /// Rechtspersonen Samenwerkingsverbanden Informatie Nummer that consists of 9 digits.
    /// </summary>
    [JsonPropertyName("rsin")]
    public string? Rsin { get; set; }

    /// <summary>
    /// Vestigingsnummer that consists of 12 digits.
    /// </summary>
    [JsonPropertyName("vestigingsnummer")]
    public string? Vestigingsnummer { get; set; }

    /// <summary>
    /// The name under which a branch or legal entity trades.
    /// </summary>
    [JsonPropertyName("naam")]
    public string? Naam { get; set; }

    /// <summary>
    /// The address of the branch or legal entity.
    /// </summary>
    [JsonPropertyName("adres")]
    public Adres? Adres { get; set; }

    /// <summary>
    /// Type: hoofdvestiging (main branch), nevenvestiging (sub-branch), or rechtspersoon (legal entity).
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Indication if the registration is active.
    /// </summary>
    [JsonPropertyName("actief")]
    public string? Actief { get; set; }

    /// <summary>
    /// Contains the expired name under which a branch or legal entity has traded.
    /// </summary>
    [JsonPropertyName("vervallenNaam")]
    public string? VervallenNaam { get; set; }

    /// <summary>
    /// HATEOAS links related to this resource.
    /// </summary>
    [JsonPropertyName("_links")]
    public Links? Links { get; set; }
}
