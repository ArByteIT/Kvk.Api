using Kvk.Api.Client.V1.Shared;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Zoeken;

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
    [JsonPropertyName("handelsnaam")]
    public string? Handelsnaam { get; set; }

    /// <summary>
    /// The address of the branch or legal entity.
    /// </summary>
    [JsonPropertyName("adresType")]
    public string? AdresType { get; set; }

    [JsonPropertyName("straatnaam")]
    public string? Straatnaam { get; set; }

    [JsonPropertyName("huisnummer")]
    public string? Huisnummer { get; set; }

    [JsonPropertyName("huisnummerToevoeging")]
    public string? HuisnummerToevoeging { get; set; }

    [JsonPropertyName("postcode")]
    public string? Postcode { get; set; }

    [JsonPropertyName("plaats")]
    public string? Plaats { get; set; }

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
    [JsonPropertyName("links")]
    public Links? Links { get; set; }
}
