using Kvk.Api.Client.V1.Abonnementen;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Basisprofielen;

public class Signaal
{
    [JsonPropertyName("berichtId")]
    public string? BerichtId { get; set; }

    [JsonPropertyName("heeftBetrekkingOp")]
    public HeeftBetrekkingOp? HeeftBetrekkingOp { get; set; }

    [JsonPropertyName("registratieId")]
    public string? RegistratieId { get; set; }

    [JsonPropertyName("registratieTijdstip")]
    public DateTime? RegistratieTijdstip { get; set; }

    [JsonPropertyName("signaalType")]
    public string? SignaalType { get; set; }

    [JsonPropertyName("heeftGewijzigdeGegevens")]
    public HeeftGewijzigdeGegevens? HeeftGewijzigdeGegevens { get; set; }

    [JsonPropertyName("indicatieCorrectie")]
    public bool? IndicatieCorrectie { get; set; }
}
