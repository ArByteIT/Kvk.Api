using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class Functionarissen
{
    [JsonPropertyName("aansprakelijke")]
    public bool? Aansprakelijke { get; set; }

    [JsonPropertyName("bestuursfunctie")]
    public bool? Bestuursfunctie { get; set; }

    [JsonPropertyName("functionarisBijzondereRechtstoestand")]
    public bool? FunctionarisBijzondereRechtstoestand { get; set; }

    [JsonPropertyName("gemachtigde")]
    public bool? Gemachtigde { get; set; }

    [JsonPropertyName("overigeFunctionaris")]
    public bool? OverigeFunctionaris { get; set; }

    [JsonPropertyName("publiekRechtelijkeFunctionaris")]
    public bool? PubliekRechtelijkeFunctionaris { get; set; }
}
