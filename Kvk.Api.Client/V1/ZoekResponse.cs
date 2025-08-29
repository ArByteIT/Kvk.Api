using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class ZoekResponse
{
    /// <summary>
    /// Indicates the current page number. Starts from page 1.
    /// </summary>
    [JsonPropertyName("pagina")]
    public int? Pagina { get; set; }

    /// <summary>
    /// Indicates the number of search results per page.
    /// </summary>
    [JsonPropertyName("aantal")]
    public int? Aantal { get; set; }

    /// <summary>
    /// Total number of search results found. The Search API shows a maximum of 1000 results.
    /// </summary>
    [JsonPropertyName("totaal")]
    public int? Totaal { get; set; }

    /// <summary>
    /// Link to the previous page if available.
    /// </summary>
    [JsonPropertyName("vorige")]
    public string? Vorige { get; set; }

    /// <summary>
    /// Link to the next page if available.
    /// </summary>
    [JsonPropertyName("volgende")]
    public string? Volgende { get; set; }

    /// <summary>
    /// List of search result items.
    /// </summary>
    [JsonPropertyName("resultaten")]
    public List<Resultaat>? Resultaten { get; set; }

    /// <summary>
    /// HATEOAS links related to this resource.
    /// </summary>
    [JsonPropertyName("links")]
    public Links? Links { get; set; }
}
