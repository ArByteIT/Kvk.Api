using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class Abonnement
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("contract")]
    public Contract Contract { get; set; }

    [JsonPropertyName("startDatum")]
    public DateTime? StartDatum { get; set; }

    [JsonPropertyName("eindDatum")]
    public DateTime? EindDatum { get; set; }

    [JsonPropertyName("actief")]
    public bool? Actief { get; set; }

    [JsonPropertyName("links")]
    public List<Link> Links { get; set; }
}
