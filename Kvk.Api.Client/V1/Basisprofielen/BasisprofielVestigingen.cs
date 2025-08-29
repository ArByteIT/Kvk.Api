using Kvk.Api.Client.V1.Shared;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Basisprofielen;

public class BasisprofielVestigingen
{
    [JsonPropertyName("vestigingsnummer")]
    public string? Vestigingsnummer { get; set; }

    [JsonPropertyName("kvkNummer")]
    public string? KvkNummer { get; set; }

    [JsonPropertyName("eersteHandelsnaam")]
    public string? EersteHandelsnaam { get; set; }

    [JsonPropertyName("indHoofdvestiging")]
    public string? IndHoofdvestiging { get; set; }

    [JsonPropertyName("indAdresAfgeschermd")]
    public string? IndAdresAfgeschermd { get; set; }

    [JsonPropertyName("indCommercieleVestiging")]
    public string? IndCommercieleVestiging { get; set; }

    [JsonPropertyName("volledigAdres")]
    public string? VolledigAdres { get; set; }

    [JsonPropertyName("_links")]
    public Links? Links { get; set; }
}
