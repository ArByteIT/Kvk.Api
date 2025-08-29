using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Abonnementen;

public class Rechtspersoon
{
    [JsonPropertyName("activiteiten")]
    public List<object> Activiteiten { get; set; }

    [JsonPropertyName("bezoekadres")]
    public Bezoekadres Bezoekadres { get; set; }

    [JsonPropertyName("persoonRechtsvorm")]
    public string? PersoonRechtsvorm { get; set; }

    [JsonPropertyName("rsin")]
    public string? Rsin { get; set; }
}
