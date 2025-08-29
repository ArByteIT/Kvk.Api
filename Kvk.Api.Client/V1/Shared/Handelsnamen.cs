using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Shared;

public class Handelsnamen
{
    [JsonPropertyName("naam")]
    public string? Naam { get; set; }

    [JsonPropertyName("volgorde")]
    public int? Volgorde { get; set; }
}

