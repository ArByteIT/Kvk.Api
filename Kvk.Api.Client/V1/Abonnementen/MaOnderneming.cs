using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1.Abonnementen;

public class MaOnderneming
{
    [JsonPropertyName("algemeen")]
    public bool? Algemeen { get; set; }
}
