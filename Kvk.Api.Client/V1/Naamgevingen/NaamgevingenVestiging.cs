using Kvk.Api.Client.V1.Shared;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Naamgevingen;

public class NaamgevingenVestiging
{
    [JsonPropertyName("vestigingsnummer")]
    public string? Vestigingsnummer { get; set; }

    [JsonPropertyName("eersteHandelsnaam")]
    public string? EersteHandelsnaam { get; set; }

    [JsonPropertyName("handelsnamen")]
    public List<Handelsnamen> Handelsnamen { get; set; }

    [JsonPropertyName("_links")]
    public List<Link> Links { get; set; }

    [JsonPropertyName("naam")]
    public string? Naam { get; set; }

    [JsonPropertyName("ookGenoemd")]
    public string? OokGenoemd { get; set; }
}
