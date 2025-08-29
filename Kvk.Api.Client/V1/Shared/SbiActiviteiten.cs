using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Shared;

public class SbiActiviteiten
{
    [JsonPropertyName("sbiCode")]
    public string? SbiCode { get; set; }

    [JsonPropertyName("sbiOmschrijving")]
    public string? SbiOmschrijving { get; set; }

    [JsonPropertyName("indHoofdactiviteit")]
    public string? IndHoofdactiviteit { get; set; }
}

