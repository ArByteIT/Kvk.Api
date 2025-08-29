using System.Text.Json.Serialization;

namespace Kvk.Api.Client.V1;

public class Postcode
{
    [JsonPropertyName("cijfercombinatie")]
    public string? Cijfercombinatie { get; set; }

    [JsonPropertyName("lettercombinatie")]
    public string? Lettercombinatie { get; set; }
}
