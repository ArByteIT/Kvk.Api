using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Abonnementen;

public class Activiteiten
{
    [JsonPropertyName("sbiCode")]
    public string? SbiCode { get; set; }

    [JsonPropertyName("isHoofdactiviteit")]
    public bool? IsHoofdactiviteit { get; set; }
}
