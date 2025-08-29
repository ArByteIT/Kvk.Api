using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class HeeftBetrekkingOp
{
    [JsonPropertyName("kvkNummer")]
    public string? KvkNummer { get; set; }

    [JsonPropertyName("nonMailing")]
    public bool? NonMailing { get; set; }

    [JsonPropertyName("heeftAlsEigenaar")]
    public HeeftAlsEigenaar HeeftAlsEigenaar { get; set; }

    [JsonPropertyName("totaalWerkzamePersonen")]
    public int? TotaalWerkzamePersonen { get; set; }

    [JsonPropertyName("wordtUitgeoefendIn")]
    public List<WordtUitgeoefendIn> WordtUitgeoefendIn { get; set; }
}
