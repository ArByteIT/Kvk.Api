using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Abonnementen;

public class Bezoekadres
{
    [JsonPropertyName("afgeschermd")]
    public bool? Afgeschermd { get; set; }

    [JsonPropertyName("postcode")]
    public Postcode? Postcode { get; set; }
}
