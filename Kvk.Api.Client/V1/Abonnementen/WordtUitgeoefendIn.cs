using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Abonnementen;

public class WordtUitgeoefendIn
{
    [JsonPropertyName("vestigingsnummer")]
    public string? Vestigingsnummer { get; set; }

    [JsonPropertyName("activiteiten")]
    public List<Activiteiten> Activiteiten { get; set; }

    [JsonPropertyName("bezoekadres")]
    public Bezoekadres Bezoekadres { get; set; }

    [JsonPropertyName("isHoofdvestiging")]
    public bool? IsHoofdvestiging { get; set; }

    [JsonPropertyName("totaalWerkzamePersonen")]
    public int? TotaalWerkzamePersonen { get; set; }
}
