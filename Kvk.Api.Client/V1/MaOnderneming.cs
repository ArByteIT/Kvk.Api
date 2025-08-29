using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class MaOnderneming
{
    [JsonPropertyName("algemeen")]
    public bool? Algemeen { get; set; }
}
