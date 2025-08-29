using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class Bezoekadres
{
    [JsonPropertyName("afgeschermd")]
    public bool? Afgeschermd { get; set; }

    [JsonPropertyName("postcode")]
    public Postcode Postcode { get; set; }
}
