using Kvk.Api.Client.V1.Shared;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Abonnementen;

public class Signalen
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }

    [JsonPropertyName("kvknummer")]
    public string? Kvknummer { get; set; }

    [JsonPropertyName("signaalType")]
    public string? SignaalType { get; set; }

    [JsonPropertyName("vestigingsnummer")]
    public string? Vestigingsnummer { get; set; }

    [JsonPropertyName("links")]
    public List<Link> Links { get; set; } = new List<Link>();
}
