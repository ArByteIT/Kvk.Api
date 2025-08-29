using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class MaterieleRegistratie
{
    [JsonPropertyName("datumAanvang")]
    public DateTime DatumAanvang { get; set; }

    [JsonPropertyName("datumEinde")]
    public DateTime DatumEinde { get; set; }
}

