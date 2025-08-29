using Kvk.Api.Client.V1.Shared;
using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Basisprofielen;

public class BasisprofielEigenaarResponse
{
    [JsonPropertyName("rsin")]
    public string? Rsin { get; set; }

    [JsonPropertyName("rechtsvorm")]
    public string? Rechtsvorm { get; set; }

    [JsonPropertyName("uitgebreideRechtsvorm")]
    public string? UitgebreideRechtsvorm { get; set; }

    [JsonPropertyName("adressen")]
    public List<Adressen> Adressen { get; set; } = new List<Adressen>();

    [JsonPropertyName("websites")]
    public List<string> Websites { get; set; } = new List<string>();

    [JsonPropertyName("_links")]
    public AdditionalPropLinks? Links { get; set; }
}

