using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Abonnementen;

public class AbonnementResponse
{
    [JsonPropertyName("signalen")]
    public List<Signalen> Signalen { get; set; }

    [JsonPropertyName("pagina")]
    public int? Pagina { get; set; }

    [JsonPropertyName("aantal")]
    public int? Aantal { get; set; }

    [JsonPropertyName("totaal")]
    public int? Totaal { get; set; }

    [JsonPropertyName("totaalPaginas")]
    public int? TotaalPaginas { get; set; }

    [JsonPropertyName("vorige")]
    public string? Vorige { get; set; }

    [JsonPropertyName("volgende")]
    public string? Volgende { get; set; }
}
