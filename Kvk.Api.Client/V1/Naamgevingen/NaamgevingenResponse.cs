using Kvk.Api.Client.V1.Shared;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Naamgevingen;

public class NaamgevingenResponse
{
    [JsonPropertyName("kvkNummer")]
    public string? KvkNummer { get; set; }

    [JsonPropertyName("rsin")]
    public string? Rsin { get; set; }

    [JsonPropertyName("statutaireNaam")]
    public string? StatutaireNaam { get; set; }

    [JsonPropertyName("naam")]
    public string? Naam { get; set; }

    [JsonPropertyName("ookGenoemd")]
    public string? OokGenoemd { get; set; }

    [JsonPropertyName("startdatum")]
    public string? Startdatum { get; set; }

    [JsonPropertyName("einddatum")]
    public string? Einddatum { get; set; }

    [JsonPropertyName("vestigingen")]
    public List<NaamgevingenVestiging> Vestigingen { get; set; } = new List<NaamgevingenVestiging>();

    [JsonPropertyName("_links")]
    public List<Link> Links { get; set; } = new List<Link>();
}
